using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmDieuChinhNguyenLieu : Form
    {
        QLCPDbContext context = new QLCPDbContext();
        string maNL = "";


        public frmDieuChinhNguyenLieu(string maNL)
        {
            InitializeComponent();
            this.maNL = maNL;
        }
        public frmDieuChinhNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmDieuChinhNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();

            radNhap.Checked = true;
            numSoLuong.Minimum = 1;
        }

        void LoadNguyenLieu()
        {
            var nl = context.NguyenLieu.Find(maNL);

            if (nl != null)
            {
                lblTenNguyenLieu.Text = nl.TenNL;
                lblSoLuongTon.Text = "" + (nl.SoLuongTon ?? 0).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNL = this.maNL;
            decimal soLuong = numSoLuong.Value;

            var nl = context.NguyenLieu.Find(maNL);

            nl.SoLuongTon = nl.SoLuongTon ?? 0;

            if (radXuat.Checked && nl.SoLuongTon < soLuong)
            {
                MessageBox.Show("Không đủ số lượng tồn!");
                return;
            }

            if (radNhap.Checked)
                nl.SoLuongTon += soLuong;
            else
                nl.SoLuongTon -= soLuong;

            InventoryMovements mv = new InventoryMovements
            {
                MaNL = maNL,
                ChangeQty = radNhap.Checked ? soLuong : -soLuong,
                MovementType = radNhap.Checked ? "Nhap" : "Xuat",
                CreatedAt = DateTime.Now
            };

            context.InventoryMovements.Add(mv);

            context.SaveChanges();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
