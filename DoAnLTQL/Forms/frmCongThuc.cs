using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmCongThuc : Form
    {
       
        public frmCongThuc()
        {
            InitializeComponent();
            SetupLayout();
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
            cboTimNL.Parent = pnlInput;
            cboTimNL.Left = left;
            cboTimNL.Top = txtTimNL.Bottom + 5;
            cboTimNL.Width = 350;

            // Label số lượng
            lblSoLuong.Parent = pnlInput;
            lblSoLuong.Left = txtTimNL.Right + 40;
            lblSoLuong.Top = txtTimNL.Top + 5;

            // txt số lượng
            txtSoLuong.Parent = pnlInput;
            txtSoLuong.Left = lblSoLuong.Left;
            txtSoLuong.Top = cboTimNL.Top;
            txtSoLuong.Width = 120;

            // Nút thêm
            btnThem.Parent = pnlInput;
            btnThem.Left = txtSoLuong.Right + 30;
            btnThem.Top = txtSoLuong.Top - 5;
            btnThem.Width = 160;

            // Nút xóa
            btnXoa.Parent = pnlInput;
            btnXoa.Left = btnThem.Right + 20;
            btnXoa.Top = btnThem.Top;
            btnXoa.Width = 120;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
