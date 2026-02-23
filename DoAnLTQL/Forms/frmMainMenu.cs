using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Forms;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmMainMenu : Form
    {
        private QLCPDbContext _context = new QLCPDbContext();

        private int tableButtonWidth = 120;
        private int tableButtonHeight = 120;

        public frmMainMenu()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cà phê - Sơ đồ bàn";

            SetupLayout();

            tabFilter.SelectedIndexChanged += (s, e) => LoadAllTabs();

            LoadAllTabs();
        }

        // ================= LOAD TAB =================
        private void LoadAllTabs()
        {
            var tableList = _context.Ban.ToList();

            LoadTableToPanel(tableList, flpAll);

            var empty = tableList.Where(t => t.TrangThai == "Trống").ToList();
            LoadTableToPanel(empty, flpEmpty);

            var busy = tableList.Where(t => t.TrangThai != "Trống").ToList();
            LoadTableToPanel(busy, flpBusy);
        }

        // ================= LOAD BUTTON =================
        private void LoadTableToPanel(List<Ban> list, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();

            foreach (var table in list)
            {
                Button btn = new Button();
                btn.Width = tableButtonWidth;
                btn.Height = tableButtonHeight;
                btn.Margin = new Padding(10);

                btn.Text = table.TenBan + "\n(" + table.TrangThai + ")";
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.BottomCenter;

                btn.ImageList = imageList1;
                btn.ImageIndex = table.TrangThai == "Trống" ? 0 : 1;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.BackColor = Color.White;
                btn.Tag = table;

                btn.Click += Btn_Click;

                flp.Controls.Add(btn);
            }
        }

        // ================= CLICK BÀN =================
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Ban table = btn.Tag as Ban;

            // GỌI POS MỚI (EF version)
            frmPOS f = new frmPOS(table.ID, table.TenBan, table.TrangThai);

            this.Hide();
            f.ShowDialog();
            this.Show();

            // Reload lại trạng thái bàn
            LoadAllTabs();
        }

        // ================= LAYOUT =================
        private void SetupLayout()
        {
            var pnlHeader = this.Controls["pnlHeader"] as Panel;
            if (pnlHeader != null)
            {
                pnlHeader.Dock = DockStyle.Top;
                pnlHeader.Height = 60;

                foreach (Control c in pnlHeader.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.Dock = DockStyle.Fill;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.AutoSize = false;
                    }
                }
            }

            var pnlMenu = this.Controls["pnlMenu"] as Panel;
            if (pnlMenu != null)
            {
                pnlMenu.Dock = DockStyle.Top;
                pnlMenu.Height = 35;

                foreach (Control c in pnlMenu.Controls)
                {
                    if (c is MenuStrip ms)
                    {
                        ms.Dock = DockStyle.Fill;
                    }
                }
            }

            var pnlContent = this.Controls["pnlContent"] as Panel;
            if (pnlContent != null)
            {
                pnlContent.Dock = DockStyle.Fill;

                var tab = pnlContent.Controls["tabFilter"] as TabControl;
                if (tab != null)
                    tab.Dock = DockStyle.Fill;
            }
        }

        // ================= MENU =================
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            new frmSanPham().ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmHoaDon().ShowDialog();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmNguyenLieu().ShowDialog();
        }

        private void côngThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCongThuc().ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmKhachHang().ShowDialog();
        }

        private void doanhThToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmThongKe().ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmThongTinPhanMem().ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}