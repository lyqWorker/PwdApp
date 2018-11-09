using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdClient.UC.Common
{
    //自定义TextBox控件
    public partial class UCTextBox : UserControl
    {
        //水印文字
        public string WaterText
        {
            get { return lblWater.Text; }
            set { lblWater.Text = value; }
        }
        public override string Text
        {
            get { return txtKey.Text; }
            set { txtKey.Text = value; }
        }
        
        public TextBox textBox;
        public UCTextBox()
        {
            InitializeComponent();
            textBox = txtKey;
        }

        //绘画边框
        private void panelInput_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelInput.ClientRectangle,
                                Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid);
        }
        //水印文字效果
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            string text = txtKey.Text.Replace("\r\n", "");
            if (text.Length > 0)
            {
                lblWater.Hide();
            }
            else
            {
                lblWater.Show();
            }
        }
        private void txtKey_Enter(object sender, EventArgs e)
        {
            string text = txtKey.Text.Replace("\r\n", "");
            if (text.Length > 0)
            {
                lblWater.Hide();
            }
            else
            {
                lblWater.Show();
            }
        }
    }
}
