using Contract;
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
    public partial class frmLogin : BaseForm
    {
        //服务地址
        private string HTTPUrl;
        public frmLogin()
        {
            InitializeComponent();
            Init();
        }

        #region 初始化
        private void Init()
        {
            //初始化样式，去除winfrom窗体的通用样式（无边框模式）
            InitDataAndStyle();
            //初始化事件
            InitEvent();
        }
        private void InitEvent()
        {
            txtKey.textBox.KeyDown += TextBox_KeyDown;
            txtKey.textBox.TextChanged += TextBox_TextChanged;
        }
        private void InitDataAndStyle()
        {
            HTTPUrl = Path.Combine(Program.HTTPServer, "api/Login/GetLogin");
            InitStyle(this);
            SetBorderRadius(lblMsg);
            lblMsg.BackColor = Color.FromArgb(242, 222, 222);
            lblMsg.ForeColor = Color.FromArgb(169, 68, 66);
            lblMsg.Hide();
        }
        #endregion


        #region 公共事件

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text.Replace("\r\n", "").Length > 0)
            {
                lblMsg.Hide();
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //回车键开始请求后端
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtKey.Text.Replace("\r\n", "");
                if (key.Length > 0)
                {
                    //测试
                    if (key == "123")
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                        Dispose();
                        return;
                    }
                    //登录逻辑
                    string param = string.Format(@"?key={0}", key);
                    string url = HTTPUrl + param;
                    try
                    {
                        //获取后端验证结果
                        var res = HTTPUtils.GetData<HttpResponse>(url);

                        if (res.ResState == ResponseState.Success)
                        {
                            //验证成功后，关闭登录窗口
                            DialogResult = DialogResult.OK;
                            Program.UserId = res.ResContent;
                            Close();
                            Dispose();
                        }
                        else if (res.ResState == ResponseState.Fail)
                        {
                            txtKey.Text = "";
                            string msg = "失败!" + res.ResContent;
                            Alert(msg);
                        }
                        else
                        {
                            txtKey.Text = "";
                            string msg = "失败!服务器500错误";
                            Alert(msg);
                        }
                    }
                    catch
                    {
                        txtKey.Text = "";
                        string msg = "失败!Http请求异常";
                        Alert(msg);
                    }

                }
                else
                {
                    Alert("请输入口令");
                }
            }
        }

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

        //显示错误信息
        private void Alert(string msg)
        {
            lblMsg.Show();
            lblMsg.Text = msg.Trim();
        }
    }
}
