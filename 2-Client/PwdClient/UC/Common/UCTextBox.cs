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

namespace PwdClient.UC.Common
{
    //自定义TextBox控件
    public partial class UCTextBox : UserControl
    {
        public Color defaultcolor = Color.FromArgb(12, 169, 235);
        public bool IsPassword
        {
            get { return !txtKey.UseSystemPasswordChar; }
            set { txtKey.UseSystemPasswordChar = !value; }
        }
        //边框颜色
        public Color BorderColor
        {
            get { return defaultcolor; }
            set { defaultcolor = value; }
        }
        
        //水印文字
        public string WaterText
        {
            get { return lblWater.Text; }
            set { lblWater.Text = value; }
        }
        //内容
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
                              defaultcolor, 1, ButtonBorderStyle.Solid,
                              defaultcolor, 1, ButtonBorderStyle.Solid,
                              defaultcolor, 1, ButtonBorderStyle.Solid,
                              defaultcolor, 1, ButtonBorderStyle.Solid);
            //if (BorderColor.Name == "0")
            //{
            //    ControlPaint.DrawBorder(e.Graphics, panelInput.ClientRectangle,
            //                        Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                        Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                        Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid,
            //                        Color.FromArgb(12, 169, 235), 1, ButtonBorderStyle.Solid);
            //}
            //else
            //{
            //    ControlPaint.DrawBorder(e.Graphics, panelInput.ClientRectangle,
            //                   BorderColor, 1, ButtonBorderStyle.Solid,
            //                   BorderColor, 1, ButtonBorderStyle.Solid,
            //                   BorderColor, 1, ButtonBorderStyle.Solid,
            //                   BorderColor, 1, ButtonBorderStyle.Solid);
            //}

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
