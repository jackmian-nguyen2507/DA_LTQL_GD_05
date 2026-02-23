namespace QuanLyQuanCaPhe.Forms
{
    partial class frmPOS
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
            pnlTitle = new Panel();
            btnquayLai = new Button();
            lblTenBan = new Label();
            pnlChonMon = new Panel();
            grbChonMon = new GroupBox();
            pnlMenuScroll = new Panel();
            tlpMenu = new TableLayoutPanel();
            pnlGioHangThanhToan = new Panel();
            grbHoaDon = new GroupBox();
            btnTamTinh = new Button();
            btnHuyBo = new Button();
            btnLuuHoaDon = new Button();
            grbDiemTichLuy = new GroupBox();
            btnChonKhach = new Button();
            lblTenKhach = new Label();
            chkSuDungDiem = new CheckBox();
            txtDiemTichLuy = new TextBox();
            grbGioHang = new GroupBox();
            txtKhachCanTra = new TextBox();
            txtDiemGiamGia = new TextBox();
            txtTongCong = new TextBox();
            lblKhachCanTra = new Label();
            lblDiem = new Label();
            lblTongCong = new Label();
            lstGioHang = new ListView();
            pnlTitle.SuspendLayout();
            pnlChonMon.SuspendLayout();
            grbChonMon.SuspendLayout();
            pnlMenuScroll.SuspendLayout();
            pnlGioHangThanhToan.SuspendLayout();
            grbHoaDon.SuspendLayout();
            grbDiemTichLuy.SuspendLayout();
            grbGioHang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(76, 54, 43);
            pnlTitle.Controls.Add(btnquayLai);
            pnlTitle.Controls.Add(lblTenBan);
            pnlTitle.Location = new Point(10, 12);
            pnlTitle.Margin = new Padding(2);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1353, 88);
            pnlTitle.TabIndex = 3;
            // 
            // btnquayLai
            // 
            btnquayLai.BackColor = Color.FromArgb(255, 224, 192);
            btnquayLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnquayLai.ForeColor = Color.Black;
            btnquayLai.Location = new Point(1188, 14);
            btnquayLai.Margin = new Padding(2);
            btnquayLai.Name = "btnquayLai";
            btnquayLai.Size = new Size(149, 58);
            btnquayLai.TabIndex = 3;
            btnquayLai.Text = "Quay Lại";
            btnquayLai.UseVisualStyleBackColor = false;
            btnquayLai.Click += btnquayLai_Click;
            // 
            // lblTenBan
            // 
            lblTenBan.AutoSize = true;
            lblTenBan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenBan.ForeColor = Color.White;
            lblTenBan.Location = new Point(500, 25);
            lblTenBan.Margin = new Padding(2, 0, 2, 0);
            lblTenBan.Name = "lblTenBan";
            lblTenBan.Size = new Size(315, 30);
            lblTenBan.TabIndex = 0;
            lblTenBan.Text = "BÁN HÀNG TẠI QUẦY ( POS )";
            // 
            // pnlChonMon
            // 
            pnlChonMon.BackColor = SystemColors.ControlLightLight;
            pnlChonMon.Controls.Add(grbChonMon);
            pnlChonMon.Location = new Point(13, 115);
            pnlChonMon.Margin = new Padding(2);
            pnlChonMon.Name = "pnlChonMon";
            pnlChonMon.Size = new Size(643, 616);
            pnlChonMon.TabIndex = 4;
            // 
            // grbChonMon
            // 
            grbChonMon.Controls.Add(pnlMenuScroll);
            grbChonMon.Dock = DockStyle.Fill;
            grbChonMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbChonMon.Location = new Point(0, 0);
            grbChonMon.Margin = new Padding(2);
            grbChonMon.Name = "grbChonMon";
            grbChonMon.Padding = new Padding(2);
            grbChonMon.Size = new Size(643, 616);
            grbChonMon.TabIndex = 0;
            grbChonMon.TabStop = false;
            grbChonMon.Text = "1. Chọn Món";
            // 
            // pnlMenuScroll
            // 
            pnlMenuScroll.AutoScroll = true;
            pnlMenuScroll.AutoSize = true;
            pnlMenuScroll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMenuScroll.Controls.Add(tlpMenu);
            pnlMenuScroll.Dock = DockStyle.Fill;
            pnlMenuScroll.Location = new Point(2, 21);
            pnlMenuScroll.Margin = new Padding(4, 3, 4, 3);
            pnlMenuScroll.Name = "pnlMenuScroll";
            pnlMenuScroll.Padding = new Padding(0, 0, 23, 0);
            pnlMenuScroll.Size = new Size(639, 593);
            pnlMenuScroll.TabIndex = 0;
            // 
            // tlpMenu
            // 
            tlpMenu.AutoSize = true;
            tlpMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpMenu.ColumnCount = 3;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tlpMenu.Dock = DockStyle.Top;
            tlpMenu.Location = new Point(0, 0);
            tlpMenu.Margin = new Padding(4, 3, 4, 3);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMenu.Size = new Size(616, 0);
            tlpMenu.TabIndex = 3;
            // 
            // pnlGioHangThanhToan
            // 
            pnlGioHangThanhToan.BackColor = SystemColors.ControlLightLight;
            pnlGioHangThanhToan.Controls.Add(grbHoaDon);
            pnlGioHangThanhToan.Controls.Add(grbDiemTichLuy);
            pnlGioHangThanhToan.Controls.Add(grbGioHang);
            pnlGioHangThanhToan.Location = new Point(677, 115);
            pnlGioHangThanhToan.Margin = new Padding(2);
            pnlGioHangThanhToan.Name = "pnlGioHangThanhToan";
            pnlGioHangThanhToan.Size = new Size(688, 616);
            pnlGioHangThanhToan.TabIndex = 5;
            // 
            // grbHoaDon
            // 
            grbHoaDon.Controls.Add(btnTamTinh);
            grbHoaDon.Controls.Add(btnHuyBo);
            grbHoaDon.Controls.Add(btnLuuHoaDon);
            grbHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbHoaDon.Location = new Point(21, 427);
            grbHoaDon.Margin = new Padding(2);
            grbHoaDon.Name = "grbHoaDon";
            grbHoaDon.Padding = new Padding(2);
            grbHoaDon.Size = new Size(650, 157);
            grbHoaDon.TabIndex = 1;
            grbHoaDon.TabStop = false;
            grbHoaDon.Text = "4. Hóa Đơn";
            // 
            // btnTamTinh
            // 
            btnTamTinh.BackColor = Color.FromArgb(255, 224, 192);
            btnTamTinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTamTinh.ForeColor = Color.Black;
            btnTamTinh.Location = new Point(336, 108);
            btnTamTinh.Margin = new Padding(2);
            btnTamTinh.Name = "btnTamTinh";
            btnTamTinh.Size = new Size(296, 43);
            btnTamTinh.TabIndex = 2;
            btnTamTinh.Text = "Tạm Tính";
            btnTamTinh.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 224, 192);
            btnHuyBo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = Color.Red;
            btnHuyBo.Location = new Point(16, 108);
            btnHuyBo.Margin = new Padding(2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(298, 43);
            btnHuyBo.TabIndex = 1;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.BackColor = Color.FromArgb(255, 224, 192);
            btnLuuHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuHoaDon.ForeColor = Color.FromArgb(0, 192, 0);
            btnLuuHoaDon.Location = new Point(5, 29);
            btnLuuHoaDon.Margin = new Padding(2);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(617, 75);
            btnLuuHoaDon.TabIndex = 0;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn\r\n";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // grbDiemTichLuy
            // 
            grbDiemTichLuy.Controls.Add(btnChonKhach);
            grbDiemTichLuy.Controls.Add(lblTenKhach);
            grbDiemTichLuy.Controls.Add(chkSuDungDiem);
            grbDiemTichLuy.Controls.Add(txtDiemTichLuy);
            grbDiemTichLuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDiemTichLuy.Location = new Point(21, 294);
            grbDiemTichLuy.Margin = new Padding(2);
            grbDiemTichLuy.Name = "grbDiemTichLuy";
            grbDiemTichLuy.Padding = new Padding(2);
            grbDiemTichLuy.Size = new Size(650, 122);
            grbDiemTichLuy.TabIndex = 1;
            grbDiemTichLuy.TabStop = false;
            grbDiemTichLuy.Text = "3. Điểm Tích Lũy";
            // 
            // btnChonKhach
            // 
            btnChonKhach.BackColor = Color.FromArgb(255, 224, 192);
            btnChonKhach.Location = new Point(8, 22);
            btnChonKhach.Margin = new Padding(4, 3, 4, 3);
            btnChonKhach.Name = "btnChonKhach";
            btnChonKhach.Size = new Size(119, 32);
            btnChonKhach.TabIndex = 7;
            btnChonKhach.Text = "Chọn khách";
            btnChonKhach.UseVisualStyleBackColor = false;
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTenKhach.Location = new Point(22, 58);
            lblTenKhach.Margin = new Padding(2, 0, 2, 0);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(84, 13);
            lblTenKhach.TabIndex = 6;
            lblTenKhach.Text = "Khách: [Vãn Lai]";
            // 
            // chkSuDungDiem
            // 
            chkSuDungDiem.AutoSize = true;
            chkSuDungDiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSuDungDiem.Location = new Point(245, 84);
            chkSuDungDiem.Margin = new Padding(2);
            chkSuDungDiem.Name = "chkSuDungDiem";
            chkSuDungDiem.Size = new Size(102, 19);
            chkSuDungDiem.TabIndex = 1;
            chkSuDungDiem.Text = "Sử Dụng Điểm";
            chkSuDungDiem.UseVisualStyleBackColor = true;
            chkSuDungDiem.CheckedChanged += chkSuDungDiem_CheckedChanged;
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemTichLuy.Location = new Point(16, 82);
            txtDiemTichLuy.Margin = new Padding(2);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.Size = new Size(210, 21);
            txtDiemTichLuy.TabIndex = 0;
            // 
            // grbGioHang
            // 
            grbGioHang.Controls.Add(txtKhachCanTra);
            grbGioHang.Controls.Add(txtDiemGiamGia);
            grbGioHang.Controls.Add(txtTongCong);
            grbGioHang.Controls.Add(lblKhachCanTra);
            grbGioHang.Controls.Add(lblDiem);
            grbGioHang.Controls.Add(lblTongCong);
            grbGioHang.Controls.Add(lstGioHang);
            grbGioHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbGioHang.Location = new Point(15, 21);
            grbGioHang.Margin = new Padding(2);
            grbGioHang.Name = "grbGioHang";
            grbGioHang.Padding = new Padding(2);
            grbGioHang.Size = new Size(656, 268);
            grbGioHang.TabIndex = 0;
            grbGioHang.TabStop = false;
            grbGioHang.Text = "2. Giỏ Hàng";
            // 
            // txtKhachCanTra
            // 
            txtKhachCanTra.Enabled = false;
            txtKhachCanTra.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhachCanTra.Location = new Point(317, 230);
            txtKhachCanTra.Margin = new Padding(2);
            txtKhachCanTra.Name = "txtKhachCanTra";
            txtKhachCanTra.Size = new Size(322, 21);
            txtKhachCanTra.TabIndex = 5;
            // 
            // txtDiemGiamGia
            // 
            txtDiemGiamGia.Enabled = false;
            txtDiemGiamGia.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemGiamGia.Location = new Point(317, 192);
            txtDiemGiamGia.Margin = new Padding(2);
            txtDiemGiamGia.Name = "txtDiemGiamGia";
            txtDiemGiamGia.Size = new Size(322, 21);
            txtDiemGiamGia.TabIndex = 4;
            // 
            // txtTongCong
            // 
            txtTongCong.Enabled = false;
            txtTongCong.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongCong.Location = new Point(317, 162);
            txtTongCong.Margin = new Padding(2);
            txtTongCong.Name = "txtTongCong";
            txtTongCong.Size = new Size(322, 21);
            txtTongCong.TabIndex = 1;
            // 
            // lblKhachCanTra
            // 
            lblKhachCanTra.AutoSize = true;
            lblKhachCanTra.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKhachCanTra.ForeColor = Color.Red;
            lblKhachCanTra.Location = new Point(5, 212);
            lblKhachCanTra.Margin = new Padding(2, 0, 2, 0);
            lblKhachCanTra.Name = "lblKhachCanTra";
            lblKhachCanTra.Size = new Size(204, 37);
            lblKhachCanTra.TabIndex = 3;
            lblKhachCanTra.Text = "Khách Cần Trả:";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiem.Location = new Point(9, 190);
            lblDiem.Margin = new Padding(2, 0, 2, 0);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(131, 19);
            lblDiem.TabIndex = 2;
            lblDiem.Text = "Điểm ( Giảm Giá ):";
            // 
            // lblTongCong
            // 
            lblTongCong.AutoSize = true;
            lblTongCong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongCong.Location = new Point(9, 160);
            lblTongCong.Margin = new Padding(2, 0, 2, 0);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(84, 19);
            lblTongCong.TabIndex = 1;
            lblTongCong.Text = "Tổng cộng:";
            // 
            // lstGioHang
            // 
            lstGioHang.Location = new Point(12, 28);
            lstGioHang.Margin = new Padding(2);
            lstGioHang.Name = "lstGioHang";
            lstGioHang.Size = new Size(646, 122);
            lstGioHang.TabIndex = 0;
            lstGioHang.UseCompatibleStateImageBehavior = false;
            // 
            // frmPOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1374, 743);
            Controls.Add(pnlGioHangThanhToan);
            Controls.Add(pnlChonMon);
            Controls.Add(pnlTitle);
            Margin = new Padding(2);
            Name = "frmPOS";
            Text = "Giao diện bán hàng";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlChonMon.ResumeLayout(false);
            grbChonMon.ResumeLayout(false);
            grbChonMon.PerformLayout();
            pnlMenuScroll.ResumeLayout(false);
            pnlMenuScroll.PerformLayout();
            pnlGioHangThanhToan.ResumeLayout(false);
            grbHoaDon.ResumeLayout(false);
            grbDiemTichLuy.ResumeLayout(false);
            grbDiemTichLuy.PerformLayout();
            grbGioHang.ResumeLayout(false);
            grbGioHang.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlChonMon;
        private System.Windows.Forms.GroupBox grbChonMon;
        private System.Windows.Forms.Panel pnlGioHangThanhToan;
        private System.Windows.Forms.GroupBox grbGioHang;
        private System.Windows.Forms.ListView lstGioHang;
        private System.Windows.Forms.GroupBox grbDiemTichLuy;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label lblKhachCanTra;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtKhachCanTra;
        private System.Windows.Forms.TextBox txtDiemGiamGia;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.CheckBox chkSuDungDiem;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnTamTinh;
        private System.Windows.Forms.Button btnquayLai;
        private System.Windows.Forms.Button btnChonKhach;
        private System.Windows.Forms.Panel pnlMenuScroll;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
    }
}