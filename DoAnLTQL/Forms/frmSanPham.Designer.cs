namespace QuanLyQuanCaPhe.Forms
{
    partial class frmSanPham
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
            dtgvSanPham = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TENSP = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlControl = new Panel();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTaiLai = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSanPham).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvSanPham
            // 
            dtgvSanPham.AllowUserToAddRows = false;
            dtgvSanPham.AllowUserToDeleteRows = false;
            dtgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSP, TENSP, TenLoai, DonGia, TrangThai, HinhAnh });
            dtgvSanPham.Location = new Point(0, 179);
            dtgvSanPham.Margin = new Padding(2);
            dtgvSanPham.MultiSelect = false;
            dtgvSanPham.Name = "dtgvSanPham";
            dtgvSanPham.RowHeadersWidth = 51;
            dtgvSanPham.RowTemplate.Height = 24;
            dtgvSanPham.Size = new Size(1800, 428);
            dtgvSanPham.TabIndex = 0;
            dtgvSanPham.CellFormatting += dtgvSanPham_CellFormatting;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.Name = "MaSP";
            // 
            // TENSP
            // 
            TENSP.DataPropertyName = "TENSP";
            TENSP.HeaderText = "Tên sản phẩm";
            TENSP.Name = "TENSP";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại sản phẩm";
            TenLoai.Name = "TenLoai";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Giá bán";
            DonGia.Name = "DonGia";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.Name = "TrangThai";
            // 
            // HinhAnh
            // 
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.Name = "HinhAnh";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Location = new Point(0, 2);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1800, 67);
            pnlHeader.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(328, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(376, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(445, 37);
            label2.TabIndex = 0;
            label2.Text = "QUẢN LÝ SẢN PHẨM / ĐỒ UỐNG ";
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
            pnlControl.Controls.Add(label1);
            pnlControl.Location = new Point(0, 73);
            pnlControl.Margin = new Padding(2);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(1800, 102);
            pnlControl.TabIndex = 7;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuayLai.BackColor = Color.FromArgb(224, 224, 224);
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1667, 17);
            btnQuayLai.Margin = new Padding(2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(117, 43);
            btnQuayLai.TabIndex = 7;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(826, 21);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 44);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(224, 224, 224);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(677, 21);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 43);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(224, 224, 224);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.DarkGreen;
            btnThem.Location = new Point(531, 21);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 43);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTaiLai.BackColor = Color.FromArgb(224, 224, 224);
            btnTaiLai.FlatAppearance.BorderSize = 0;
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.ForeColor = Color.Maroon;
            btnTaiLai.Location = new Point(384, 23);
            btnTaiLai.Margin = new Padding(2);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(117, 42);
            btnTaiLai.TabIndex = 11;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(79, 31);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(213, 32);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 5;
            label1.Text = "Tìm:";
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhap.BackColor = Color.FromArgb(224, 224, 224);
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhap.ForeColor = Color.FromArgb(0, 192, 0);
            btnNhap.Location = new Point(975, 21);
            btnNhap.Margin = new Padding(2);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(117, 44);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuat.BackColor = Color.FromArgb(224, 224, 224);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuat.ForeColor = Color.FromArgb(192, 64, 0);
            btnXuat.Location = new Point(1125, 21);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(117, 44);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 199, 189);
            ClientSize = new Size(1684, 613);
            Controls.Add(pnlControl);
            Controls.Add(pnlHeader);
            Controls.Add(dtgvSanPham);
            Margin = new Padding(2);
            Name = "frmSanPham";
            Text = "Danh sách sản phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSanPham).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TENSP;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewImageColumn HinhAnh;
        private Button btnXuat;
        private Button btnNhap;
    }
}