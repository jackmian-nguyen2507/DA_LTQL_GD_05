namespace QuanLyQuanCaPhe.Forms
{
    partial class frmCongThuc
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
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pnlMenu = new Panel();
            btnQuayLai = new Button();
            pnlSanPham = new Panel();
            dtgvSanPham = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            TenLoaiSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            lblChonSP = new Label();
            btnThemCapNhat = new Button();
            pnlCongThuc = new Panel();
            dtgvCongThuc = new DataGridView();
            btnXoa = new Button();
            cboNguyenLieu = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            txtTimNL = new TextBox();
            label4 = new Label();
            lblTieuDeCT = new Label();
            Ma_SP = new DataGridViewTextBoxColumn();
            MaNL = new DataGridViewTextBoxColumn();
            TenNguyenLieu = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMenu.SuspendLayout();
            pnlSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSanPham).BeginInit();
            pnlCongThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCongThuc).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1399, 77);
            pnlHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(449, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(495, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(367, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ CÔNG THỨC SẢN PHẨM";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(246, 236, 210);
            pnlMenu.Controls.Add(btnQuayLai);
            pnlMenu.Location = new Point(13, 84);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1374, 62);
            pnlMenu.TabIndex = 2;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Right;
            btnQuayLai.BackColor = Color.FromArgb(224, 224, 224);
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1222, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(152, 45);
            btnQuayLai.TabIndex = 8;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // pnlSanPham
            // 
            pnlSanPham.BackColor = Color.White;
            pnlSanPham.Controls.Add(dtgvSanPham);
            pnlSanPham.Controls.Add(lblChonSP);
            pnlSanPham.ForeColor = SystemColors.ControlText;
            pnlSanPham.Location = new Point(13, 168);
            pnlSanPham.Name = "pnlSanPham";
            pnlSanPham.Size = new Size(496, 517);
            pnlSanPham.TabIndex = 4;
            // 
            // dtgvSanPham
            // 
            dtgvSanPham.AllowUserToAddRows = false;
            dtgvSanPham.AllowUserToDeleteRows = false;
            dtgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, TenLoaiSP, DonGia, TrangThai });
            dtgvSanPham.Location = new Point(15, 47);
            dtgvSanPham.MultiSelect = false;
            dtgvSanPham.Name = "dtgvSanPham";
            dtgvSanPham.RowHeadersWidth = 51;
            dtgvSanPham.RowTemplate.Height = 24;
            dtgvSanPham.Size = new Size(461, 457);
            dtgvSanPham.TabIndex = 0;
            dtgvSanPham.CellClick += dtgvSanPham_CellClick;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.Name = "TenSP";
            // 
            // TenLoaiSP
            // 
            TenLoaiSP.DataPropertyName = "TenLoaiSP";
            TenLoaiSP.HeaderText = "Loại sản phẩm";
            TenLoaiSP.Name = "TenLoaiSP";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.Name = "TrangThai";
            // 
            // lblChonSP
            // 
            lblChonSP.AutoSize = true;
            lblChonSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChonSP.Location = new Point(24, 12);
            lblChonSP.Name = "lblChonSP";
            lblChonSP.Size = new Size(345, 25);
            lblChonSP.TabIndex = 1;
            lblChonSP.Text = "Chọn sản phẩm để xem / sửa công thức";
            // 
            // btnThemCapNhat
            // 
            btnThemCapNhat.BackColor = Color.FromArgb(224, 224, 224);
            btnThemCapNhat.FlatStyle = FlatStyle.Popup;
            btnThemCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemCapNhat.ForeColor = Color.ForestGreen;
            btnThemCapNhat.Location = new Point(553, 455);
            btnThemCapNhat.Name = "btnThemCapNhat";
            btnThemCapNhat.Size = new Size(174, 49);
            btnThemCapNhat.TabIndex = 9;
            btnThemCapNhat.Text = "Thêm/Cập nhật";
            btnThemCapNhat.UseVisualStyleBackColor = false;
            btnThemCapNhat.Click += btnThemCapNhat_Click;
            // 
            // pnlCongThuc
            // 
            pnlCongThuc.BackColor = Color.FromArgb(246, 236, 210);
            pnlCongThuc.Controls.Add(dtgvCongThuc);
            pnlCongThuc.Controls.Add(btnXoa);
            pnlCongThuc.Controls.Add(btnThemCapNhat);
            pnlCongThuc.Controls.Add(cboNguyenLieu);
            pnlCongThuc.Controls.Add(lblSoLuong);
            pnlCongThuc.Controls.Add(txtSoLuong);
            pnlCongThuc.Controls.Add(txtTimNL);
            pnlCongThuc.Controls.Add(label4);
            pnlCongThuc.Controls.Add(lblTieuDeCT);
            pnlCongThuc.Location = new Point(547, 168);
            pnlCongThuc.Name = "pnlCongThuc";
            pnlCongThuc.Size = new Size(840, 517);
            pnlCongThuc.TabIndex = 4;
            // 
            // dtgvCongThuc
            // 
            dtgvCongThuc.AllowUserToAddRows = false;
            dtgvCongThuc.AllowUserToDeleteRows = false;
            dtgvCongThuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCongThuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCongThuc.Columns.AddRange(new DataGridViewColumn[] { Ma_SP, MaNL, TenNguyenLieu, SoLuong, DonVi });
            dtgvCongThuc.Location = new Point(13, 47);
            dtgvCongThuc.MultiSelect = false;
            dtgvCongThuc.Name = "dtgvCongThuc";
            dtgvCongThuc.RowHeadersWidth = 51;
            dtgvCongThuc.RowTemplate.Height = 24;
            dtgvCongThuc.Size = new Size(809, 337);
            dtgvCongThuc.TabIndex = 11;
            dtgvCongThuc.CellClick += dtgvCongThuc_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(733, 455);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 49);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.BackColor = Color.Silver;
            cboNguyenLieu.FlatStyle = FlatStyle.Flat;
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(13, 470);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(419, 29);
            cboNguyenLieu.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(441, 422);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(87, 25);
            lblSoLuong.TabIndex = 6;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(447, 470);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 29);
            txtSoLuong.TabIndex = 5;
            // 
            // txtTimNL
            // 
            txtTimNL.Location = new Point(13, 421);
            txtTimNL.Name = "txtTimNL";
            txtTimNL.Size = new Size(419, 29);
            txtTimNL.TabIndex = 3;
            txtTimNL.TextChanged += txtTimNL_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 387);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 2;
            label4.Text = "Tìm / Chọn nguyên liệu";
            // 
            // lblTieuDeCT
            // 
            lblTieuDeCT.AutoSize = true;
            lblTieuDeCT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDeCT.Location = new Point(271, 12);
            lblTieuDeCT.Name = "lblTieuDeCT";
            lblTieuDeCT.Size = new Size(243, 25);
            lblTieuDeCT.TabIndex = 1;
            lblTieuDeCT.Text = "Công thức cho [Chưa chọn]";
            // 
            // Ma_SP
            // 
            Ma_SP.DataPropertyName = "MaSP";
            Ma_SP.HeaderText = "Mã sản phẩm";
            Ma_SP.Name = "Ma_SP";
            // 
            // MaNL
            // 
            MaNL.DataPropertyName = "MaNL";
            MaNL.HeaderText = "Mã nguyên liệu";
            MaNL.Name = "MaNL";
            // 
            // TenNguyenLieu
            // 
            TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            TenNguyenLieu.Name = "TenNguyenLieu";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.Name = "DonVi";
            // 
            // frmCongThuc
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 236, 210);
            ClientSize = new Size(1399, 697);
            Controls.Add(pnlCongThuc);
            Controls.Add(pnlSanPham);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCongThuc";
            Text = "Quản lý công thức ";
            Load += frmCongThuc_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlSanPham.ResumeLayout(false);
            pnlSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSanPham).EndInit();
            pnlCongThuc.ResumeLayout(false);
            pnlCongThuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCongThuc).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel pnlSanPham;
        private System.Windows.Forms.Label lblChonSP;
        private System.Windows.Forms.Button btnThemCapNhat;
        private System.Windows.Forms.Panel pnlCongThuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboNguyenLieu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTimNL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTieuDeCT;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.DataGridView dtgvCongThuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn TenLoaiSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn Ma_SP;
        private DataGridViewTextBoxColumn MaNL;
        private DataGridViewTextBoxColumn TenNguyenLieu;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
    }
}

