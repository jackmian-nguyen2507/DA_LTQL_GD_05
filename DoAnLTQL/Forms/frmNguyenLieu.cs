using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmNguyenLieu : Form
    {
        QLCPDbContext context = new QLCPDbContext();

        List<NguyenLieu.DanhSachNguyenLieu> dsNguyenLieuCache
                                            = new List<NguyenLieu.DanhSachNguyenLieu>();

        public frmNguyenLieu()
        {
            InitializeComponent();
            SetupLayout();
        }


        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            dtgvNguyenLieu.AutoGenerateColumns = false;
            LoadNguyenLieu();
        }

        void LoadNguyenLieu()
        {
            dsNguyenLieuCache = context.NguyenLieu
                .Include(nl => nl.DonVi)
                .Select(nl => new NguyenLieu.DanhSachNguyenLieu
                {
                    MaNL = nl.MaNL,
                    TenNL = nl.TenNL,
                    TenDonVi = nl.DonVi != null ? nl.DonVi.TenDonVi : "",
                    SoLuongTon = nl.SoLuongTon
                }).ToList();

            BindData(dsNguyenLieuCache);
        }

        void BindData(List<NguyenLieu.DanhSachNguyenLieu> data)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data;
            dtgvNguyenLieu.DataSource = bs;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var result = dsNguyenLieuCache
                .Where(nl =>
                    (nl.TenNL ?? "").ToLower().Contains(keyword) ||
                    (nl.TenDonVi ?? "").ToLower().Contains(keyword)
                )
                .ToList();

            BindData(result);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu f = new frmThemNguyenLieu();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nguyên liệu?",
                "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maNL = dtgvNguyenLieu.CurrentRow.Cells["MaNL"].Value.ToString();

                var nl = context.NguyenLieu.Find(maNL);

                if (nl != null)
                {
                    context.NguyenLieu.Remove(nl);
                    context.SaveChanges();
                }

                LoadNguyenLieu();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        // =============================
        // 1. Setup Layout (Fullscreen)
        // =============================
        private void SetupLayout()
        {
            this.WindowState = FormWindowState.Maximized;

            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;

            panelControl.Dock = DockStyle.Top;
            panelControl.Height = 80;

            dtgvNguyenLieu.Dock = DockStyle.Fill;

            // Tô màu đều 2 panel
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            panelControl.BackColor = Color.FromArgb(246, 236, 210);

            // Tự căn label + icon trong header
            pictureBox1.Left = (pnlHeader.Width / 2) - 150;
            pictureBox1.Top = 18;

            lblQLNL.Left = pictureBox1.Right + 15;
            lblQLNL.Top = 20;

            pnlHeader.Resize += (s, e) =>
            {
                pictureBox1.Left = (pnlHeader.Width / 2) - 150;
                lblQLNL.Left = pictureBox1.Right + 15;
            };
        }

        private void dtgvNguyenLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvNguyenLieu.Columns[e.ColumnIndex].Name == "SoLuongTon")
            {
                if (e.Value != null)
                {
                    e.Value = string.Format("{0:N2}", e.Value);
                    e.FormattingApplied = true;
                }
            }

        }

        private void btnDieuChinh_Click(object sender, EventArgs e)
        {
            if (dtgvNguyenLieu.CurrentRow == null) return;

            string maNL = dtgvNguyenLieu.CurrentRow.Cells["MaNL"].Value.ToString();

            frmDieuChinhNguyenLieu f = new frmDieuChinhNguyenLieu(maNL);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvNguyenLieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần sửa!");
                return;
            }

            string maNL = dtgvNguyenLieu.CurrentRow.Cells["MaNL"].Value.ToString();

            frmThemNguyenLieu f = new frmThemNguyenLieu(maNL);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }
    }
}
