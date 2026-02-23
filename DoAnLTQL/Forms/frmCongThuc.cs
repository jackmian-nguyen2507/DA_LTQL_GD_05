using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmCongThuc : Form
    {
        QLCPDbContext context = new QLCPDbContext();
        string maSP = "";

        public frmCongThuc()
        {
            InitializeComponent();

        }

        private void frmCongThuc_Load(object sender, EventArgs e)
        {
            dtgvSanPham.AutoGenerateColumns = false;
            dtgvCongThuc.AutoGenerateColumns = false;

            SetupLayout();
            LoadSanPham();
            LoadNguyenLieu();
        }

        void LoadNguyenLieu()
        {
            cboNguyenLieu.DataSource = context.NguyenLieu
                .Select(nl => new
                {
                    nl.MaNL,
                    nl.TenNL
                })
                .ToList();

            cboNguyenLieu.ValueMember = "MaNL";
            cboNguyenLieu.DisplayMember = "TenNL";
        }


        void LoadSanPham()
        {
            dtgvSanPham.DataSource = context.SanPham
                .Include(sp => sp.LoaiSanPham)
                .Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    TenLoaiSP = sp.LoaiSanPham.TenLoai,
                    sp.DonGia,
                    sp.TrangThai
                })
                .ToList();
        }

        void LoadCongThuc()
        {
            var data = context.CongThuc
            .Include(ct => ct.NguyenLieu)
            .ThenInclude(nl => nl.DonVi)
            .Where(ct => ct.MaSP == maSP)
            .Select(ct => new
            {
                ct.MaSP,
                ct.MaNL,
                TenNguyenLieu = ct.NguyenLieu != null ? ct.NguyenLieu.TenNL : "",
                ct.SoLuong,
                DonVi = ct.NguyenLieu != null ? ct.NguyenLieu.DonVi.TenDonVi : ""
            })
            .ToList();

                dtgvCongThuc.DataSource = data;
        }


        private void SetupLayout()
        {
            this.WindowState = FormWindowState.Maximized;

            // ----- HEADER -----
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;

            lblTitle.AutoSize = true;
            pnlHeader.Resize += (s, e) =>
            {
                lblTitle.Left = (pnlHeader.Width - lblTitle.Width) / 2;
                lblTitle.Top = (pnlHeader.Height - lblTitle.Height) / 2;
            };

            // ----- MENU -----
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Height = 60;

            // ----- PANEL SẢN PHẨM -----
            pnlSanPham.Dock = DockStyle.Left;
            pnlSanPham.Width = 500;

            dtgvSanPham.Dock = DockStyle.Fill;

            // ----- PANEL CÔNG THỨC -----
            pnlCongThuc.Dock = DockStyle.Fill;

            // THÊM PANEL DƯỚI ĐỂ CHỨA INPUT
            Panel pnlInput = new Panel();
            pnlInput.Dock = DockStyle.Bottom;
            pnlInput.Height = 130;
            pnlInput.BackColor = Color.White;

            pnlCongThuc.Controls.Add(pnlInput);
            pnlInput.BringToFront();

            // DTGV PHẦN TRÊN
            dtgvCongThuc.Dock = DockStyle.Fill;

            // ----- CĂN LAYOUT INPUT -----
            SetupInputLayout(pnlInput);
        }


        private void SetupInputLayout(Panel pnlInput)
        {
            int left = 20;
            int top = 10;
            int spacing = 10;

            // Label tìm NL
            label4.Parent = pnlInput;
            label4.Left = left;
            label4.Top = top;

            // Textbox tìm NL
            txtTimNL.Parent = pnlInput;
            txtTimNL.Left = left;
            txtTimNL.Top = label4.Bottom + 5;
            txtTimNL.Width = 350;

            // Combobox NL
            cboNguyenLieu.Parent = pnlInput;
            cboNguyenLieu.Left = left;
            cboNguyenLieu.Top = txtTimNL.Bottom + 5;
            cboNguyenLieu.Width = 350;

            // Label số lượng
            lblSoLuong.Parent = pnlInput;
            lblSoLuong.Left = txtTimNL.Right + 40;
            lblSoLuong.Top = txtTimNL.Top + 5;

            // txt số lượng
            txtSoLuong.Parent = pnlInput;
            txtSoLuong.Left = lblSoLuong.Left;
            txtSoLuong.Top = cboNguyenLieu.Top;
            txtSoLuong.Width = 120;

            // Nút thêm
            btnThemCapNhat.Parent = pnlInput;
            btnThemCapNhat.Left = txtSoLuong.Right + 30;
            btnThemCapNhat.Top = txtSoLuong.Top - 5;
            btnThemCapNhat.Width = 160;

            // Nút xóa
            btnXoa.Parent = pnlInput;
            btnXoa.Left = btnThemCapNhat.Right + 20;
            btnXoa.Top = btnThemCapNhat.Top;
            btnXoa.Width = 120;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dtgvSanPham.CurrentRow == null) return;

            // Lấy MaSP từ grid sản phẩm
            maSP = dtgvSanPham.CurrentRow.Cells[0].Value.ToString();

            MessageBox.Show("MaSP: " + maSP); // debug

            // Load công thức
            LoadCongThuc();
        }

        private void dtgvCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dtgvCongThuc.CurrentRow == null) return;

            string maNL = dtgvCongThuc.CurrentRow.Cells["MaNL"].Value.ToString();
            decimal soLuong = Convert.ToDecimal(dtgvCongThuc.CurrentRow.Cells["SoLuong"].Value);

            cboNguyenLieu.SelectedValue = maNL;
            txtSoLuong.Text = soLuong.ToString();
        }

        private void txtTimNL_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimNL.Text.ToLower();

            cboNguyenLieu.DataSource = context.NguyenLieu
                .Where(nl => nl.TenNL.ToLower().Contains(keyword))
                .Select(nl => new
                {
                    nl.MaNL,
                    nl.TenNL
                })
                .ToList();
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước!");
                return;
            }

            if (cboNguyenLieu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu!");
                return;
            }

            decimal soLuong;

            if (!decimal.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            string maNL = cboNguyenLieu.SelectedValue.ToString();

            // AddOrUpdate
            var ct = context.CongThuc
                .FirstOrDefault(x => x.MaSP == maSP && x.MaNL == maNL);

            if (ct != null)
            {
                // UPDATE
                ct.SoLuong = soLuong;
            }
            else
            {
                // INSERT
                CongThuc newCT = new CongThuc
                {
                    MaSP = maSP,
                    MaNL = maNL,
                    SoLuong = soLuong
                };

                context.CongThuc.Add(newCT);
            }

            context.SaveChanges();

            LoadCongThuc();

            MessageBox.Show("Lưu công thức thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dtgvCongThuc.CurrentRow == null) return;

            string maNL = dtgvCongThuc.CurrentRow.Cells["MaNL"].Value.ToString();

            var ct = context.CongThuc
                .FirstOrDefault(x => x.MaSP == maSP && x.MaNL == maNL);

            if (ct != null)
            {
                context.CongThuc.Remove(ct);
                context.SaveChanges();
            }

            LoadCongThuc();
        }
    }
}
