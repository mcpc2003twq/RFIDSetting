namespace RFIDsetting_test
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.btnUsb = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnUsb
            // 
            this.btnUsb.Location = new System.Drawing.Point(324, 405);
            this.btnUsb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsb.Name = "btnUsb";
            this.btnUsb.Size = new System.Drawing.Size(446, 87);
            this.btnUsb.TabIndex = 2;
            this.btnUsb.Text = "Usb Interface";
            this.btnUsb.UseVisualStyleBackColor = true;
            this.btnUsb.Click += new System.EventHandler(this.btnUsb_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btnUsb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsb;
    }
}

