namespace QuanLyQuanCaPhe.Forms
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            pnlControl = new Panel();
            btnQuayLai = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTaiLai = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            dtgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiemTichLuy = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1785, 80);
            pnlHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(584, 21);
            label1.Name = "label1";
            label1.Size = new Size(261, 30);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnQuayLai);
            pnlControl.Controls.Add(btnXuat);
            pnlControl.Controls.Add(btnNhap);
            pnlControl.Controls.Add(btnXoa);
            pnlControl.Controls.Add(btnSua);
            pnlControl.Controls.Add(btnThem);
            pnlControl.Controls.Add(btnTaiLai);
            pnlControl.Controls.Add(txtTimKiem);
            pnlControl.Controls.Add(label2);
            pnlControl.Location = new Point(12, 87);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(1773, 80);
            pnlControl.TabIndex = 7;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.FromArgb(224, 224, 224);
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1637, 13);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(133, 45);
            btnQuayLai.TabIndex = 7;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(224, 224, 224);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuat.ForeColor = Color.FromArgb(192, 64, 0);
            btnXuat.Location = new Point(1421, 11);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(133, 47);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuatKH_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(224, 224, 224);
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhap.ForeColor = Color.Green;
            btnNhap.Location = new Point(1226, 11);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(133, 47);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhapKH_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(1052, 13);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 47);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(224, 224, 224);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(883, 17);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 45);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(224, 224, 224);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.DarkGreen;
            btnThem.Location = new Point(717, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 45);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.FromArgb(224, 224, 224);
            btnTaiLai.FlatAppearance.BorderSize = 0;
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.ForeColor = Color.Maroon;
            btnTaiLai.Location = new Point(549, 20);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(133, 44);
            btnTaiLai.TabIndex = 11;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(182, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(319, 29);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 5;
            label2.Text = "Tìm khách hàng";
            // 
            // dtgvKhachHang
            // 
            dtgvKhachHang.AllowUserToAddRows = false;
            dtgvKhachHang.AllowUserToDeleteRows = false;
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SDT, DiemTichLuy });
            dtgvKhachHang.Location = new Point(13, 184);
            dtgvKhachHang.MultiSelect = false;
            dtgvKhachHang.Name = "dtgvKhachHang";
            dtgvKhachHang.RowHeadersWidth = 51;
            dtgvKhachHang.RowTemplate.Height = 24;
            dtgvKhachHang.Size = new Size(1757, 430);
            dtgvKhachHang.TabIndex = 8;
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "Mã khách hàng";
            MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.Name = "TenKH";
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.Name = "SDT";
            // 
            // DiemTichLuy
            // 
            DiemTichLuy.DataPropertyName = "DiemTichLuy";
            DiemTichLuy.HeaderText = "Điểm tích lũy";
            DiemTichLuy.Name = "DiemTichLuy";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 236, 210);
            ClientSize = new Size(1782, 623);
            Controls.Add(dtgvKhachHang);
            Controls.Add(pnlControl);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmKhachHang";
            Text = "Quản lý khách hàng ";
            Load += frmKhachHang_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKhachHang).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiemTichLuy;
        private Button btnXuat;
        private Button btnNhap;
    }
}

