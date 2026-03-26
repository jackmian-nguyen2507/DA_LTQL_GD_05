using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
            SetupLayout();
        }


        // =============================
        // 1. Setup Layout (Fullscreen)
        // =============================
        private void SetupLayout()
        {
            this.WindowState = FormWindowState.Maximized;

            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;

            panel1.Dock = DockStyle.Top;
            panel1.Height = 80;

            dataGridView1.Dock = DockStyle.Fill;

            // Tô màu đều 2 panel
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            panel1.BackColor = Color.FromArgb(246, 236, 210);

            // Tự căn label + icon trong header
            pictureBox1.Left = (pnlHeader.Width / 2) - 150;
            pictureBox1.Top = 18;

            label1.Left = pictureBox1.Right + 15;
            label1.Top = 20;

            pnlHeader.Resize += (s, e) =>
            {
                pictureBox1.Left = (pnlHeader.Width / 2) - 150;
                label1.Left = pictureBox1.Right + 15;
            };
        }

        // =============================
        // 2. Load dữ liệu từ BUS
        // =============================
        
    }
}
