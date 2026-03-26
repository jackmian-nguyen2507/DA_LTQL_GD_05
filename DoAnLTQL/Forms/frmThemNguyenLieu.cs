using System;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmThemNguyenLieu : Form
    {

        public frmThemNguyenLieu(NguyenLieu nl, bool adjustMode = false)
        {
            InitializeComponent();

        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        }
    }
}
