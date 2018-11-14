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
    public partial class UCPwdCategory : UserControl
    {
        public string CategoryName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public Image CategoryImg
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public UCPwdCategory()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                           Color.FromArgb(12, 169, 235), 0, ButtonBorderStyle.Solid,
                           Color.FromArgb(12, 169, 235), 0, ButtonBorderStyle.Solid,
                           Color.FromArgb(12, 169, 235), 0, ButtonBorderStyle.Solid,
                           Color.LightGray, 1, ButtonBorderStyle.Solid);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void Category_Click(object sender, EventArgs e)
        {
            //关闭类别窗口
            frmCategory frmCategory = (frmCategory)Parent.Parent;
            frmCategory.Hide();
            //开启添加窗口
            frmAddPwd frm = new frmAddPwd();
            frm.CategroyName = CategoryName;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            frmCategory.Dispose();
        }
    }
}
