namespace myPOSDemoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbComPorts = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnReversal = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnReprint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReceiptMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtPrintData = new System.Windows.Forms.TextBox();
            this.btnPrintExternal = new System.Windows.Forms.Button();
            this.btnPreauth = new System.Windows.Forms.Button();
            this.txtPreauthCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreauthComplete = new System.Windows.Forms.Button();
            this.btnPreauthCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.btnMotoPurchase = new System.Windows.Forms.Button();
            this.btnMotoRefund = new System.Windows.Forms.Button();
            this.btnMotoPreauth = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnGiftActivation = new System.Windows.Forms.Button();
            this.btnGiftDeactivation = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.cmbReferenceType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.btnBigPurchase = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnPaymentRequest = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnCheckCard = new System.Windows.Forms.Button();
            this.btnOriginalCredit = new System.Windows.Forms.Button();
            this.btnSendLog = new System.Windows.Forms.Button();
            this.btnVendingPurchase = new System.Windows.Forms.Button();
            this.btnVendingStop = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.chkWriteLog = new System.Windows.Forms.CheckBox();
            this.btnBeep = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbBeepTone = new System.Windows.Forms.ComboBox();
            this.txtBeepDuration = new System.Windows.Forms.TextBox();
            this.btnVendingComplete = new System.Windows.Forms.Button();
            this.btnVendingCancel = new System.Windows.Forms.Button();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.fixedPinpadCb = new System.Windows.Forms.CheckBox();
            this.btnCheckForCRR = new System.Windows.Forms.Button();
            this.btnStopWaitingCard = new System.Windows.Forms.Button();
            this.btnCashAdvance = new System.Windows.Forms.Button();
            this.btnPrintExternalUTF8 = new System.Windows.Forms.Button();
            this.chkVendingShowAmount = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RefreshMicro = new System.Windows.Forms.Button();
            this.txtMessageCount = new System.Windows.Forms.TextBox();
            this.MessageCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbComPorts
            // 
            this.cmbComPorts.FormattingEnabled = true;
            this.cmbComPorts.Location = new System.Drawing.Point(99, 12);
            this.cmbComPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cmbComPorts.Name = "cmbComPorts";
            this.cmbComPorts.Size = new System.Drawing.Size(233, 24);
            this.cmbComPorts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(341, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(449, 10);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(32, 363);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(100, 28);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(16, 522);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1837, 573);
            this.txtLog.TabIndex = 4;
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(32, 486);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(100, 28);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(32, 69);
            this.btnGetStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(100, 28);
            this.btnGetStatus.TabIndex = 8;
            this.btnGetStatus.Text = "Get Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 69);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "COM port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Currency";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(152, 164);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 22);
            this.txtAmount.TabIndex = 13;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(152, 228);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(217, 24);
            this.cmbCurrency.TabIndex = 14;
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(152, 363);
            this.btnRefund.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(100, 28);
            this.btnRefund.TabIndex = 15;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnReversal
            // 
            this.btnReversal.Location = new System.Drawing.Point(271, 363);
            this.btnReversal.Margin = new System.Windows.Forms.Padding(4);
            this.btnReversal.Name = "btnReversal";
            this.btnReversal.Size = new System.Drawing.Size(100, 28);
            this.btnReversal.TabIndex = 16;
            this.btnReversal.Text = "Reversal";
            this.btnReversal.UseVisualStyleBackColor = true;
            this.btnReversal.Click += new System.EventHandler(this.btnReversal_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(271, 69);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(100, 28);
            this.btnActivate.TabIndex = 17;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(392, 69);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(100, 28);
            this.btnDeactivate.TabIndex = 17;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.Location = new System.Drawing.Point(303, 486);
            this.btnReprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(156, 28);
            this.btnReprint.TabIndex = 18;
            this.btnReprint.Text = "Reprint receipt";
            this.btnReprint.UseVisualStyleBackColor = true;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Receipt mode";
            // 
            // cmbReceiptMode
            // 
            this.cmbReceiptMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiptMode.FormattingEnabled = true;
            this.cmbReceiptMode.Location = new System.Drawing.Point(152, 130);
            this.cmbReceiptMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReceiptMode.Name = "cmbReceiptMode";
            this.cmbReceiptMode.Size = new System.Drawing.Size(217, 24);
            this.cmbReceiptMode.TabIndex = 14;
            this.cmbReceiptMode.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reference";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(152, 265);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(217, 22);
            this.txtReference.TabIndex = 22;
            // 
            // txtPrintData
            // 
            this.txtPrintData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrintData.Location = new System.Drawing.Point(1523, 16);
            this.txtPrintData.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrintData.Multiline = true;
            this.txtPrintData.Name = "txtPrintData";
            this.txtPrintData.Size = new System.Drawing.Size(331, 312);
            this.txtPrintData.TabIndex = 23;
            this.txtPrintData.Text = resources.GetString("txtPrintData.Text");
            // 
            // btnPrintExternal
            // 
            this.btnPrintExternal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExternal.Location = new System.Drawing.Point(1523, 336);
            this.btnPrintExternal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintExternal.Name = "btnPrintExternal";
            this.btnPrintExternal.Size = new System.Drawing.Size(171, 28);
            this.btnPrintExternal.TabIndex = 24;
            this.btnPrintExternal.Text = "Print external ASCII";
            this.btnPrintExternal.UseVisualStyleBackColor = true;
            this.btnPrintExternal.Click += new System.EventHandler(this.btnPrintExternal_Click);
            // 
            // btnPreauth
            // 
            this.btnPreauth.Location = new System.Drawing.Point(32, 400);
            this.btnPreauth.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreauth.Name = "btnPreauth";
            this.btnPreauth.Size = new System.Drawing.Size(100, 28);
            this.btnPreauth.TabIndex = 25;
            this.btnPreauth.Text = "Preauth";
            this.btnPreauth.UseVisualStyleBackColor = true;
            this.btnPreauth.Click += new System.EventHandler(this.btnPreauth_Click);
            // 
            // txtPreauthCode
            // 
            this.txtPreauthCode.Location = new System.Drawing.Point(152, 297);
            this.txtPreauthCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreauthCode.Name = "txtPreauthCode";
            this.txtPreauthCode.Size = new System.Drawing.Size(217, 22);
            this.txtPreauthCode.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Preauth Code";
            // 
            // btnPreauthComplete
            // 
            this.btnPreauthComplete.Location = new System.Drawing.Point(152, 400);
            this.btnPreauthComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreauthComplete.Name = "btnPreauthComplete";
            this.btnPreauthComplete.Size = new System.Drawing.Size(195, 28);
            this.btnPreauthComplete.TabIndex = 26;
            this.btnPreauthComplete.Text = "Preauth completion";
            this.btnPreauthComplete.UseVisualStyleBackColor = true;
            this.btnPreauthComplete.Click += new System.EventHandler(this.btnPreauthComplete_Click);
            // 
            // btnPreauthCancel
            // 
            this.btnPreauthCancel.Location = new System.Drawing.Point(355, 400);
            this.btnPreauthCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreauthCancel.Name = "btnPreauthCancel";
            this.btnPreauthCancel.Size = new System.Drawing.Size(195, 28);
            this.btnPreauthCancel.TabIndex = 27;
            this.btnPreauthCancel.Text = "Preauth cancelation";
            this.btnPreauthCancel.UseVisualStyleBackColor = true;
            this.btnPreauthCancel.Click += new System.EventHandler(this.btnPreauthCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "PAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "ExpiryDate (MMYY)";
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(577, 130);
            this.txtPan.Margin = new System.Windows.Forms.Padding(4);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(217, 22);
            this.txtPan.TabIndex = 22;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(577, 162);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(217, 22);
            this.txtExpiryDate.TabIndex = 22;
            // 
            // btnMotoPurchase
            // 
            this.btnMotoPurchase.Location = new System.Drawing.Point(672, 363);
            this.btnMotoPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotoPurchase.Name = "btnMotoPurchase";
            this.btnMotoPurchase.Size = new System.Drawing.Size(199, 28);
            this.btnMotoPurchase.TabIndex = 28;
            this.btnMotoPurchase.Text = "Moto Purchase";
            this.btnMotoPurchase.UseVisualStyleBackColor = true;
            this.btnMotoPurchase.Click += new System.EventHandler(this.btnMotoPurchase_Click);
            // 
            // btnMotoRefund
            // 
            this.btnMotoRefund.Location = new System.Drawing.Point(672, 400);
            this.btnMotoRefund.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotoRefund.Name = "btnMotoRefund";
            this.btnMotoRefund.Size = new System.Drawing.Size(199, 28);
            this.btnMotoRefund.TabIndex = 28;
            this.btnMotoRefund.Text = "Moto Refund";
            this.btnMotoRefund.UseVisualStyleBackColor = true;
            this.btnMotoRefund.Click += new System.EventHandler(this.btnMotoRefund_Click);
            // 
            // btnMotoPreauth
            // 
            this.btnMotoPreauth.Location = new System.Drawing.Point(672, 436);
            this.btnMotoPreauth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotoPreauth.Name = "btnMotoPreauth";
            this.btnMotoPreauth.Size = new System.Drawing.Size(199, 28);
            this.btnMotoPreauth.TabIndex = 28;
            this.btnMotoPreauth.Text = "Moto Preauth";
            this.btnMotoPreauth.UseVisualStyleBackColor = true;
            this.btnMotoPreauth.Click += new System.EventHandler(this.btnMotoPreauth_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(517, 69);
            this.btnPing.Margin = new System.Windows.Forms.Padding(4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(100, 28);
            this.btnPing.TabIndex = 17;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(637, 69);
            this.btnReboot.Margin = new System.Windows.Forms.Padding(4);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(100, 28);
            this.btnReboot.TabIndex = 29;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnGiftActivation
            // 
            this.btnGiftActivation.Location = new System.Drawing.Point(32, 437);
            this.btnGiftActivation.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiftActivation.Name = "btnGiftActivation";
            this.btnGiftActivation.Size = new System.Drawing.Size(163, 28);
            this.btnGiftActivation.TabIndex = 30;
            this.btnGiftActivation.Text = "Giftcard Activation";
            this.btnGiftActivation.UseVisualStyleBackColor = true;
            this.btnGiftActivation.Click += new System.EventHandler(this.btnGiftActivation_Click);
            // 
            // btnGiftDeactivation
            // 
            this.btnGiftDeactivation.Location = new System.Drawing.Point(208, 437);
            this.btnGiftDeactivation.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiftDeactivation.Name = "btnGiftDeactivation";
            this.btnGiftDeactivation.Size = new System.Drawing.Size(163, 28);
            this.btnGiftDeactivation.TabIndex = 30;
            this.btnGiftDeactivation.Text = "Giftcard Deactivation";
            this.btnGiftDeactivation.UseVisualStyleBackColor = true;
            this.btnGiftDeactivation.Click += new System.EventHandler(this.btnGiftDeactivation_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(385, 437);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(163, 28);
            this.btnCheckBalance.TabIndex = 30;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Amount tip";
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(152, 196);
            this.txtTipAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(217, 22);
            this.txtTipAmount.TabIndex = 13;
            // 
            // cmbReferenceType
            // 
            this.cmbReferenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReferenceType.FormattingEnabled = true;
            this.cmbReferenceType.Location = new System.Drawing.Point(577, 194);
            this.cmbReferenceType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReferenceType.Name = "cmbReferenceType";
            this.cmbReferenceType.Size = new System.Drawing.Size(217, 24);
            this.cmbReferenceType.TabIndex = 14;
            this.cmbReferenceType.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reference type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 231);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Reference number";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Location = new System.Drawing.Point(577, 228);
            this.txtReferenceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(217, 22);
            this.txtReferenceNumber.TabIndex = 22;
            // 
            // btnBigPurchase
            // 
            this.btnBigPurchase.Location = new System.Drawing.Point(385, 364);
            this.btnBigPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btnBigPurchase.Name = "btnBigPurchase";
            this.btnBigPurchase.Size = new System.Drawing.Size(163, 28);
            this.btnBigPurchase.TabIndex = 31;
            this.btnBigPurchase.Text = "Purcase + Tip";
            this.btnBigPurchase.UseVisualStyleBackColor = true;
            this.btnBigPurchase.Click += new System.EventHandler(this.btnBigPurchase_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Operator code";
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(577, 258);
            this.txtOperatorCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.Size = new System.Drawing.Size(217, 22);
            this.txtOperatorCode.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 294);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(577, 290);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 22);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(825, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "GSM";
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(927, 130);
            this.txtGSM.Margin = new System.Windows.Forms.Padding(4);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(217, 22);
            this.txtGSM.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(825, 166);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "EMail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(927, 164);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(217, 22);
            this.txtEMail.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(825, 198);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Recipient";
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(927, 196);
            this.txtRecipient.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(217, 22);
            this.txtRecipient.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(825, 262);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Days";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(927, 260);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(217, 22);
            this.txtDays.TabIndex = 22;
            // 
            // btnPaymentRequest
            // 
            this.btnPaymentRequest.Location = new System.Drawing.Point(927, 300);
            this.btnPaymentRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentRequest.Name = "btnPaymentRequest";
            this.btnPaymentRequest.Size = new System.Drawing.Size(219, 28);
            this.btnPaymentRequest.TabIndex = 28;
            this.btnPaymentRequest.Text = "Payment Request";
            this.btnPaymentRequest.UseVisualStyleBackColor = true;
            this.btnPaymentRequest.Click += new System.EventHandler(this.btnPaymentRequest_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(825, 230);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(927, 228);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(217, 22);
            this.txtReason.TabIndex = 22;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(945, 69);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(212, 24);
            this.cmbLanguage.TabIndex = 32;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // btnCheckCard
            // 
            this.btnCheckCard.Location = new System.Drawing.Point(908, 363);
            this.btnCheckCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckCard.Name = "btnCheckCard";
            this.btnCheckCard.Size = new System.Drawing.Size(199, 28);
            this.btnCheckCard.TabIndex = 28;
            this.btnCheckCard.Text = "Check Card";
            this.btnCheckCard.UseVisualStyleBackColor = true;
            this.btnCheckCard.Click += new System.EventHandler(this.btnCheckCard_Click);
            // 
            // btnOriginalCredit
            // 
            this.btnOriginalCredit.Location = new System.Drawing.Point(908, 400);
            this.btnOriginalCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnOriginalCredit.Name = "btnOriginalCredit";
            this.btnOriginalCredit.Size = new System.Drawing.Size(199, 28);
            this.btnOriginalCredit.TabIndex = 28;
            this.btnOriginalCredit.Text = "Original Credit";
            this.btnOriginalCredit.UseVisualStyleBackColor = true;
            this.btnOriginalCredit.Click += new System.EventHandler(this.btnOriginalCredit_Click);
            // 
            // btnSendLog
            // 
            this.btnSendLog.Location = new System.Drawing.Point(709, 10);
            this.btnSendLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendLog.Name = "btnSendLog";
            this.btnSendLog.Size = new System.Drawing.Size(133, 28);
            this.btnSendLog.TabIndex = 33;
            this.btnSendLog.Text = "Send Log";
            this.btnSendLog.UseVisualStyleBackColor = true;
            this.btnSendLog.Click += new System.EventHandler(this.btnSendLog_Click);
            // 
            // btnVendingPurchase
            // 
            this.btnVendingPurchase.Location = new System.Drawing.Point(1139, 364);
            this.btnVendingPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendingPurchase.Name = "btnVendingPurchase";
            this.btnVendingPurchase.Size = new System.Drawing.Size(199, 28);
            this.btnVendingPurchase.TabIndex = 34;
            this.btnVendingPurchase.Text = "Vending Purchase";
            this.btnVendingPurchase.UseVisualStyleBackColor = true;
            this.btnVendingPurchase.Click += new System.EventHandler(this.btnVendingPurchase_Click);
            // 
            // btnVendingStop
            // 
            this.btnVendingStop.Location = new System.Drawing.Point(1139, 400);
            this.btnVendingStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendingStop.Name = "btnVendingStop";
            this.btnVendingStop.Size = new System.Drawing.Size(199, 28);
            this.btnVendingStop.TabIndex = 35;
            this.btnVendingStop.Text = "Vending Stop";
            this.btnVendingStop.UseVisualStyleBackColor = true;
            this.btnVendingStop.Click += new System.EventHandler(this.btnVendingStop_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(1679, 473);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(176, 28);
            this.btnClearLog.TabIndex = 36;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // chkWriteLog
            // 
            this.chkWriteLog.AutoSize = true;
            this.chkWriteLog.Checked = true;
            this.chkWriteLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWriteLog.Location = new System.Drawing.Point(1720, 444);
            this.chkWriteLog.Margin = new System.Windows.Forms.Padding(4);
            this.chkWriteLog.Name = "chkWriteLog";
            this.chkWriteLog.Size = new System.Drawing.Size(124, 20);
            this.chkWriteLog.TabIndex = 37;
            this.chkWriteLog.Text = "Write debug log";
            this.chkWriteLog.UseVisualStyleBackColor = true;
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(1281, 199);
            this.btnBeep.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(151, 28);
            this.btnBeep.TabIndex = 38;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1183, 133);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 39;
            this.label19.Text = "Tone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1183, 166);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 16);
            this.label20.TabIndex = 40;
            this.label20.Text = "Duration (ms)";
            // 
            // cmbBeepTone
            // 
            this.cmbBeepTone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeepTone.FormattingEnabled = true;
            this.cmbBeepTone.Location = new System.Drawing.Point(1281, 129);
            this.cmbBeepTone.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBeepTone.Name = "cmbBeepTone";
            this.cmbBeepTone.Size = new System.Drawing.Size(149, 24);
            this.cmbBeepTone.TabIndex = 41;
            // 
            // txtBeepDuration
            // 
            this.txtBeepDuration.Location = new System.Drawing.Point(1281, 164);
            this.txtBeepDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeepDuration.Name = "txtBeepDuration";
            this.txtBeepDuration.Size = new System.Drawing.Size(149, 22);
            this.txtBeepDuration.TabIndex = 42;
            // 
            // btnVendingComplete
            // 
            this.btnVendingComplete.Location = new System.Drawing.Point(1139, 437);
            this.btnVendingComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendingComplete.Name = "btnVendingComplete";
            this.btnVendingComplete.Size = new System.Drawing.Size(199, 28);
            this.btnVendingComplete.TabIndex = 35;
            this.btnVendingComplete.Text = "Vending Complete";
            this.btnVendingComplete.UseVisualStyleBackColor = true;
            this.btnVendingComplete.Click += new System.EventHandler(this.btnVendingComplete_Click);
            // 
            // btnVendingCancel
            // 
            this.btnVendingCancel.Location = new System.Drawing.Point(1139, 473);
            this.btnVendingCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendingCancel.Name = "btnVendingCancel";
            this.btnVendingCancel.Size = new System.Drawing.Size(199, 28);
            this.btnVendingCancel.TabIndex = 35;
            this.btnVendingCancel.Text = "Vending Cancel";
            this.btnVendingCancel.UseVisualStyleBackColor = true;
            this.btnVendingCancel.Click += new System.EventHandler(this.btnVendingCancel_Click);
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.Location = new System.Drawing.Point(763, 69);
            this.btnOpenSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(132, 28);
            this.btnOpenSettings.TabIndex = 29;
            this.btnOpenSettings.Text = "Open settings";
            this.btnOpenSettings.UseVisualStyleBackColor = true;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // fixedPinpadCb
            // 
            this.fixedPinpadCb.AutoSize = true;
            this.fixedPinpadCb.Checked = true;
            this.fixedPinpadCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fixedPinpadCb.Location = new System.Drawing.Point(1281, 257);
            this.fixedPinpadCb.Margin = new System.Windows.Forms.Padding(4);
            this.fixedPinpadCb.Name = "fixedPinpadCb";
            this.fixedPinpadCb.Size = new System.Drawing.Size(108, 20);
            this.fixedPinpadCb.TabIndex = 43;
            this.fixedPinpadCb.Text = "Fixed Pinpad";
            this.fixedPinpadCb.UseVisualStyleBackColor = true;
            this.fixedPinpadCb.CheckedChanged += new System.EventHandler(this.fixedPinpadCb_CheckedChanged);
            // 
            // btnCheckForCRR
            // 
            this.btnCheckForCRR.Location = new System.Drawing.Point(1523, 373);
            this.btnCheckForCRR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckForCRR.Name = "btnCheckForCRR";
            this.btnCheckForCRR.Size = new System.Drawing.Size(332, 28);
            this.btnCheckForCRR.TabIndex = 44;
            this.btnCheckForCRR.Text = "Check for CRR transaction";
            this.btnCheckForCRR.UseVisualStyleBackColor = true;
            this.btnCheckForCRR.Click += new System.EventHandler(this.btnCheckForCRR_Click);
            // 
            // btnStopWaitingCard
            // 
            this.btnStopWaitingCard.Location = new System.Drawing.Point(140, 486);
            this.btnStopWaitingCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopWaitingCard.Name = "btnStopWaitingCard";
            this.btnStopWaitingCard.Size = new System.Drawing.Size(155, 28);
            this.btnStopWaitingCard.TabIndex = 45;
            this.btnStopWaitingCard.Text = "Stop waiting card";
            this.btnStopWaitingCard.UseVisualStyleBackColor = true;
            this.btnStopWaitingCard.Click += new System.EventHandler(this.btnStopWaitingCard_Click);
            // 
            // btnCashAdvance
            // 
            this.btnCashAdvance.Location = new System.Drawing.Point(908, 436);
            this.btnCashAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCashAdvance.Name = "btnCashAdvance";
            this.btnCashAdvance.Size = new System.Drawing.Size(199, 28);
            this.btnCashAdvance.TabIndex = 46;
            this.btnCashAdvance.Text = "Cash Advance";
            this.btnCashAdvance.UseVisualStyleBackColor = true;
            this.btnCashAdvance.Click += new System.EventHandler(this.btnCashAdvance_Click);
            // 
            // btnPrintExternalUTF8
            // 
            this.btnPrintExternalUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExternalUTF8.Location = new System.Drawing.Point(1701, 336);
            this.btnPrintExternalUTF8.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintExternalUTF8.Name = "btnPrintExternalUTF8";
            this.btnPrintExternalUTF8.Size = new System.Drawing.Size(153, 28);
            this.btnPrintExternalUTF8.TabIndex = 24;
            this.btnPrintExternalUTF8.Text = "Print external UTF8";
            this.btnPrintExternalUTF8.UseVisualStyleBackColor = true;
            this.btnPrintExternalUTF8.Click += new System.EventHandler(this.btnPrintExternalUTF8_Click);
            // 
            // chkVendingShowAmount
            // 
            this.chkVendingShowAmount.AutoSize = true;
            this.chkVendingShowAmount.Location = new System.Drawing.Point(1115, 336);
            this.chkVendingShowAmount.Margin = new System.Windows.Forms.Padding(4);
            this.chkVendingShowAmount.Name = "chkVendingShowAmount";
            this.chkVendingShowAmount.Size = new System.Drawing.Size(237, 20);
            this.chkVendingShowAmount.TabIndex = 47;
            this.chkVendingShowAmount.Text = "Show amount on vending purchase";
            this.chkVendingShowAmount.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(557, 10);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 28);
            this.btnDisconnect.TabIndex = 48;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 1120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 16);
            this.label21.TabIndex = 49;
            this.label21.Text = "Port Microcontroller tilde:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(19, 1140);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(150, 24);
            this.cboPort.TabIndex = 50;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(176, 1112);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 51;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(176, 1140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(341, 1112);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(298, 132);
            this.txtSend.TabIndex = 53;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(646, 1112);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 54;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(1082, 1112);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 56;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(777, 1112);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(298, 132);
            this.txtReceive.TabIndex = 55;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // RefreshMicro
            // 
            this.RefreshMicro.Location = new System.Drawing.Point(20, 1170);
            this.RefreshMicro.Name = "RefreshMicro";
            this.RefreshMicro.Size = new System.Drawing.Size(149, 41);
            this.RefreshMicro.TabIndex = 57;
            this.RefreshMicro.Text = "Refresh Microcontroller Port";
            this.RefreshMicro.UseVisualStyleBackColor = true;
            this.RefreshMicro.Click += new System.EventHandler(this.RefreshMicro_Click);
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.Location = new System.Drawing.Point(646, 1170);
            this.txtMessageCount.Multiline = true;
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(75, 74);
            this.txtMessageCount.TabIndex = 58;
            // 
            // MessageCount
            // 
            this.MessageCount.AutoSize = true;
            this.MessageCount.Location = new System.Drawing.Point(646, 1147);
            this.MessageCount.Name = "MessageCount";
            this.MessageCount.Size = new System.Drawing.Size(104, 16);
            this.MessageCount.TabIndex = 59;
            this.MessageCount.Text = "Message Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 1256);
            this.Controls.Add(this.MessageCount);
            this.Controls.Add(this.txtMessageCount);
            this.Controls.Add(this.RefreshMicro);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.chkVendingShowAmount);
            this.Controls.Add(this.btnCashAdvance);
            this.Controls.Add(this.btnStopWaitingCard);
            this.Controls.Add(this.btnCheckForCRR);
            this.Controls.Add(this.fixedPinpadCb);
            this.Controls.Add(this.txtBeepDuration);
            this.Controls.Add(this.cmbBeepTone);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.chkWriteLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnVendingCancel);
            this.Controls.Add(this.btnVendingComplete);
            this.Controls.Add(this.btnVendingStop);
            this.Controls.Add(this.btnVendingPurchase);
            this.Controls.Add(this.btnSendLog);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.btnBigPurchase);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnGiftDeactivation);
            this.Controls.Add(this.btnGiftActivation);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnMotoPreauth);
            this.Controls.Add(this.btnOriginalCredit);
            this.Controls.Add(this.btnCheckCard);
            this.Controls.Add(this.btnMotoRefund);
            this.Controls.Add(this.btnPaymentRequest);
            this.Controls.Add(this.btnMotoPurchase);
            this.Controls.Add(this.btnPreauthCancel);
            this.Controls.Add(this.btnPreauthComplete);
            this.Controls.Add(this.btnPreauth);
            this.Controls.Add(this.btnPrintExternalUTF8);
            this.Controls.Add(this.btnPrintExternal);
            this.Controls.Add(this.txtPrintData);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtOperatorCode);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPreauthCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnReversal);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.cmbReferenceType);
            this.Controls.Add(this.cmbReceiptMode);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbComPorts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Test Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComPorts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnReversal;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbReceiptMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtPrintData;
        private System.Windows.Forms.Button btnPrintExternal;
        private System.Windows.Forms.Button btnPreauth;
        private System.Windows.Forms.TextBox txtPreauthCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPreauthComplete;
        private System.Windows.Forms.Button btnPreauthCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Button btnMotoPurchase;
        private System.Windows.Forms.Button btnMotoRefund;
        private System.Windows.Forms.Button btnMotoPreauth;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnGiftActivation;
        private System.Windows.Forms.Button btnGiftDeactivation;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.ComboBox cmbReferenceType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Button btnBigPurchase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnPaymentRequest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnCheckCard;
        private System.Windows.Forms.Button btnOriginalCredit;
        private System.Windows.Forms.Button btnSendLog;
        private System.Windows.Forms.Button btnVendingPurchase;
        private System.Windows.Forms.Button btnVendingStop;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.CheckBox chkWriteLog;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbBeepTone;
        private System.Windows.Forms.TextBox txtBeepDuration;
        private System.Windows.Forms.Button btnVendingComplete;
        private System.Windows.Forms.Button btnVendingCancel;
		private System.Windows.Forms.Button btnOpenSettings;
		private System.Windows.Forms.CheckBox fixedPinpadCb;
		private System.Windows.Forms.Button btnCheckForCRR;
		private System.Windows.Forms.Button btnStopWaitingCard;
		private System.Windows.Forms.Button btnCashAdvance;
		private System.Windows.Forms.Button btnPrintExternalUTF8;
		private System.Windows.Forms.CheckBox chkVendingShowAmount;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtReceive;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button RefreshMicro;
        private System.Windows.Forms.TextBox txtMessageCount;
        private System.Windows.Forms.Label MessageCount;
    }
}

