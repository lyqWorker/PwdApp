namespace PwdClient.UC.Common
{
    partial class UCTextBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblWater = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Controls.Add(this.lblWater);
            this.panelInput.Controls.Add(this.txtKey);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(250, 35);
            this.panelInput.TabIndex = 10;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWater.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWater.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWater.Location = new System.Drawing.Point(12, 8);
            this.lblWater.Margin = new System.Windows.Forms.Padding(0);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(80, 18);
            this.lblWater.TabIndex = 101;
            this.lblWater.Text = "水印文字";
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKey.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKey.Location = new System.Drawing.Point(10, 6);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(226, 24);
            this.txtKey.TabIndex = 1;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            this.txtKey.Enter += new System.EventHandler(this.txtKey_Enter);
            // 
            // UCTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelInput);
            this.Name = "UCTextBox";
            this.Size = new System.Drawing.Size(250, 35);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.TextBox txtKey;
    }
}
