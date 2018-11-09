using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdClient
{
    //基类窗体，主要实现无边框窗体的拖动和四周阴影，以及通用的去除窗体边框的方法
    public partial class BaseForm : Form
    {
        //定义无边框窗体Form 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        public bool isShadow;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        // private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                isShadow = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!isShadow)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        const int Guying_HTLEFT = 10;
        const int Guying_HTRIGHT = 11;
        const int Guying_HTTOP = 12;
        const int Guying_HTTOPLEFT = 13;
        const int Guying_HTTOPRIGHT = 14;
        const int Guying_HTBOTTOM = 15;
        const int Guying_HTBOTTOMLEFT = 0x10;
        const int Guying_HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (isShadow)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;

            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;
        }

        public void InitStyle(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.BackColor = Color.White;

        }
        ///<summary>
        ///拖动Panel 窗体移动
        ///</summary>
        ///<param name="form1">窗口实例</param>
        ///<param name="panel1">要拖动的Panel</param>
        public static void MoveForm(Form form1, System.Windows.Forms.Panel panel1)
        {
            ReleaseCapture();
            SendMessage(form1.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//*********************调用移动无窗体控件函数 
        }

        public static void PicClose(Form frm)
        {
            frm.Close();
            frm.Dispose();
        }

        public static void ShowTooltip(Control control, string msg, int durationTime)
        {
            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = durationTime;
            tip.InitialDelay = 100;
            tip.ReshowDelay = 500;
            tip.ShowAlways = true;
            tip.SetToolTip(control, msg);
        }

        public void SetBorderRadius(Control control)
        {
            float X = (float)(control.Width);
            float Y = (float)(control.Height);
            PointF[] points =
            {
                    new PointF(2,0),
                    new PointF(X-2,0),
                    new PointF(X,2),
                    new PointF(X,Y-2),
                    new PointF(X-2,Y),
                    new PointF(2,Y),
                    new PointF(0,Y-2),
                    new PointF(0,2),
                };
            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);
            control.Region = new Region(path);
        }

        public BaseForm()
        {
            InitializeComponent();
        }
    }
}
