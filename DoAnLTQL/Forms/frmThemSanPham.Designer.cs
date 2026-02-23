namespace QuanLyQuanCaPhe.Forms
{
    partial class frmThemSanPham
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
            txtMaSP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTenSP = new TextBox();
            cboLoaiSP = new ComboBox();
            label3 = new Label();
            numDonGia = new NumericUpDown();
            label4 = new Label();
            cboTrangThai = new ComboBox();
            label5 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            picHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(160, 45);
            txtMaSP.Margin = new Padding(4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(253, 26);
            txtMaSP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(160, 104);
            txtTenSP.Margin = new Padding(4);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(253, 26);
            txtTenSP.TabIndex = 1;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(160, 163);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(250, 28);
            cboLoaiSP.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 1;
            label3.Text = "Loại sản phẩm";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(160, 231);
            numDonGia.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(120, 26);
            numDonGia.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 237);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 1;
            label4.Text = "Đơn giá";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(163, 300);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(250, 28);
            cboTrangThai.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 300);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 1;
            label5.Text = "Trạng thái";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.ForestGreen;
            btnLuu.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(66, 395);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(124, 44);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(381, 395);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(124, 44);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(450, 17);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(150, 174);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 7;
            picHinhAnh.TabStop = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnDoiAnh.ForeColor = Color.Silver;
            btnDoiAnh.Location = new Point(476, 222);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(107, 35);
            btnDoiAnh.TabIndex = 8;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // frmThemSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 455);
            Controls.Add(btnDoiAnh);
            Controls.Add(picHinhAnh);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(numDonGia);
            Controls.Add(cboTrangThai);
            Controls.Add(cboLoaiSP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmThemSanPham";
            Text = "frmSanPhamChiTiet";
            Load += frmThemSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
    }
}