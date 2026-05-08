using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuginTest
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient Client = CreateHttpClient();
        private readonly List<SaleItem> saleItems = new List<SaleItem>();
        private readonly List<PaymentItem> paymentItems = new List<PaymentItem>();
        private bool isRegenerating;
        private decimal currentDocumentTotal;

        public Form1()
        {
            InitializeComponent();

            txtBaseUrl.Text = "https://192.168.2.41:4443";
            txtSoftwareId.Text = "6210305023";
            txtHardwareId.Text = "40:C2:BA:4E:E2:D2";
            txtSerialNo.Text = "FU00007382";
            txtDocumentId.Text = "";
            txtStartBody.Text = "{\r\n  \"docCategory\": \"SALE\"\r\n}";

            cmbSaleType.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;
            cmbPaymentType.SelectedIndex = 0;
            cmbCurrency.SelectedIndex = 0;
            txtItemName.Text = "DETERJAN 2.5 KG";
            nudUnitPrice.Value = 100;
            nudQuantity.Value = 1;
            nudVatRate.Value = 20;
            nudDiscountRate.Value = 10;
            nudDepartmentId.Value = 2;
            cmbDepartment.Items.Add(new DepartmentOption(2, "2 - Genel", 20));
            cmbDepartment.SelectedIndex = 0;

            LoadSampleSaleBody();
        }

        private static HttpClient CreateHttpClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };

            var client = new HttpClient(handler);
            client.Timeout = Timeout.InfiniteTimeSpan;
            return client;
        }

        private async void btnStatus_Click(object sender, EventArgs e)
        {
            var content = await RunRequestAsync("Durum", HttpMethod.Get, "/v1/status", null);
            var documentId = TryReadActiveDocumentId(content);

            if (!string.IsNullOrWhiteSpace(documentId))
            {
                txtDocumentId.Text = documentId;
                Log("** aktif documentId durum cevabindan alindi: " + documentId);
            }

            await LoadSettingsAsync(false);
        }

        private async void btnStartDocument_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDocumentId.Text))
            {
                Log("!! Acik documentId var. Yeni belge baslatmadan once JSON Gonder, Satis Iptal veya ID Temizle kullan.");
                return;
            }

            var content = await RunRequestAsync("Belge Baslat", HttpMethod.Post, "/v1/documents", txtStartBody.Text);
            var documentId = TryReadDocumentId(content);

            if (!string.IsNullOrWhiteSpace(documentId))
            {
                txtDocumentId.Text = documentId;
                Log("** documentId alindi ve kutuya yazildi: " + documentId);
            }
        }

        private async void btnSendJson_Click(object sender, EventArgs e)
        {
            await SendSaleJsonAsync();
        }

        private async void btnSampleSend_Click(object sender, EventArgs e)
        {
            LoadSampleSaleBody();
            await SendSaleJsonAsync();
        }

        private async void btnCancelSale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentId.Text))
            {
                Log("!! Iptal icin once aktif documentId gerekli.");
                return;
            }

            await RunRequestAsync("Satis Iptal", HttpMethod.Post, "/v1/documents/" + txtDocumentId.Text.Trim() + "/cancel", null);
            txtDocumentId.Text = "";
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {
            await LoadSettingsAsync(true);
        }

        private async void btnXReport_Click(object sender, EventArgs e)
        {
            await RunRequestAsync("X Raporu Yazdir", HttpMethod.Get, "/v1/reports/X/print", null);
        }

        private async void btnZReport_Click(object sender, EventArgs e)
        {
            await RunRequestAsync("Z Raporu Yazdir", HttpMethod.Post, "/v1/reports/Z/print", null);
        }

        private void btnClearDocument_Click(object sender, EventArgs e)
        {
            txtDocumentId.Text = "";
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            LoadSampleSaleBody();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new SaleItem
            {
                Name = txtItemName.Text.Trim(),
                DepartmentId = GetSelectedDepartmentId(),
                Quantity = nudQuantity.Value,
                Unit = cmbUnit.Text,
                UnitPrice = nudUnitPrice.Value,
                VatRate = (int)nudVatRate.Value,
                DiscountRate = nudDiscountRate.Value
            };

            if (string.IsNullOrWhiteSpace(item.Name))
            {
                Log("!! Kalem adi bos olamaz.");
                return;
            }

            saleItems.Add(item);
            RegenerateSaleBody();
            Log("** kalem eklendi: " + item.Name);
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            saleItems.Clear();
            paymentItems.Clear();
            RegenerateSaleBody();
            Log("** kalem ve odemeler temizlendi.");
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            RemoveAutoPayment();

            paymentItems.Add(new PaymentItem
            {
                Type = cmbPaymentType.Text,
                Amount = CalculatePaymentTryAmount(),
                ForeignAmount = nudPaymentAmount.Value,
                CurrencyCode = cmbCurrency.Text,
                ExchangeRate = nudExchangeRate.Value
            });

            RegenerateSaleBody();
            Log("** odeme eklendi: " + cmbPaymentType.Text + " " + FormatMoney(nudPaymentAmount.Value) + " " + cmbCurrency.Text);
        }

        private void btnClearPayments_Click(object sender, EventArgs e)
        {
            paymentItems.Clear();
            RegenerateSaleBody();
            Log("** odemeler temizlendi.");
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var option = cmbDepartment.SelectedItem as DepartmentOption;
            if (option == null)
            {
                return;
            }

            nudDepartmentId.Value = option.Id;
            nudVatRate.Value = option.VatRate;
        }

        private void saleOption_Changed(object sender, EventArgs e)
        {
            if (!isRegenerating)
            {
                UpdatePaymentAmountSuggestion();
            }
        }

        private async Task SendSaleJsonAsync()
        {
            if (string.IsNullOrWhiteSpace(txtDocumentId.Text))
            {
                Log("!! Once Belge Baslat ile documentId alin ya da Durum Test ile aktif documentId cek.");
                return;
            }

            var content = await RunRequestAsync("JSON Gonder", HttpMethod.Put, "/v1/documents/" + txtDocumentId.Text.Trim(), txtSaleBody.Text);

            if (IsSuccessResponse(content))
            {
                txtDocumentId.Text = "";
                Log("** satis tamamlandi, documentId temizlendi.");
            }
        }

        private async Task LoadSettingsAsync(bool logResponse)
        {
            var content = await RunRequestAsync("Ayarlar", HttpMethod.Get, "/v1/settings", null);
            LoadDepartmentsFromSettings(content);

            if (!logResponse)
            {
                Log("** baglanti kontrolu sonrasi kisim listesi guncellendi.");
            }
        }

        private async Task<string> RunRequestAsync(string title, HttpMethod method, string path, string body)
        {
            ToggleButtons(false);
            string responseContent = null;

            try
            {
                var requestUri = BuildUri(path);
                Log(">> " + title + " istegi: " + method + " " + requestUri);

                using (var request = new HttpRequestMessage(method, requestUri))
                {
                    AddDeviceHeaders(request);

                    if (!string.IsNullOrWhiteSpace(body))
                    {
                        request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                    }

                    using (var response = await Client.SendAsync(request))
                    {
                        responseContent = await response.Content.ReadAsStringAsync();
                        Log("<< HTTP " + (int)response.StatusCode + " " + response.ReasonPhrase);
                        Log(string.IsNullOrWhiteSpace(responseContent) ? "(bos cevap)" : responseContent);
                    }
                }
            }
            catch (Exception ex)
            {
                Log("!! Hata: " + ex.Message);
            }
            finally
            {
                ToggleButtons(true);
            }

            return responseContent;
        }

        private Uri BuildUri(string path)
        {
            var baseUrl = txtBaseUrl.Text.Trim().TrimEnd('/');
            var normalizedPath = path.Trim();

            if (!normalizedPath.StartsWith("/"))
            {
                normalizedPath = "/" + normalizedPath;
            }

            return new Uri(baseUrl + normalizedPath);
        }

        private void AddDeviceHeaders(HttpRequestMessage request)
        {
            request.Headers.TryAddWithoutValidation("X-SoftwareId", txtSoftwareId.Text.Trim());
            request.Headers.TryAddWithoutValidation("X-HardwareId", txtHardwareId.Text.Trim());
            request.Headers.TryAddWithoutValidation("X-SerialNo", txtSerialNo.Text.Trim());
        }

        private static string TryReadDocumentId(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return null;
            }

            var match = Regex.Match(content, "\"documentId\"\\s*:\\s*\"([^\"]+)\"");
            return match.Success ? match.Groups[1].Value : null;
        }

        private static string TryReadActiveDocumentId(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return null;
            }

            var activeMatch = Regex.Match(content, "\"activeDocument\"\\s*:\\s*\\{[^\\}]*\"documentId\"\\s*:\\s*\"([^\"]+)\"");
            return activeMatch.Success ? activeMatch.Groups[1].Value : null;
        }

        private void LoadSampleSaleBody()
        {
            saleItems.Clear();
            paymentItems.Clear();

            for (var i = 0; i < 3; i++)
            {
                saleItems.Add(new SaleItem
                {
                    Name = "DETERJAN 2.5 KG",
                    DepartmentId = 2,
                    Quantity = 1,
                    Unit = "AD",
                    UnitPrice = 100,
                    VatRate = 20,
                    DiscountRate = 10
                });
            }

            paymentItems.Add(new PaymentItem { Type = "CASH", Amount = 270, ForeignAmount = 270, CurrencyCode = "TRY", ExchangeRate = 1, IsAuto = true });
            RegenerateSaleBody();
        }

        private void RegenerateSaleBody()
        {
            isRegenerating = true;
            var documentTotal = 0m;
            var weightedNet = 0m;
            var builder = new StringBuilder();

            builder.AppendLine("{");
            builder.AppendLine("  \"saleType\": \"" + EscapeJson(cmbSaleType.Text) + "\",");
            builder.AppendLine("  \"items\": [");

            for (var i = 0; i < saleItems.Count; i++)
            {
                var item = saleItems[i];
                var gross = item.Quantity * item.UnitPrice;
                var discount = gross * item.DiscountRate / 100m;
                var lineTotal = gross - discount;
                var net = item.VatRate > 0 ? lineTotal / (1m + item.VatRate / 100m) : lineTotal;

            documentTotal += lineTotal;
            weightedNet += net;

                builder.AppendLine("    {");
                builder.AppendLine("      \"name\": \"" + EscapeJson(item.Name) + "\",");
                builder.AppendLine("      \"departmentId\": " + item.DepartmentId + ",");
                builder.AppendLine("      \"quantity\": " + FormatNumber(item.Quantity) + ",");
                builder.AppendLine("      \"unit\": \"" + EscapeJson(item.Unit) + "\",");
                builder.AppendLine("      \"unitPrice\": \"" + FormatMoney(item.UnitPrice) + "\",");
                builder.AppendLine("      \"amount\": \"" + FormatMoney(gross) + "\",");
                builder.AppendLine("      \"vatRate\": " + item.VatRate + (item.DiscountRate > 0 ? "," : ""));

                if (item.DiscountRate > 0)
                {
                    builder.AppendLine("      \"discount\": {");
                    builder.AppendLine("        \"rate\": " + FormatNumber(item.DiscountRate) + ",");
                    builder.AppendLine("        \"note\": \"INDIRIM\"");
                    builder.AppendLine("      }");
                }

                builder.Append("    }");
                builder.AppendLine(i == saleItems.Count - 1 ? "" : ",");
            }

            builder.AppendLine("  ],");
            builder.AppendLine("  \"payments\": [");

            currentDocumentTotal = documentTotal;
            SyncSingleCashPayment(documentTotal);
            ValidatePaymentTotal(documentTotal);

            var paymentsToWrite = new List<PaymentItem>(paymentItems);
            if (paymentsToWrite.Count == 0 && documentTotal > 0)
            {
                paymentsToWrite.Add(new PaymentItem { Type = "CASH", Amount = documentTotal, ForeignAmount = documentTotal, CurrencyCode = "TRY", ExchangeRate = 1, IsAuto = true });
            }

            for (var i = 0; i < paymentsToWrite.Count; i++)
            {
                var payment = paymentsToWrite[i];
                builder.AppendLine("    {");
                builder.AppendLine("      \"type\": \"" + EscapeJson(payment.Type) + "\",");
                builder.AppendLine("      \"amount\": \"" + FormatMoney(payment.Amount) + "\"" + (payment.CurrencyCode != "TRY" ? "," : ""));

                if (payment.CurrencyCode != "TRY")
                {
                    builder.AppendLine("      \"currencyCode\": \"" + EscapeJson(payment.CurrencyCode) + "\",");
                    builder.AppendLine("      \"foreignAmount\": \"" + FormatMoney(payment.ForeignAmount) + "\",");
                    builder.AppendLine("      \"exchangeRate\": \"" + FormatNumber(payment.ExchangeRate) + "\"");
                }

                builder.Append("    }");
                builder.AppendLine(i == paymentsToWrite.Count - 1 ? "" : ",");
            }

            builder.AppendLine("  ],");
            builder.AppendLine("  \"totals\": {");
            builder.AppendLine("    \"documentTotal\": \"" + FormatMoney(documentTotal) + "\",");
            builder.AppendLine("    \"netTotal\": \"" + FormatMoney(weightedNet) + "\"");
            builder.AppendLine("  },");

            builder.AppendLine("  \"footerNotes\": [");
            builder.AppendLine("    \" **** IYI GUNLER ****\",");
            builder.AppendLine("    \" HuginTest\"");
            builder.AppendLine("  ]");
            builder.AppendLine("}");

            RefreshPaymentsList();
            txtSaleBody.Text = builder.ToString();
            UpdatePaymentAmountSuggestion();
            isRegenerating = false;
        }

        private void LoadDepartmentsFromSettings(string content)
        {
            if (string.IsNullOrWhiteSpace(content) || !IsSuccessResponse(content))
            {
                return;
            }

            var matches = Regex.Matches(
                content,
                "\"id\"\\s*:\\s*(\\d+)\\s*,\\s*\"name\"\\s*:\\s*\"([^\"]+)\"(?:\\s*,\\s*\"maxAllowedSalesAmount\"\\s*:\\s*\"?[^\"]*\"?)?\\s*,\\s*\"vatRate\"\\s*:\\s*(\\d+)");

            if (matches.Count == 0)
            {
                return;
            }

            cmbDepartment.Items.Clear();

            foreach (Match match in matches)
            {
                var id = int.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                var name = match.Groups[2].Value;
                var vatRate = int.Parse(match.Groups[3].Value, CultureInfo.InvariantCulture);
                cmbDepartment.Items.Add(new DepartmentOption(id, id + " - " + name, vatRate));
            }

            if (cmbDepartment.Items.Count > 0)
            {
                cmbDepartment.SelectedIndex = 0;
            }

            Log("** " + cmbDepartment.Items.Count + " kisim yüklendi.");
        }

        private int GetSelectedDepartmentId()
        {
            var option = cmbDepartment.SelectedItem as DepartmentOption;
            return option != null ? option.Id : (int)nudDepartmentId.Value;
        }

        private void RefreshPaymentsList()
        {
            lstPayments.Items.Clear();

            foreach (var payment in paymentItems)
            {
                var text = payment.Type + " " + FormatMoney(payment.Amount);

                if (payment.CurrencyCode != "TRY")
                {
                    text += " " + payment.CurrencyCode + " kur " + FormatNumber(payment.ExchangeRate);
                }

                lstPayments.Items.Add(text);
            }
        }

        private decimal CalculatePaymentTryAmount()
        {
            if (cmbCurrency.Text == "TRY")
            {
                return nudPaymentAmount.Value;
            }

            return Math.Round(nudPaymentAmount.Value * nudExchangeRate.Value, 2);
        }

        private void UpdatePaymentAmountSuggestion()
        {
            var remainingTry = currentDocumentTotal;

            foreach (var payment in paymentItems)
            {
                remainingTry -= payment.Amount;
            }

            if (remainingTry < 0)
            {
                remainingTry = 0;
            }

            var suggested = remainingTry;

            if (cmbCurrency.Text != "TRY" && nudExchangeRate.Value > 0)
            {
                suggested = Math.Round(remainingTry / nudExchangeRate.Value, 2);
            }

            if (suggested <= nudPaymentAmount.Maximum)
            {
                nudPaymentAmount.Value = suggested;
            }
        }

        private void ValidatePaymentTotal(decimal documentTotal)
        {
            if (paymentItems.Count == 0)
            {
                return;
            }

            var paymentTotal = 0m;
            foreach (var payment in paymentItems)
            {
                paymentTotal += payment.Amount;
            }

            if (paymentTotal != documentTotal)
            {
                Log("!! Odeme toplami " + FormatMoney(paymentTotal) + " TL, sepet toplami " + FormatMoney(documentTotal) + " TL. Kalan: " + FormatMoney(documentTotal - paymentTotal) + " TL");
            }
        }

        private static string EscapeJson(string value)
        {
            return (value ?? "").Replace("\\", "\\\\").Replace("\"", "\\\"");
        }

        private static string FormatMoney(decimal value)
        {
            return value.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private static string FormatNumber(decimal value)
        {
            return value.ToString("0.###", CultureInfo.InvariantCulture);
        }

        private void SyncSingleCashPayment(decimal documentTotal)
        {
            if (paymentItems.Count == 1 && paymentItems[0].Type == "CASH" && paymentItems[0].IsAuto)
            {
                paymentItems[0].Amount = documentTotal;
                paymentItems[0].ForeignAmount = documentTotal;
                paymentItems[0].CurrencyCode = "TRY";
                paymentItems[0].ExchangeRate = 1;
            }
        }

        private void RemoveAutoPayment()
        {
            if (paymentItems.Count == 1 && paymentItems[0].IsAuto)
            {
                paymentItems.Clear();
            }
        }

        private static bool IsSuccessResponse(string content)
        {
            return !string.IsNullOrWhiteSpace(content) && Regex.IsMatch(content, "\"status\"\\s*:\\s*\"SUCCESS\"");
        }

        private void ToggleButtons(bool enabled)
        {
            btnStatus.Enabled = enabled;
            btnStartDocument.Enabled = enabled;
            btnSendJson.Enabled = enabled;
            btnSampleSend.Enabled = enabled;
            btnSample.Enabled = enabled;
            btnClearDocument.Enabled = enabled;
            btnCancelSale.Enabled = enabled;
            btnSettings.Enabled = enabled;
            btnXReport.Enabled = enabled;
            btnZReport.Enabled = enabled;
            btnAddItem.Enabled = enabled;
            btnAddPayment.Enabled = enabled;
            btnClearItems.Enabled = enabled;
            btnClearPayments.Enabled = enabled;
        }

        private void Log(string message)
        {
            txtLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + "  " + message + Environment.NewLine + Environment.NewLine);
        }

        private class SaleItem
        {
            public string Name { get; set; }
            public int DepartmentId { get; set; }
            public decimal Quantity { get; set; }
            public string Unit { get; set; }
            public decimal UnitPrice { get; set; }
            public int VatRate { get; set; }
            public decimal DiscountRate { get; set; }
        }

        private class PaymentItem
        {
            public string Type { get; set; }
            public decimal Amount { get; set; }
            public decimal ForeignAmount { get; set; }
            public string CurrencyCode { get; set; }
            public decimal ExchangeRate { get; set; }
            public bool IsAuto { get; set; }
        }

        private class DepartmentOption
        {
            public DepartmentOption(int id, string text, int vatRate)
            {
                Id = id;
                Text = text;
                VatRate = vatRate;
            }

            public int Id { get; private set; }
            public string Text { get; private set; }
            public int VatRate { get; private set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
