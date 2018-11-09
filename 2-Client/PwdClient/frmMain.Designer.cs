namespace PwdClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.picBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picSmall
            // 
            this.picSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSmall.Image = ((System.Drawing.Image)(resources.GetObject("picSmall.Image")));
            this.picSmall.Location = new System.Drawing.Point(1246, 2);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(25, 25);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSmall.TabIndex = 21;
            this.picSmall.TabStop = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::PwdClient.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(1308, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 19;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.picTitle);
            this.panelTitle.Location = new System.Drawing.Point(0, 31);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1338, 54);
            this.panelTitle.TabIndex = 22;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(66, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "密码机";
            // 
            // picTitle
            // 
            this.picTitle.Image = global::PwdClient.Properties.Resources.title;
            this.picTitle.Location = new System.Drawing.Point(20, 6);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(40, 40);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.Location = new System.Drawing.Point(150, 85);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1188, 769);
            this.panelBody.TabIndex = 24;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(0, 85);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(151, 769);
            this.panelLeft.TabIndex = 23;
            // 
            // picBig
            // 
            this.picBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBig.Image = global::PwdClient.Properties.Resources.big;
            this.picBig.Location = new System.Drawing.Point(1277, 2);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(25, 25);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBig.TabIndex = 25;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 854);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.picClose);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox picBig;
    }
}