using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace PwdClient
{
    public partial class frmCategory : BaseForm
    {
        public frmCategory()
        {
            InitializeComponent();
            //去除边框
            InitStyle(this);
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

        //绘画“选择类别”下的线
        private void panelToplight_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelToplight.ClientRectangle,
                        Color.FromArgb(12, 169, 235), 0, ButtonBorderStyle.Solid,
                        Color.Red, 0, ButtonBorderStyle.Solid,
                        Color.Blue, 0, ButtonBorderStyle.Solid,
                        Color.LightGray, 1, ButtonBorderStyle.Solid);
        }
    }
}
