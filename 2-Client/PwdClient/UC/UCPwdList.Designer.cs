using System;
using System.Windows.Forms;

namespace PwdClient.UC
{
    partial class UCPwdList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.dgvPwdList = new System.Windows.Forms.DataGridView();
            this.pwdCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pwdtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdOpear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtQuery = new PwdClient.UC.Common.UCTextBox();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPwdList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnUpdate);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.txtQuery);
            this.panelTop.Location = new System.Drawing.Point(18, 20);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(930, 90);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(798, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(723, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(648, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.dgvPwdList);
            this.panelBody.Location = new System.Drawing.Point(18, 132);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(930, 457);
            this.panelBody.TabIndex = 1;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // dgvPwdList
            // 
            this.dgvPwdList.AllowUserToAddRows = false;
            this.dgvPwdList.AllowUserToDeleteRows = false;
            this.dgvPwdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPwdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPwdList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPwdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPwdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPwdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPwdList.ColumnHeadersHeight = 30;
            this.dgvPwdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pwdCheck,
            this.pwdtitle,
            this.pwdDescribe,
            this.pwdLevel,
            this.pwdOpear});
            this.dgvPwdList.Location = new System.Drawing.Point(5, 3);
            this.dgvPwdList.Name = "dgvPwdList";
            this.dgvPwdList.ReadOnly = true;
            this.dgvPwdList.RowHeadersVisible = false;
            this.dgvPwdList.RowTemplate.Height = 23;
            this.dgvPwdList.Size = new System.Drawing.Size(920, 451);
            this.dgvPwdList.TabIndex = 1;
            // 
            // pwdCheck
            // 
            this.pwdCheck.FillWeight = 25F;
            this.pwdCheck.HeaderText = "选择";
            this.pwdCheck.Name = "pwdCheck";
            this.pwdCheck.ReadOnly = true;
            // 
            // pwdtitle
            // 
            this.pwdtitle.HeaderText = "标题";
            this.pwdtitle.Name = "pwdtitle";
            this.pwdtitle.ReadOnly = true;
            // 
            // pwdDescribe
            // 
            this.pwdDescribe.HeaderText = "描述";
            this.pwdDescribe.Name = "pwdDescribe";
            this.pwdDescribe.ReadOnly = true;
            // 
            // pwdLevel
            // 
            this.pwdLevel.FillWeight = 50F;
            this.pwdLevel.HeaderText = "等级";
            this.pwdLevel.Name = "pwdLevel";
            this.pwdLevel.ReadOnly = true;
            // 
            // pwdOpear
            // 
            this.pwdOpear.FillWeight = 50F;
            this.pwdOpear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwdOpear.HeaderText = "操作";
            this.pwdOpear.Name = "pwdOpear";
            this.pwdOpear.ReadOnly = true;
            this.pwdOpear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pwdOpear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.White;
            this.txtQuery.Location = new System.Drawing.Point(18, 27);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(350, 35);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.WaterText = "请输入标题";
            // 
            // UCPwdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.Name = "UCPwdList";
            this.Size = new System.Drawing.Size(968, 611);
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPwdList)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBody;
        private Common.UCTextBox txtQuery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPwdList;
        private DataGridViewCheckBoxColumn pwdCheck;
        private DataGridViewTextBoxColumn pwdtitle;
        private DataGridViewTextBoxColumn pwdDescribe;
        private DataGridViewTextBoxColumn pwdLevel;
        private DataGridViewButtonColumn pwdOpear;
    }
}
