using Contract;
using PwdClient.UC;
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
    public partial class frmMain : BaseForm
    {
        //左侧菜单列表
        private List<string> MenuList = new List<string>() { "日志查看", "口令修改", "密码列表" };

        //密码本
        public List<PwdInfo> PwdList = new List<PwdInfo>();
        private string GetPwdListUrl;

        public frmMain()
        {
            InitializeComponent();
            InitStyle();
            GetPwdList();
        }

        public void GetPwdList()
        {
            GetPwdListUrl = Path.Combine(Program.HTTPServer, "api/Pwd/GetPwdList");
            string param = string.Format(@"?UserId={0}", Program.UserId);
            string url = GetPwdListUrl + param;
            PwdList = HTTPUtils.GetDataList<PwdInfo>(url);
        }

        private void InitStyle()
        {
            panelLeft.BackColor = Color.FromArgb(255, 255, 255);
            panelTitle.BackColor = Color.FromArgb(64, 64, 64);
            InitStyle(this);
            //测试时先读取临时，后期需改动态菜单列表
            foreach (var item in MenuList)
            {
                UCLeftMenu menu = new UCLeftMenu();
                menu.MenuName = item;
                menu.Dock = DockStyle.Top;
                panelLeft.Controls.Add(menu);
            }

            //默认选择第一个菜单项
            int index = panelLeft.Controls.Count - 1;
            panelLeft.Controls[index].Controls.Find("btnMenu",true)[0].ForeColor = Color.FromArgb(12, 169, 235);

            //先清空，再加载
            panelBody.Controls.Clear();
            UCPwdList pwdList = new UCPwdList();
            pwdList.Dock = DockStyle.Fill;
            panelBody.Controls.Add(pwdList);
        }

        #region 公共事件
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.close;
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.close_blue;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //最大化图片切换
        private void picBig_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                picBig.Image = Properties.Resources.big;
                return;
            }
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                picBig.Image = Properties.Resources.normal;
                return;
            }
        }

        //绘画边框
        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, panelTitle.ClientRectangle,
                                Color.FromArgb(64, 64, 64), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(64, 64, 64), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(64, 64, 64), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(64, 64, 64), 1, ButtonBorderStyle.Solid);
        }
        #endregion

    }
}
