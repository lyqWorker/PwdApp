namespace PwdClient
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKey = new PwdClient.UC.Common.UCTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::PwdClient.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(318, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Silver;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(48, 28);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Padding = new System.Windows.Forms.Padding(8);
            this.lblMsg.Size = new System.Drawing.Size(250, 32);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.Text = "label";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.Location = new System.Drawing.Point(48, 153);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(250, 35);
            this.txtKey.TabIndex = 13;
            this.txtKey.WaterText = "请输入口令";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 241);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picClose);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UC.Common.UCTextBox txtKey;
    }
}