using System.Windows.Forms;

namespace QuanLyQuanCaPhe.Forms
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            pnlMenu = new Panel();
            btnTaiLai = new Button();
            btnXoa = new Button();
            btnInPDF = new Button();
            btnXuat = new Button();
            btnQuayLai = new Button();
            dtgvHoaDon = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewButtonColumn();
            btnNhap = new Button();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1407, 80);
            pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(584, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(246, 236, 210);
            pnlMenu.Controls.Add(btnTaiLai);
            pnlMenu.Controls.Add(btnNhap);
            pnlMenu.Controls.Add(btnXoa);
            pnlMenu.Controls.Add(btnInPDF);
            pnlMenu.Controls.Add(btnXuat);
            pnlMenu.Controls.Add(btnQuayLai);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 80);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1407, 100);
            pnlMenu.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTaiLai.BackColor = Color.FromArgb(224, 224, 224);
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTaiLai.ForeColor = Color.Maroon;
            btnTaiLai.Location = new Point(38, 22);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(175, 44);
            btnTaiLai.TabIndex = 0;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(454, 23);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(175, 44);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnInPDF
            // 
            btnInPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInPDF.BackColor = Color.FromArgb(224, 224, 224);
            btnInPDF.FlatStyle = FlatStyle.Flat;
            btnInPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInPDF.ForeColor = Color.FromArgb(255, 128, 0);
            btnInPDF.Location = new Point(250, 23);
            btnInPDF.Name = "btnInPDF";
            btnInPDF.Size = new Size(175, 44);
            btnInPDF.TabIndex = 2;
            btnInPDF.Text = "Xuất PDF";
            btnInPDF.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuat.BackColor = Color.FromArgb(224, 224, 224);
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXuat.ForeColor = Color.FromArgb(192, 64, 0);
            btnXuat.Location = new Point(885, 22);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(175, 45);
            btnXuat.TabIndex = 3;
            btnXuat.Text = "Xuất excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuayLai.BackColor = Color.FromArgb(224, 224, 224);
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnQuayLai.Location = new Point(1245, 23);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(127, 46);
            btnQuayLai.TabIndex = 6;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // dtgvHoaDon
            // 
            dtgvHoaDon.AllowUserToAddRows = false;
            dtgvHoaDon.AllowUserToDeleteRows = false;
            dtgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHD, NgayLap, TenKH, TenNV, TenBan, TongTien, TrangThai, XemChiTiet });
            dtgvHoaDon.Dock = DockStyle.Fill;
            dtgvHoaDon.Location = new Point(0, 180);
            dtgvHoaDon.MultiSelect = false;
            dtgvHoaDon.Name = "dtgvHoaDon";
            dtgvHoaDon.Size = new Size(1407, 454);
            dtgvHoaDon.TabIndex = 0;
            dtgvHoaDon.CellContentClick += dtgvHoaDon_CellContentClick;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã hóa đơn";
            MaHD.Name = "MaHD";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.Name = "NgayLap";
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.Name = "TenKH";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên nhân viên";
            TenNV.Name = "TenNV";
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên bàn";
            TenBan.Name = "TenBan";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.Name = "TrangThai";
            // 
            // XemChiTiet
            // 
            XemChiTiet.HeaderText = "Chi Tiết";
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.Text = "Xem";
            XemChiTiet.UseColumnTextForButtonValue = true;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhap.BackColor = Color.FromArgb(224, 224, 224);
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNhap.ForeColor = Color.Green;
            btnNhap.Location = new Point(660, 25);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(175, 44);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 634);
            Controls.Add(dtgvHoaDon);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 12F);
            Name = "frmHoaDon";
            Text = "Quản lý hóa đơn";
            Load += frmHoaDon_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInPDF;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private Button btnXuat;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn TenBan;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewButtonColumn XemChiTiet;
        private Button btnNhap;
    }
}
