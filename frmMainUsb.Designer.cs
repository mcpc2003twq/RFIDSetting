namespace RFIDsetting_test
{
    partial class frmMainUsb
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.pnlChoiceInterface = new System.Windows.Forms.Panel();
            this.pnlUsb = new System.Windows.Forms.Panel();
            this.txtUsbDevicePath = new System.Windows.Forms.TextBox();
            this.lblUsbDevicePath = new System.Windows.Forms.Label();
            this.cmbUsbDeviceList = new System.Windows.Forms.ComboBox();
            this.lblUsbDeviceChoice = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rtxtRes = new System.Windows.Forms.RichTextBox();
            this.grbRead = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.ftxtAccessPwd = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtDataHex = new System.Windows.Forms.TextBox();
            this.lblDataHex = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbMem = new System.Windows.Forms.ComboBox();
            this.lblMem = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblAccessPassword = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.grbIdentify = new System.Windows.Forms.GroupBox();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnTempSwitchActive = new System.Windows.Forms.Button();
            this.btnTempSwitchCommand = new System.Windows.Forms.Button();
            this.pnlConnect.SuspendLayout();
            this.pnlChoiceInterface.SuspendLayout();
            this.pnlUsb.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.grbRead.SuspendLayout();
            this.grbIdentify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConnect
            // 
            this.pnlConnect.AutoSize = true;
            this.pnlConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnect.Controls.Add(this.pnlChoiceInterface);
            this.pnlConnect.Controls.Add(this.pnlButton);
            this.pnlConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnect.Location = new System.Drawing.Point(0, 0);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(960, 32);
            this.pnlConnect.TabIndex = 0;
            // 
            // pnlChoiceInterface
            // 
            this.pnlChoiceInterface.AutoSize = true;
            this.pnlChoiceInterface.Controls.Add(this.pnlUsb);
            this.pnlChoiceInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceInterface.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceInterface.MinimumSize = new System.Drawing.Size(444, 30);
            this.pnlChoiceInterface.Name = "pnlChoiceInterface";
            this.pnlChoiceInterface.Size = new System.Drawing.Size(738, 30);
            this.pnlChoiceInterface.TabIndex = 5;
            // 
            // pnlUsb
            // 
            this.pnlUsb.Controls.Add(this.txtUsbDevicePath);
            this.pnlUsb.Controls.Add(this.lblUsbDevicePath);
            this.pnlUsb.Controls.Add(this.cmbUsbDeviceList);
            this.pnlUsb.Controls.Add(this.lblUsbDeviceChoice);
            this.pnlUsb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsb.Location = new System.Drawing.Point(0, 0);
            this.pnlUsb.Name = "pnlUsb";
            this.pnlUsb.Size = new System.Drawing.Size(738, 30);
            this.pnlUsb.TabIndex = 4;
            // 
            // txtUsbDevicePath
            // 
            this.txtUsbDevicePath.Location = new System.Drawing.Point(354, 6);
            this.txtUsbDevicePath.MaxLength = 65535;
            this.txtUsbDevicePath.Name = "txtUsbDevicePath";
            this.txtUsbDevicePath.ReadOnly = true;
            this.txtUsbDevicePath.Size = new System.Drawing.Size(80, 21);
            this.txtUsbDevicePath.TabIndex = 13;
            this.txtUsbDevicePath.TabStop = false;
            this.txtUsbDevicePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsbDevicePath
            // 
            this.lblUsbDevicePath.AutoSize = true;
            this.lblUsbDevicePath.Location = new System.Drawing.Point(247, 9);
            this.lblUsbDevicePath.Name = "lblUsbDevicePath";
            this.lblUsbDevicePath.Size = new System.Drawing.Size(71, 12);
            this.lblUsbDevicePath.TabIndex = 14;
            this.lblUsbDevicePath.Text = "Device Path";
            // 
            // cmbUsbDeviceList
            // 
            this.cmbUsbDeviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsbDeviceList.FormattingEnabled = true;
            this.cmbUsbDeviceList.Location = new System.Drawing.Point(130, 5);
            this.cmbUsbDeviceList.Name = "cmbUsbDeviceList";
            this.cmbUsbDeviceList.Size = new System.Drawing.Size(110, 20);
            this.cmbUsbDeviceList.TabIndex = 12;
            this.cmbUsbDeviceList.TabStop = false;
            this.cmbUsbDeviceList.SelectedIndexChanged += new System.EventHandler(this.cmbUsbDeviceList_SelectedIndexChanged);
            // 
            // lblUsbDeviceChoice
            // 
            this.lblUsbDeviceChoice.AutoSize = true;
            this.lblUsbDeviceChoice.Location = new System.Drawing.Point(10, 9);
            this.lblUsbDeviceChoice.Name = "lblUsbDeviceChoice";
            this.lblUsbDeviceChoice.Size = new System.Drawing.Size(83, 12);
            this.lblUsbDeviceChoice.TabIndex = 11;
            this.lblUsbDeviceChoice.Text = "Choice Device";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnDisconnect);
            this.pnlButton.Controls.Add(this.btnConnect);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(738, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(220, 30);
            this.pnlButton.TabIndex = 6;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(117, 1);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 28);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rtxtRes
            // 
            this.rtxtRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtRes.Location = new System.Drawing.Point(0, 506);
            this.rtxtRes.Name = "rtxtRes";
            this.rtxtRes.Size = new System.Drawing.Size(960, 194);
            this.rtxtRes.TabIndex = 16;
            this.rtxtRes.Text = "";
            // 
            // grbRead
            // 
            this.grbRead.AutoSize = true;
            this.grbRead.Controls.Add(this.btnWrite);
            this.grbRead.Controls.Add(this.ftxtAccessPwd);
            this.grbRead.Controls.Add(this.txtLength);
            this.grbRead.Controls.Add(this.txtStart);
            this.grbRead.Controls.Add(this.txtDataHex);
            this.grbRead.Controls.Add(this.lblDataHex);
            this.grbRead.Controls.Add(this.btnRead);
            this.grbRead.Controls.Add(this.cmbMem);
            this.grbRead.Controls.Add(this.lblMem);
            this.grbRead.Controls.Add(this.lblStart);
            this.grbRead.Controls.Add(this.lblAccessPassword);
            this.grbRead.Controls.Add(this.lblLength);
            this.grbRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbRead.Location = new System.Drawing.Point(0, 84);
            this.grbRead.Name = "grbRead";
            this.grbRead.Size = new System.Drawing.Size(960, 129);
            this.grbRead.TabIndex = 20;
            this.grbRead.TabStop = false;
            this.grbRead.Text = "EPC(GEN 2) Read && Write";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(634, 79);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(120, 30);
            this.btnWrite.TabIndex = 21;
            this.btnWrite.TabStop = false;
            this.btnWrite.Text = "&Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // ftxtAccessPwd
            // 
            this.ftxtAccessPwd.Location = new System.Drawing.Point(100, 19);
            this.ftxtAccessPwd.MaxLength = 8;
            this.ftxtAccessPwd.Name = "ftxtAccessPwd";
            this.ftxtAccessPwd.Size = new System.Drawing.Size(86, 21);
            this.ftxtAccessPwd.TabIndex = 20;
            this.ftxtAccessPwd.Text = "00000000";
            this.ftxtAccessPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(541, 49);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(60, 21);
            this.txtLength.TabIndex = 19;
            this.txtLength.Text = "6";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(349, 49);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(60, 21);
            this.txtStart.TabIndex = 18;
            this.txtStart.Text = "0";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataHex
            // 
            this.txtDataHex.Location = new System.Drawing.Point(100, 79);
            this.txtDataHex.MaxLength = 8;
            this.txtDataHex.Name = "txtDataHex";
            this.txtDataHex.Size = new System.Drawing.Size(528, 21);
            this.txtDataHex.TabIndex = 17;
            this.txtDataHex.TabStop = false;
            this.txtDataHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataHex
            // 
            this.lblDataHex.AutoSize = true;
            this.lblDataHex.Location = new System.Drawing.Point(12, 82);
            this.lblDataHex.Name = "lblDataHex";
            this.lblDataHex.Size = new System.Drawing.Size(65, 12);
            this.lblDataHex.TabIndex = 16;
            this.lblDataHex.Text = "Data(Hex):";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(634, 45);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(120, 30);
            this.btnRead.TabIndex = 4;
            this.btnRead.TabStop = false;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbMem
            // 
            this.cmbMem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMem.FormattingEnabled = true;
            this.cmbMem.Items.AddRange(new object[] {
            "0-Reserved",
            "1-EPC",
            "2-TID",
            "3-User"});
            this.cmbMem.Location = new System.Drawing.Point(100, 49);
            this.cmbMem.Name = "cmbMem";
            this.cmbMem.Size = new System.Drawing.Size(86, 20);
            this.cmbMem.TabIndex = 0;
            this.cmbMem.TabStop = false;
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.Location = new System.Drawing.Point(11, 52);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(83, 12);
            this.lblMem.TabIndex = 5;
            this.lblMem.Text = "Target Memory";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(194, 53);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(149, 12);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start Address (Word Ptr)";
            // 
            // lblAccessPassword
            // 
            this.lblAccessPassword.AutoSize = true;
            this.lblAccessPassword.Location = new System.Drawing.Point(12, 22);
            this.lblAccessPassword.Name = "lblAccessPassword";
            this.lblAccessPassword.Size = new System.Drawing.Size(71, 12);
            this.lblAccessPassword.TabIndex = 9;
            this.lblAccessPassword.Text = "Access Pwd:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(416, 52);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(119, 12);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length (Word Count)";
            // 
            // grbIdentify
            // 
            this.grbIdentify.Controls.Add(this.btnCancelSelect);
            this.grbIdentify.Controls.Add(this.btnSelect);
            this.grbIdentify.Controls.Add(this.txtCard);
            this.grbIdentify.Controls.Add(this.lblCard);
            this.grbIdentify.Controls.Add(this.btnIdentify);
            this.grbIdentify.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbIdentify.Location = new System.Drawing.Point(0, 32);
            this.grbIdentify.Name = "grbIdentify";
            this.grbIdentify.Size = new System.Drawing.Size(960, 52);
            this.grbIdentify.TabIndex = 19;
            this.grbIdentify.TabStop = false;
            this.grbIdentify.Text = "EPC(GEN 2) Identify";
            // 
            // btnCancelSelect
            // 
            this.btnCancelSelect.Location = new System.Drawing.Point(846, 13);
            this.btnCancelSelect.Name = "btnCancelSelect";
            this.btnCancelSelect.Size = new System.Drawing.Size(80, 30);
            this.btnCancelSelect.TabIndex = 20;
            this.btnCancelSelect.TabStop = false;
            this.btnCancelSelect.Text = "&Cancel";
            this.btnCancelSelect.UseVisualStyleBackColor = true;
            this.btnCancelSelect.Click += new System.EventHandler(this.btnCancelSelect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(760, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 30);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(100, 18);
            this.txtCard.MaxLength = 8;
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(528, 21);
            this.txtCard.TabIndex = 18;
            this.txtCard.TabStop = false;
            this.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(12, 22);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(83, 12);
            this.lblCard.TabIndex = 2;
            this.lblCard.Text = "Card No(Hex):";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(634, 13);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(120, 30);
            this.btnIdentify.TabIndex = 1;
            this.btnIdentify.TabStop = false;
            this.btnIdentify.Text = "&Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnTempSwitchActive
            // 
            this.btnTempSwitchActive.Location = new System.Drawing.Point(248, 219);
            this.btnTempSwitchActive.Name = "btnTempSwitchActive";
            this.btnTempSwitchActive.Size = new System.Drawing.Size(230, 30);
            this.btnTempSwitchActive.TabIndex = 25;
            this.btnTempSwitchActive.TabStop = false;
            this.btnTempSwitchActive.Text = "Temporarily switch to active mode";
            this.btnTempSwitchActive.UseVisualStyleBackColor = true;
            this.btnTempSwitchActive.Click += new System.EventHandler(this.btnTempSwitchActive_Click);
            // 
            // btnTempSwitchCommand
            // 
            this.btnTempSwitchCommand.Location = new System.Drawing.Point(12, 219);
            this.btnTempSwitchCommand.Name = "btnTempSwitchCommand";
            this.btnTempSwitchCommand.Size = new System.Drawing.Size(230, 30);
            this.btnTempSwitchCommand.TabIndex = 24;
            this.btnTempSwitchCommand.TabStop = false;
            this.btnTempSwitchCommand.Text = "Temporarily switch to command mode";
            this.btnTempSwitchCommand.UseVisualStyleBackColor = true;
            this.btnTempSwitchCommand.Click += new System.EventHandler(this.btnTempSwitchCommand_Click);
            // 
            // frmMainUsb
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(960, 700);
            this.Controls.Add(this.btnTempSwitchActive);
            this.Controls.Add(this.btnTempSwitchCommand);
            this.Controls.Add(this.grbRead);
            this.Controls.Add(this.grbIdentify);
            this.Controls.Add(this.rtxtRes);
            this.Controls.Add(this.pnlConnect);
            this.Name = "MainUsb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlConnect.ResumeLayout(false);
            this.pnlConnect.PerformLayout();
            this.pnlChoiceInterface.ResumeLayout(false);
            this.pnlUsb.ResumeLayout(false);
            this.pnlUsb.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.grbRead.ResumeLayout(false);
            this.grbRead.PerformLayout();
            this.grbIdentify.ResumeLayout(false);
            this.grbIdentify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.Panel pnlUsb;
        private System.Windows.Forms.ComboBox cmbUsbDeviceList;
        private System.Windows.Forms.Label lblUsbDeviceChoice;
        private System.Windows.Forms.Panel pnlChoiceInterface;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUsbDevicePath;
        private System.Windows.Forms.Label lblUsbDevicePath;
        private System.Windows.Forms.RichTextBox rtxtRes;
        private System.Windows.Forms.GroupBox grbRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox ftxtAccessPwd;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtDataHex;
        private System.Windows.Forms.Label lblDataHex;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbMem;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblAccessPassword;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox grbIdentify;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnTempSwitchActive;
        private System.Windows.Forms.Button btnTempSwitchCommand;
    }
}