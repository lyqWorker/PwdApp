using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdClient.UC
{
    public partial class UCLeftMenu : UserControl
    {
        public string MenuName
        {
            get { return btnMenu.Text; }
            set { btnMenu.Text = value; }
        }

        private Dictionary<string, Control> dicUC = new Dictionary<string, Control>();
        public UCLeftMenu()
        {
            InitializeComponent();
            InitControl();
        }

        //提前加载菜单控件
        private void InitControl()
        {
            //密码列表控件
            UCPwdList ucPwd = new UCPwdList();
            ucPwd.Dock = DockStyle.Fill;

            dicUC["密码列表"] = ucPwd;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Panel panelLeft = (Panel)Parent;
            foreach (Control control in panelLeft.Controls)
            {
                control.Controls.Find("btnMenu", true)[0].ForeColor = Color.FromArgb(64, 64, 64);
            }
            string menu = btnMenu.Text.Trim();
            btnMenu.ForeColor = Color.FromArgb(12, 169, 235);
            Panel panelBody = (Panel)panelLeft.Parent.Controls.Find("panelBody", true)[0];
            panelBody.Controls.Clear();

            switch (menu)
            {
                case "密码列表":
                    {
                        panelBody.Controls.Add(dicUC[menu]);
                        break;
                    }
                case "日志查看":
                    {
                        break;
                    }
                case "口令修改":
                    {
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
