namespace HuginTest
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.TableLayoutPanel connLayout;
        private System.Windows.Forms.Label lblBaseUrl;
        private System.Windows.Forms.Label lblSoftwareId;
        private System.Windows.Forms.Label lblHardwareId;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblDocumentId;
        private System.Windows.Forms.Label lblStartBody;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.TextBox txtSoftwareId;
        private System.Windows.Forms.TextBox txtHardwareId;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.TextBox txtDocumentId;
        private System.Windows.Forms.TextBox txtStartBody;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.TableLayoutPanel actionGrid;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnStartDocument;
        private System.Windows.Forms.Button btnSendJson;
        private System.Windows.Forms.Button btnSampleSend;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Button btnClearDocument;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnXReport;
        private System.Windows.Forms.Button btnZReport;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox grpJson;
        private System.Windows.Forms.TextBox txtSaleBody;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSaleItem;
        private System.Windows.Forms.TableLayoutPanel itemLayout;
        private System.Windows.Forms.Label lblSaleType;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.ComboBox cmbSaleType;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudVatRate;
        private System.Windows.Forms.NumericUpDown nudDiscountRate;
        private System.Windows.Forms.NumericUpDown nudDepartmentId;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TableLayoutPanel paymentLayout;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.NumericUpDown nudPaymentAmount;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.NumericUpDown nudExchangeRate;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnClearPayments;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.connLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblBaseUrl = new System.Windows.Forms.Label();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.lblSoftwareId = new System.Windows.Forms.Label();
            this.txtSoftwareId = new System.Windows.Forms.TextBox();
            this.lblHardwareId = new System.Windows.Forms.Label();
            this.txtHardwareId = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblDocumentId = new System.Windows.Forms.Label();
            this.txtDocumentId = new System.Windows.Forms.TextBox();
            this.lblStartBody = new System.Windows.Forms.Label();
            this.txtStartBody = new System.Windows.Forms.TextBox();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.actionGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnStartDocument = new System.Windows.Forms.Button();
            this.btnSendJson = new System.Windows.Forms.Button();
            this.btnSampleSend = new System.Windows.Forms.Button();
            this.btnSample = new System.Windows.Forms.Button();
            this.btnClearDocument = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnXReport = new System.Windows.Forms.Button();
            this.btnZReport = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.grpJson = new System.Windows.Forms.GroupBox();
            this.txtSaleBody = new System.Windows.Forms.TextBox();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSaleItem = new System.Windows.Forms.TabPage();
            this.itemLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSaleType = new System.Windows.Forms.Label();
            this.cmbSaleType = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.nudVatRate = new System.Windows.Forms.NumericUpDown();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.nudDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.paymentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.nudPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.nudExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnClearPayments = new System.Windows.Forms.Button();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.nudDepartmentId = new System.Windows.Forms.NumericUpDown();
            this.root.SuspendLayout();
            this.grpConnection.SuspendLayout();
            this.connLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.actionGrid.SuspendLayout();
            this.grpJson.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabSaleItem.SuspendLayout();
            this.itemLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).BeginInit();
            this.tabPayment.SuspendLayout();
            this.paymentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).BeginInit();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepartmentId)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.grpConnection, 0, 0);
            this.root.Controls.Add(this.mainSplit, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(10, 10);
            this.root.Name = "root";
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 720);
            this.root.TabIndex = 0;
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.connLayout);
            this.grpConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConnection.Location = new System.Drawing.Point(3, 3);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Padding = new System.Windows.Forms.Padding(10);
            this.grpConnection.Size = new System.Drawing.Size(1174, 148);
            this.grpConnection.TabIndex = 0;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Baglanti ve belge";
            // 
            // connLayout
            // 
            this.connLayout.ColumnCount = 6;
            this.connLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.connLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.connLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.connLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.connLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.connLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.connLayout.Controls.Add(this.lblBaseUrl, 0, 0);
            this.connLayout.Controls.Add(this.txtBaseUrl, 1, 0);
            this.connLayout.Controls.Add(this.lblSoftwareId, 2, 0);
            this.connLayout.Controls.Add(this.txtSoftwareId, 3, 0);
            this.connLayout.Controls.Add(this.lblHardwareId, 4, 0);
            this.connLayout.Controls.Add(this.txtHardwareId, 5, 0);
            this.connLayout.Controls.Add(this.lblSerialNo, 0, 1);
            this.connLayout.Controls.Add(this.txtSerialNo, 1, 1);
            this.connLayout.Controls.Add(this.lblDocumentId, 2, 1);
            this.connLayout.Controls.Add(this.txtDocumentId, 3, 1);
            this.connLayout.Controls.Add(this.lblStartBody, 0, 2);
            this.connLayout.Controls.Add(this.txtStartBody, 1, 2);
            this.connLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connLayout.Location = new System.Drawing.Point(10, 23);
            this.connLayout.Name = "connLayout";
            this.connLayout.RowCount = 3;
            this.connLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.connLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.connLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connLayout.Size = new System.Drawing.Size(1154, 115);
            this.connLayout.TabIndex = 0;
            // 
            // lblBaseUrl
            // 
            this.lblBaseUrl.AutoSize = true;
            this.lblBaseUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaseUrl.Location = new System.Drawing.Point(3, 0);
            this.lblBaseUrl.Name = "lblBaseUrl";
            this.lblBaseUrl.Size = new System.Drawing.Size(76, 34);
            this.lblBaseUrl.TabIndex = 0;
            this.lblBaseUrl.Text = "Base URL";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaseUrl.Location = new System.Drawing.Point(85, 3);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(291, 20);
            this.txtBaseUrl.TabIndex = 1;
            // 
            // lblSoftwareId
            // 
            this.lblSoftwareId.AutoSize = true;
            this.lblSoftwareId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoftwareId.Location = new System.Drawing.Point(382, 0);
            this.lblSoftwareId.Name = "lblSoftwareId";
            this.lblSoftwareId.Size = new System.Drawing.Size(76, 34);
            this.lblSoftwareId.TabIndex = 2;
            this.lblSoftwareId.Text = "SoftwareId";
            // 
            // txtSoftwareId
            // 
            this.txtSoftwareId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoftwareId.Location = new System.Drawing.Point(464, 3);
            this.txtSoftwareId.Name = "txtSoftwareId";
            this.txtSoftwareId.Size = new System.Drawing.Size(291, 20);
            this.txtSoftwareId.TabIndex = 3;
            // 
            // lblHardwareId
            // 
            this.lblHardwareId.AutoSize = true;
            this.lblHardwareId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHardwareId.Location = new System.Drawing.Point(761, 0);
            this.lblHardwareId.Name = "lblHardwareId";
            this.lblHardwareId.Size = new System.Drawing.Size(82, 34);
            this.lblHardwareId.TabIndex = 4;
            this.lblHardwareId.Text = "HardwareId";
            // 
            // txtHardwareId
            // 
            this.txtHardwareId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHardwareId.Location = new System.Drawing.Point(849, 3);
            this.txtHardwareId.Name = "txtHardwareId";
            this.txtHardwareId.Size = new System.Drawing.Size(302, 20);
            this.txtHardwareId.TabIndex = 5;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSerialNo.Location = new System.Drawing.Point(3, 34);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(76, 34);
            this.lblSerialNo.TabIndex = 6;
            this.lblSerialNo.Text = "SerialNo";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSerialNo.Location = new System.Drawing.Point(85, 37);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(291, 20);
            this.txtSerialNo.TabIndex = 7;
            // 
            // lblDocumentId
            // 
            this.lblDocumentId.AutoSize = true;
            this.lblDocumentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocumentId.Location = new System.Drawing.Point(382, 34);
            this.lblDocumentId.Name = "lblDocumentId";
            this.lblDocumentId.Size = new System.Drawing.Size(76, 34);
            this.lblDocumentId.TabIndex = 8;
            this.lblDocumentId.Text = "DocumentId";
            // 
            // txtDocumentId
            // 
            this.txtDocumentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDocumentId.Location = new System.Drawing.Point(464, 37);
            this.txtDocumentId.Name = "txtDocumentId";
            this.txtDocumentId.Size = new System.Drawing.Size(291, 20);
            this.txtDocumentId.TabIndex = 9;
            // 
            // lblStartBody
            // 
            this.lblStartBody.AutoSize = true;
            this.lblStartBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartBody.Location = new System.Drawing.Point(3, 68);
            this.lblStartBody.Name = "lblStartBody";
            this.lblStartBody.Size = new System.Drawing.Size(76, 47);
            this.lblStartBody.TabIndex = 10;
            this.lblStartBody.Text = "Baslatma JSON";
            // 
            // txtStartBody
            // 
            this.connLayout.SetColumnSpan(this.txtStartBody, 5);
            this.txtStartBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStartBody.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtStartBody.Location = new System.Drawing.Point(85, 71);
            this.txtStartBody.Multiline = true;
            this.txtStartBody.Name = "txtStartBody";
            this.txtStartBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStartBody.Size = new System.Drawing.Size(1066, 41);
            this.txtStartBody.TabIndex = 11;
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(3, 157);
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.leftPanel);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.rightPanel);
            this.mainSplit.Size = new System.Drawing.Size(1174, 560);
            this.mainSplit.SplitterDistance = 694;
            this.mainSplit.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.grpActions, 0, 0);
            this.leftPanel.Controls.Add(this.grpJson, 0, 1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 2;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Size = new System.Drawing.Size(694, 560);
            this.leftPanel.TabIndex = 0;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.actionGrid);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActions.Location = new System.Drawing.Point(3, 3);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(10);
            this.grpActions.Size = new System.Drawing.Size(688, 212);
            this.grpActions.TabIndex = 0;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Islemler";
            // 
            // actionGrid
            // 
            this.actionGrid.ColumnCount = 4;
            this.actionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionGrid.Controls.Add(this.btnStatus, 0, 0);
            this.actionGrid.Controls.Add(this.btnStartDocument, 1, 0);
            this.actionGrid.Controls.Add(this.btnSendJson, 2, 0);
            this.actionGrid.Controls.Add(this.btnSampleSend, 3, 0);
            this.actionGrid.Controls.Add(this.btnSample, 0, 1);
            this.actionGrid.Controls.Add(this.btnClearDocument, 1, 1);
            this.actionGrid.Controls.Add(this.btnCancelSale, 2, 1);
            this.actionGrid.Controls.Add(this.btnSettings, 3, 1);
            this.actionGrid.Controls.Add(this.btnXReport, 0, 2);
            this.actionGrid.Controls.Add(this.btnZReport, 1, 2);
            this.actionGrid.Controls.Add(this.btnClearLog, 2, 2);
            this.actionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionGrid.Location = new System.Drawing.Point(10, 23);
            this.actionGrid.Name = "actionGrid";
            this.actionGrid.RowCount = 3;
            this.actionGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.actionGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.actionGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.actionGrid.Size = new System.Drawing.Size(668, 179);
            this.actionGrid.TabIndex = 0;
            // 
            // btnStatus
            // 
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus.Location = new System.Drawing.Point(3, 3);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(161, 53);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "Durum Test";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnStartDocument
            // 
            this.btnStartDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartDocument.Location = new System.Drawing.Point(170, 3);
            this.btnStartDocument.Name = "btnStartDocument";
            this.btnStartDocument.Size = new System.Drawing.Size(161, 53);
            this.btnStartDocument.TabIndex = 1;
            this.btnStartDocument.Text = "Belge Baslat";
            this.btnStartDocument.Click += new System.EventHandler(this.btnStartDocument_Click);
            // 
            // btnSendJson
            // 
            this.btnSendJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendJson.Location = new System.Drawing.Point(337, 3);
            this.btnSendJson.Name = "btnSendJson";
            this.btnSendJson.Size = new System.Drawing.Size(161, 53);
            this.btnSendJson.TabIndex = 2;
            this.btnSendJson.Text = "JSON Gonder";
            this.btnSendJson.Click += new System.EventHandler(this.btnSendJson_Click);
            // 
            // btnSampleSend
            // 
            this.btnSampleSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSampleSend.Location = new System.Drawing.Point(504, 3);
            this.btnSampleSend.Name = "btnSampleSend";
            this.btnSampleSend.Size = new System.Drawing.Size(161, 53);
            this.btnSampleSend.TabIndex = 3;
            this.btnSampleSend.Text = "Ornek Fis Gonder";
            this.btnSampleSend.Click += new System.EventHandler(this.btnSampleSend_Click);
            // 
            // btnSample
            // 
            this.btnSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSample.Location = new System.Drawing.Point(3, 62);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(161, 53);
            this.btnSample.TabIndex = 4;
            this.btnSample.Text = "Ornek Fis Yukle";
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // btnClearDocument
            // 
            this.btnClearDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearDocument.Location = new System.Drawing.Point(170, 62);
            this.btnClearDocument.Name = "btnClearDocument";
            this.btnClearDocument.Size = new System.Drawing.Size(161, 53);
            this.btnClearDocument.TabIndex = 5;
            this.btnClearDocument.Text = "ID Temizle";
            this.btnClearDocument.Click += new System.EventHandler(this.btnClearDocument_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelSale.Location = new System.Drawing.Point(337, 62);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(161, 53);
            this.btnCancelSale.TabIndex = 6;
            this.btnCancelSale.Text = "Satis Iptal";
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(504, 62);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(161, 53);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnXReport
            // 
            this.btnXReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXReport.Location = new System.Drawing.Point(3, 121);
            this.btnXReport.Name = "btnXReport";
            this.btnXReport.Size = new System.Drawing.Size(161, 55);
            this.btnXReport.TabIndex = 8;
            this.btnXReport.Text = "X Yazdir";
            this.btnXReport.Click += new System.EventHandler(this.btnXReport_Click);
            // 
            // btnZReport
            // 
            this.btnZReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZReport.Location = new System.Drawing.Point(170, 121);
            this.btnZReport.Name = "btnZReport";
            this.btnZReport.Size = new System.Drawing.Size(161, 55);
            this.btnZReport.TabIndex = 9;
            this.btnZReport.Text = "Z Yazdir";
            this.btnZReport.Click += new System.EventHandler(this.btnZReport_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearLog.Location = new System.Drawing.Point(337, 121);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(161, 55);
            this.btnClearLog.TabIndex = 10;
            this.btnClearLog.Text = "Log Temizle";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // grpJson
            // 
            this.grpJson.Controls.Add(this.txtSaleBody);
            this.grpJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpJson.Location = new System.Drawing.Point(3, 221);
            this.grpJson.Name = "grpJson";
            this.grpJson.Padding = new System.Windows.Forms.Padding(10);
            this.grpJson.Size = new System.Drawing.Size(688, 336);
            this.grpJson.TabIndex = 1;
            this.grpJson.TabStop = false;
            this.grpJson.Text = "Gonderilecek satis JSON";
            // 
            // txtSaleBody
            // 
            this.txtSaleBody.AcceptsReturn = true;
            this.txtSaleBody.AcceptsTab = true;
            this.txtSaleBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaleBody.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtSaleBody.Location = new System.Drawing.Point(10, 23);
            this.txtSaleBody.Multiline = true;
            this.txtSaleBody.Name = "txtSaleBody";
            this.txtSaleBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaleBody.Size = new System.Drawing.Size(668, 303);
            this.txtSaleBody.TabIndex = 0;
            this.txtSaleBody.WordWrap = false;
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.tabs, 0, 0);
            this.rightPanel.Controls.Add(this.grpLog, 0, 1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 2;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Size = new System.Drawing.Size(476, 560);
            this.rightPanel.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSaleItem);
            this.tabs.Controls.Add(this.tabPayment);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(3, 3);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(470, 310);
            this.tabs.TabIndex = 0;
            // 
            // tabSaleItem
            // 
            this.tabSaleItem.Controls.Add(this.itemLayout);
            this.tabSaleItem.Location = new System.Drawing.Point(4, 22);
            this.tabSaleItem.Name = "tabSaleItem";
            this.tabSaleItem.Padding = new System.Windows.Forms.Padding(10);
            this.tabSaleItem.Size = new System.Drawing.Size(462, 284);
            this.tabSaleItem.TabIndex = 0;
            this.tabSaleItem.Text = "Satis Kalemi";
            this.tabSaleItem.UseVisualStyleBackColor = true;
            // 
            // itemLayout
            // 
            this.itemLayout.ColumnCount = 2;
            this.itemLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.itemLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemLayout.Controls.Add(this.lblSaleType, 0, 0);
            this.itemLayout.Controls.Add(this.cmbSaleType, 1, 0);
            this.itemLayout.Controls.Add(this.lblItemName, 0, 1);
            this.itemLayout.Controls.Add(this.txtItemName, 1, 1);
            this.itemLayout.Controls.Add(this.lblUnitPrice, 0, 2);
            this.itemLayout.Controls.Add(this.nudUnitPrice, 1, 2);
            this.itemLayout.Controls.Add(this.lblQuantity, 0, 3);
            this.itemLayout.Controls.Add(this.nudQuantity, 1, 3);
            this.itemLayout.Controls.Add(this.lblVatRate, 0, 4);
            this.itemLayout.Controls.Add(this.nudVatRate, 1, 4);
            this.itemLayout.Controls.Add(this.lblDiscount, 0, 5);
            this.itemLayout.Controls.Add(this.nudDiscountRate, 1, 5);
            this.itemLayout.Controls.Add(this.lblDepartment, 0, 6);
            this.itemLayout.Controls.Add(this.cmbDepartment, 1, 6);
            this.itemLayout.Controls.Add(this.lblUnit, 0, 7);
            this.itemLayout.Controls.Add(this.cmbUnit, 1, 7);
            this.itemLayout.Controls.Add(this.btnAddItem, 0, 8);
            this.itemLayout.Controls.Add(this.btnClearItems, 1, 8);
            this.itemLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLayout.Location = new System.Drawing.Point(10, 10);
            this.itemLayout.Name = "itemLayout";
            this.itemLayout.RowCount = 9;
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.itemLayout.Size = new System.Drawing.Size(442, 264);
            this.itemLayout.TabIndex = 0;
            // 
            // lblSaleType
            // 
            this.lblSaleType.Location = new System.Drawing.Point(3, 0);
            this.lblSaleType.Name = "lblSaleType";
            this.lblSaleType.Size = new System.Drawing.Size(100, 23);
            this.lblSaleType.TabIndex = 0;
            this.lblSaleType.Text = "Satis Tipi";
            // 
            // cmbSaleType
            // 
            this.cmbSaleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaleType.Items.AddRange(new object[] {
            "RECEIPT",
            "E_INVOICE",
            "E_ARCHIVE",
            "INFO_RECEIPT"});
            this.cmbSaleType.Location = new System.Drawing.Point(113, 3);
            this.cmbSaleType.Name = "cmbSaleType";
            this.cmbSaleType.Size = new System.Drawing.Size(326, 21);
            this.cmbSaleType.TabIndex = 1;
            this.cmbSaleType.SelectedIndexChanged += new System.EventHandler(this.saleOption_Changed);
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(3, 79);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 20);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Kalem Adi";
            // 
            // txtItemName
            // 
            this.txtItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemName.Location = new System.Drawing.Point(113, 82);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(326, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Location = new System.Drawing.Point(3, 104);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Birim Fiyat";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudUnitPrice.Location = new System.Drawing.Point(113, 107);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(326, 20);
            this.nudUnitPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(3, 130);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Carpan";
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 3;
            this.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudQuantity.Location = new System.Drawing.Point(113, 133);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(326, 20);
            this.nudQuantity.TabIndex = 7;
            // 
            // lblVatRate
            // 
            this.lblVatRate.Location = new System.Drawing.Point(3, 155);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(100, 20);
            this.lblVatRate.TabIndex = 8;
            this.lblVatRate.Text = "KDV";
            // 
            // nudVatRate
            // 
            this.nudVatRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudVatRate.Location = new System.Drawing.Point(113, 158);
            this.nudVatRate.Name = "nudVatRate";
            this.nudVatRate.Size = new System.Drawing.Size(326, 20);
            this.nudVatRate.TabIndex = 9;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(3, 176);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 19);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Indirim %";
            // 
            // nudDiscountRate
            // 
            this.nudDiscountRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDiscountRate.Location = new System.Drawing.Point(113, 179);
            this.nudDiscountRate.Name = "nudDiscountRate";
            this.nudDiscountRate.Size = new System.Drawing.Size(326, 20);
            this.nudDiscountRate.TabIndex = 11;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(3, 195);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(100, 20);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.Text = "Kisim";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Location = new System.Drawing.Point(113, 198);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(326, 21);
            this.cmbDepartment.TabIndex = 13;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(3, 217);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(100, 20);
            this.lblUnit.TabIndex = 14;
            this.lblUnit.Text = "Birim";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Items.AddRange(new object[] {
            "AD",
            "KG",
            "LT",
            "MT"});
            this.cmbUnit.Location = new System.Drawing.Point(113, 220);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(326, 21);
            this.cmbUnit.TabIndex = 15;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddItem.Location = new System.Drawing.Point(3, 240);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(104, 21);
            this.btnAddItem.TabIndex = 16;
            this.btnAddItem.Text = "Kalem Ekle";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearItems.Location = new System.Drawing.Point(113, 240);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(326, 21);
            this.btnClearItems.TabIndex = 17;
            this.btnClearItems.Text = "Kalem/Odeme Temizle";
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.paymentLayout);
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(10);
            this.tabPayment.Size = new System.Drawing.Size(462, 284);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "Odeme";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // paymentLayout
            // 
            this.paymentLayout.ColumnCount = 2;
            this.paymentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.paymentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paymentLayout.Controls.Add(this.lblPaymentType, 0, 0);
            this.paymentLayout.Controls.Add(this.cmbPaymentType, 1, 0);
            this.paymentLayout.Controls.Add(this.lblPaymentAmount, 0, 1);
            this.paymentLayout.Controls.Add(this.nudPaymentAmount, 1, 1);
            this.paymentLayout.Controls.Add(this.lblCurrency, 0, 2);
            this.paymentLayout.Controls.Add(this.cmbCurrency, 1, 2);
            this.paymentLayout.Controls.Add(this.lblExchangeRate, 0, 3);
            this.paymentLayout.Controls.Add(this.nudExchangeRate, 1, 3);
            this.paymentLayout.Controls.Add(this.btnAddPayment, 0, 4);
            this.paymentLayout.Controls.Add(this.btnClearPayments, 1, 4);
            this.paymentLayout.Controls.Add(this.lstPayments, 0, 5);
            this.paymentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentLayout.Location = new System.Drawing.Point(10, 10);
            this.paymentLayout.Name = "paymentLayout";
            this.paymentLayout.RowCount = 6;
            this.paymentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.paymentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.paymentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.paymentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.paymentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.paymentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paymentLayout.Size = new System.Drawing.Size(442, 264);
            this.paymentLayout.TabIndex = 0;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(3, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentType.TabIndex = 0;
            this.lblPaymentType.Text = "Odeme Tipi";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "CASH",
            "CREDIT_CARD",
            "EFT_POS",
            "VOUCHER",
            "VOUCHER_POS",
            "MEAL_CARD",
            "OTHER"});
            this.cmbPaymentType.Location = new System.Drawing.Point(113, 3);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(326, 21);
            this.cmbPaymentType.TabIndex = 1;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.Location = new System.Drawing.Point(3, 34);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentAmount.TabIndex = 2;
            this.lblPaymentAmount.Text = "Tutar";
            // 
            // nudPaymentAmount
            // 
            this.nudPaymentAmount.DecimalPlaces = 2;
            this.nudPaymentAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPaymentAmount.Location = new System.Drawing.Point(113, 37);
            this.nudPaymentAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPaymentAmount.Name = "nudPaymentAmount";
            this.nudPaymentAmount.Size = new System.Drawing.Size(326, 20);
            this.nudPaymentAmount.TabIndex = 3;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Location = new System.Drawing.Point(3, 68);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(100, 23);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "Doviz";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP"});
            this.cmbCurrency.Location = new System.Drawing.Point(113, 71);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(326, 21);
            this.cmbCurrency.TabIndex = 5;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.saleOption_Changed);
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.Location = new System.Drawing.Point(3, 102);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(100, 23);
            this.lblExchangeRate.TabIndex = 6;
            this.lblExchangeRate.Text = "Kur";
            // 
            // nudExchangeRate
            // 
            this.nudExchangeRate.DecimalPlaces = 4;
            this.nudExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudExchangeRate.Location = new System.Drawing.Point(113, 105);
            this.nudExchangeRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudExchangeRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudExchangeRate.Name = "nudExchangeRate";
            this.nudExchangeRate.Size = new System.Drawing.Size(326, 20);
            this.nudExchangeRate.TabIndex = 7;
            this.nudExchangeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExchangeRate.ValueChanged += new System.EventHandler(this.saleOption_Changed);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPayment.Location = new System.Drawing.Point(3, 139);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(104, 36);
            this.btnAddPayment.TabIndex = 8;
            this.btnAddPayment.Text = "Odeme Ekle";
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnClearPayments
            // 
            this.btnClearPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearPayments.Location = new System.Drawing.Point(113, 139);
            this.btnClearPayments.Name = "btnClearPayments";
            this.btnClearPayments.Size = new System.Drawing.Size(326, 36);
            this.btnClearPayments.TabIndex = 9;
            this.btnClearPayments.Text = "Odemeleri Temizle";
            this.btnClearPayments.Click += new System.EventHandler(this.btnClearPayments_Click);
            // 
            // lstPayments
            // 
            this.paymentLayout.SetColumnSpan(this.lstPayments, 2);
            this.lstPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPayments.Location = new System.Drawing.Point(3, 181);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(436, 80);
            this.lstPayments.TabIndex = 10;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Location = new System.Drawing.Point(3, 319);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(10);
            this.grpLog.Size = new System.Drawing.Size(470, 238);
            this.grpLog.TabIndex = 1;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Cevap ve log";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.Location = new System.Drawing.Point(10, 23);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(450, 205);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // nudDepartmentId
            // 
            this.nudDepartmentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDepartmentId.Location = new System.Drawing.Point(0, 0);
            this.nudDepartmentId.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudDepartmentId.Name = "nudDepartmentId";
            this.nudDepartmentId.Size = new System.Drawing.Size(120, 20);
            this.nudDepartmentId.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.root);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugin PC Link Test";
            this.root.ResumeLayout(false);
            this.grpConnection.ResumeLayout(false);
            this.connLayout.ResumeLayout(false);
            this.connLayout.PerformLayout();
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.actionGrid.ResumeLayout(false);
            this.grpJson.ResumeLayout(false);
            this.grpJson.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabSaleItem.ResumeLayout(false);
            this.itemLayout.ResumeLayout(false);
            this.itemLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).EndInit();
            this.tabPayment.ResumeLayout(false);
            this.paymentLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).EndInit();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepartmentId)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
