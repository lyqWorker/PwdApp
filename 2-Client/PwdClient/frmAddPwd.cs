using Contract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace PwdClient
{
    public partial class frmAddPwd : BaseForm
    {
        //密码类别
        public string CategroyName { get; set; }
        //服务地址
        private string HTTPUrl;

        public frmAddPwd()
        {
            InitializeComponent();
            Init();

        }
        private void Init()
        {
            InitStyle(this);
            cbxLevel.ComboBox.SelectedIndex = 0;
            HTTPUrl = Path.Combine(Program.HTTPServer, "api/Pwd/AddPwdList");
        }


        #region 宽口关闭、最大、最小化
        private void picClose_Click(object sender, EventArgs e)
        {
            PicClose(this);
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.close_blue;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.close;
        }

        #endregion


        private void btnCanel_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length == 0)
            {
                txtTitle.Focus();
                return;
            }
            try
            {
                PwdInfo pwd = new PwdInfo()
                {
                    Title = txtTitle.Text.Trim(),
                    CreateUser = Program.UserId,
                    Description = txtDescription.Text.Trim(),
                    SecrecyLevel = cbxLevel.ComboBox.Text,
                    Category = CategroyName
                };
                string result = HTTPUtils.PostData(HTTPUrl, pwd);
                var res = JsonConvert.DeserializeObject<HttpResponse>(result);
                if (res.ResState == ResponseState.Success)
                {

                    Hide();
                    Close();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
