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
using Contract;
using System.IO;

namespace PwdClient.UC
{
    public partial class UCPwdList : UserControl
    {
       
        public UCPwdList()
        {
            InitializeComponent();
        }
        public void BindData(List<PwdInfo> list)
        {
            dgvPwdList.DataSource = list;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void dgvPwdList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPwdList.Rows[e.RowIndex].Cells["RowNo"].Value = e.RowIndex + 1;
        }

        private void UCPwdList_Load(object sender, EventArgs e)
        {
            var main = (frmMain)Parent.Parent;
            BindData(main.PwdList);
        }
    }
}
