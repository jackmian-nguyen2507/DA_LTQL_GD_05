namespace QuanLyQuanCaPhe.Forms
{
    partial class frmDieuChinhNguyenLieu
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
            lblNguyenLieu = new Label();
            grbLoaiDieuChinh = new GroupBox();
            radXuat = new RadioButton();
            radNhap = new RadioButton();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnLuu = new Button();
            btnDong = new Button();
            lblTenNguyenLieu = new Label();
            lblSL = new Label();
            lblSoLuongTon = new Label();
            grbLoaiDieuChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // lblNguyenLieu
            // 
            lblNguyenLieu.AutoSize = true;
            lblNguyenLieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNguyenLieu.Location = new Point(24, 23);
            lblNguyenLieu.Margin = new Padding(5, 0, 5, 0);
            lblNguyenLieu.Name = "lblNguyenLieu";
            lblNguyenLieu.Size = new Size(123, 25);
            lblNguyenLieu.TabIndex = 0;
            lblNguyenLieu.Text = "Nguyên liệu :";
            // 
            // grbLoaiDieuChinh
            // 
            grbLoaiDieuChinh.Controls.Add(radXuat);
            grbLoaiDieuChinh.Controls.Add(radNhap);
            grbLoaiDieuChinh.Location = new Point(24, 121);
            grbLoaiDieuChinh.Name = "grbLoaiDieuChinh";
            grbLoaiDieuChinh.Size = new Size(374, 128);
            grbLoaiDieuChinh.TabIndex = 2;
            grbLoaiDieuChinh.TabStop = false;
            grbLoaiDieuChinh.Text = "Loại điều chỉnh";
            // 
            // radXuat
            // 
            radXuat.AutoSize = true;
            radXuat.Location = new Point(31, 77);
            radXuat.Name = "radXuat";
            radXuat.Size = new Size(104, 29);
            radXuat.TabIndex = 1;
            radXuat.TabStop = true;
            radXuat.Text = "Xuất kho";
            radXuat.UseVisualStyleBackColor = true;
            // 
            // radNhap
            // 
            radNhap.AutoSize = true;
            radNhap.Location = new Point(31, 32);
            radNhap.Name = "radNhap";
            radNhap.Size = new Size(112, 29);
            radNhap.TabIndex = 0;
            radNhap.TabStop = true;
            radNhap.Text = "Nhập kho";
            radNhap.UseVisualStyleBackColor = true;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(24, 274);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(96, 25);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số lượng :";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(142, 272);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(96, 33);
            numSoLuong.TabIndex = 4;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(24, 336);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(86, 25);
            lblGhiChu.TabIndex = 3;
            lblGhiChu.Text = "Ghi chú :";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(138, 336);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(260, 33);
            txtGhiChu.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(55, 422);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(108, 36);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(253, 422);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(108, 36);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // lblTenNguyenLieu
            // 
            lblTenNguyenLieu.AutoSize = true;
            lblTenNguyenLieu.Location = new Point(165, 23);
            lblTenNguyenLieu.Name = "lblTenNguyenLieu";
            lblTenNguyenLieu.Size = new Size(0, 25);
            lblTenNguyenLieu.TabIndex = 7;
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Location = new Point(24, 74);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(129, 25);
            lblSL.TabIndex = 8;
            lblSL.Text = "Số lượng tồn :";
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.AutoSize = true;
            lblSoLuongTon.Location = new Point(165, 74);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(0, 25);
            lblSoLuongTon.TabIndex = 9;
            // 
            // frmDieuChinhNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 482);
            Controls.Add(lblSoLuongTon);
            Controls.Add(lblSL);
            Controls.Add(lblTenNguyenLieu);
            Controls.Add(btnDong);
            Controls.Add(btnLuu);
            Controls.Add(txtGhiChu);
            Controls.Add(numSoLuong);
            Controls.Add(lblGhiChu);
            Controls.Add(lblSoLuong);
            Controls.Add(grbLoaiDieuChinh);
            Controls.Add(lblNguyenLieu);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "frmDieuChinhNguyenLieu";
            Text = "frmDieuChinhNguyenLieu";
            Load += frmDieuChinhNguyenLieu_Load;
            grbLoaiDieuChinh.ResumeLayout(false);
            grbLoaiDieuChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNguyenLieu;
        private GroupBox grbLoaiDieuChinh;
        private RadioButton radXuat;
        private RadioButton radNhap;
        private Label lblSoLuong;
        private NumericUpDown numSoLuong;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Button btnLuu;
        private Button btnDong;
        private Label lblTenNguyenLieu;
        private Label lblSL;
        private Label lblSoLuongTon;
    }
}