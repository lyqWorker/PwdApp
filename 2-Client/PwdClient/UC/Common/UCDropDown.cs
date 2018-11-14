using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
using System.Drawing.Design;

namespace PwdClient.UC.Common
{
    public partial class UCDropDown : UserControl
    {
        public Color defaultcolor = Color.FromArgb(12, 169, 235);
        //边框颜色
        public Color BorderColor
        {
            get { return defaultcolor; }
            set { defaultcolor = value; }
        }
        //集合
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ObjectCollection Items
        {
            get { return comboBox1.Items; }
        }

        public ComboBox ComboBox;

        public UCDropDown()
        {
            InitializeComponent();
            ComboBox = comboBox1;
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelBg.ClientRectangle,
                           defaultcolor, 1, ButtonBorderStyle.Solid,
                           defaultcolor, 1, ButtonBorderStyle.Solid,
                           defaultcolor, 1, ButtonBorderStyle.Solid,
                           defaultcolor, 1, ButtonBorderStyle.Solid);
        }
    }
}
