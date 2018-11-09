using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using System.Threading;

namespace PwdClient.UC
{
    public partial class UCPwdList : UserControl
    {
        //private int doPaintTop = 0;
        //private int doPaintBody = 0;

        public UCPwdList()
        {
            InitializeComponent();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            //if (doPaintTop == 0)
            //{
            //    ControlPaint.DrawBorder(e.Graphics, panelTop.ClientRectangle,
            //                 Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                 Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                 Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                 Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid);
            //    doPaintTop += 1;
            //}
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {
            //if (doPaintBody == 0)
            //{
            //    ControlPaint.DrawBorder(e.Graphics, panelBody.ClientRectangle,
            //                  Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                  Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                  Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                  Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid);

            //    doPaintBody += 1;
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.StartPosition = FormStartPosition.CenterScreen;
           // frm.Opacity = 0;
            frm.Show();
            

            //for (int i = 0; i <= 10; i++)
            //{
            //    Thread.Sleep(15);
            //    Application.DoEvents();
            //    frm.Opacity = i / 10;
            //}
        }

       
    }
}
