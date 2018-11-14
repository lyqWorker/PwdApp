namespace PwdClient
{
    partial class frmCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryQQ = new PwdClient.UC.UCPwdCategory();
            this.categoryGithub = new PwdClient.UC.UCPwdCategory();
            this.categoryEmail = new PwdClient.UC.UCPwdCategory();
            this.categoryCard = new PwdClient.UC.UCPwdCategory();
            this.categoryAlipay = new PwdClient.UC.UCPwdCategory();
            this.categoryWeChat = new PwdClient.UC.UCPwdCategory();
            this.categoryCommon = new PwdClient.UC.UCPwdCategory();
            this.categoryEcs = new PwdClient.UC.UCPwdCategory();
            this.label1 = new System.Windows.Forms.Label();
            this.panelToplight = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.categoryQQ);
            this.panel1.Controls.Add(this.categoryGithub);
            this.panel1.Controls.Add(this.categoryEmail);
            this.panel1.Controls.Add(this.categoryCard);
            this.panel1.Controls.Add(this.categoryAlipay);
            this.panel1.Controls.Add(this.categoryWeChat);
            this.panel1.Controls.Add(this.categoryCommon);
            this.panel1.Controls.Add(this.categoryEcs);
            this.panel1.Location = new System.Drawing.Point(-1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 373);
            this.panel1.TabIndex = 12;
            // 
            // categoryQQ
            // 
            this.categoryQQ.CategoryImg = global::PwdClient.Properties.Resources.qq;
            this.categoryQQ.CategoryName = "QQ";
            this.categoryQQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryQQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryQQ.Location = new System.Drawing.Point(0, 273);
            this.categoryQQ.Name = "categoryQQ";
            this.categoryQQ.Size = new System.Drawing.Size(267, 39);
            this.categoryQQ.TabIndex = 7;
            // 
            // categoryGithub
            // 
            this.categoryGithub.CategoryImg = global::PwdClient.Properties.Resources.github;
            this.categoryGithub.CategoryName = "GitHub";
            this.categoryGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryGithub.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryGithub.Location = new System.Drawing.Point(0, 234);
            this.categoryGithub.Name = "categoryGithub";
            this.categoryGithub.Size = new System.Drawing.Size(267, 39);
            this.categoryGithub.TabIndex = 6;
            // 
            // categoryEmail
            // 
            this.categoryEmail.CategoryImg = global::PwdClient.Properties.Resources.email;
            this.categoryEmail.CategoryName = "邮箱";
            this.categoryEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryEmail.Location = new System.Drawing.Point(0, 195);
            this.categoryEmail.Name = "categoryEmail";
            this.categoryEmail.Size = new System.Drawing.Size(267, 39);
            this.categoryEmail.TabIndex = 5;
            // 
            // categoryCard
            // 
            this.categoryCard.CategoryImg = global::PwdClient.Properties.Resources.card;
            this.categoryCard.CategoryName = "银行卡";
            this.categoryCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryCard.Location = new System.Drawing.Point(0, 156);
            this.categoryCard.Name = "categoryCard";
            this.categoryCard.Size = new System.Drawing.Size(267, 39);
            this.categoryCard.TabIndex = 4;
            // 
            // categoryAlipay
            // 
            this.categoryAlipay.CategoryImg = global::PwdClient.Properties.Resources.alipay;
            this.categoryAlipay.CategoryName = "支付宝";
            this.categoryAlipay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryAlipay.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryAlipay.Location = new System.Drawing.Point(0, 117);
            this.categoryAlipay.Name = "categoryAlipay";
            this.categoryAlipay.Size = new System.Drawing.Size(267, 39);
            this.categoryAlipay.TabIndex = 3;
            // 
            // categoryWeChat
            // 
            this.categoryWeChat.CategoryImg = global::PwdClient.Properties.Resources.wechat;
            this.categoryWeChat.CategoryName = "微信";
            this.categoryWeChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryWeChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryWeChat.Location = new System.Drawing.Point(0, 78);
            this.categoryWeChat.Name = "categoryWeChat";
            this.categoryWeChat.Size = new System.Drawing.Size(267, 39);
            this.categoryWeChat.TabIndex = 2;
            // 
            // categoryCommon
            // 
            this.categoryCommon.CategoryImg = global::PwdClient.Properties.Resources.common;
            this.categoryCommon.CategoryName = "通用网站";
            this.categoryCommon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryCommon.Location = new System.Drawing.Point(0, 39);
            this.categoryCommon.Name = "categoryCommon";
            this.categoryCommon.Size = new System.Drawing.Size(267, 39);
            this.categoryCommon.TabIndex = 1;
            // 
            // categoryEcs
            // 
            this.categoryEcs.CategoryImg = global::PwdClient.Properties.Resources.ecs;
            this.categoryEcs.CategoryName = "云服务器";
            this.categoryEcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryEcs.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryEcs.Location = new System.Drawing.Point(0, 0);
            this.categoryEcs.Name = "categoryEcs";
            this.categoryEcs.Size = new System.Drawing.Size(267, 39);
            this.categoryEcs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择密码类别";
            // 
            // panelToplight
            // 
            this.panelToplight.Location = new System.Drawing.Point(-1, 42);
            this.panelToplight.Name = "panelToplight";
            this.panelToplight.Size = new System.Drawing.Size(267, 10);
            this.panelToplight.TabIndex = 13;
            this.panelToplight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToplight_Paint);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::PwdClient.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(236, 10);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 11;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 428);
            this.Controls.Add(this.panelToplight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picClose);
            this.Name = "frmCategory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmCategory";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private UC.UCPwdCategory categoryEcs;
        private System.Windows.Forms.Panel panelToplight;
        private UC.UCPwdCategory categoryWeChat;
        private UC.UCPwdCategory categoryCommon;
        private UC.UCPwdCategory categoryAlipay;
        private UC.UCPwdCategory categoryCard;
        private UC.UCPwdCategory categoryEmail;
        private UC.UCPwdCategory categoryGithub;
        private UC.UCPwdCategory categoryQQ;
    }
}