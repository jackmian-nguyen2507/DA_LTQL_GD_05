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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnlSanPham = new System.Windows.Forms.Panel();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.lblChonSP = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlCongThuc = new System.Windows.Forms.Panel();
            this.dtgvCongThuc = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboTimNL = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTimNL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTieuDeCT = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.pnlCongThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(46)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1399, 77);
            this.pnlHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(449, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(495, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ CÔNG THỨC SẢN PHẨM";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(210)))));
            this.pnlMenu.Controls.Add(this.btnQuayLai);
            this.pnlMenu.Location = new System.Drawing.Point(13, 84);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1374, 62);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(1222, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(152, 45);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // pnlSanPham
            // 
            this.pnlSanPham.BackColor = System.Drawing.Color.White;
            this.pnlSanPham.Controls.Add(this.dtgvSanPham);
            this.pnlSanPham.Controls.Add(this.lblChonSP);
            this.pnlSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSanPham.Location = new System.Drawing.Point(13, 168);
            this.pnlSanPham.Name = "pnlSanPham";
            this.pnlSanPham.Size = new System.Drawing.Size(496, 517);
            this.pnlSanPham.TabIndex = 4;
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(15, 47);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowHeadersWidth = 51;
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.Size = new System.Drawing.Size(461, 457);
            // 
            // lblChonSP
            // 
            this.lblChonSP.AutoSize = true;
            this.lblChonSP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonSP.Location = new System.Drawing.Point(24, 12);
            this.lblChonSP.Name = "lblChonSP";
            this.lblChonSP.Size = new System.Drawing.Size(345, 25);
            this.lblChonSP.TabIndex = 1;
            this.lblChonSP.Text = "Chọn sản phẩm để xem / sửa công thức";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnThem.Location = new System.Drawing.Point(553, 455);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 49);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm/Cập nhật";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // pnlCongThuc
            // 
            this.pnlCongThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(210)))));
            this.pnlCongThuc.Controls.Add(this.dtgvCongThuc);
            this.pnlCongThuc.Controls.Add(this.btnXoa);
            this.pnlCongThuc.Controls.Add(this.btnThem);
            this.pnlCongThuc.Controls.Add(this.cboTimNL);
            this.pnlCongThuc.Controls.Add(this.lblSoLuong);
            this.pnlCongThuc.Controls.Add(this.txtSoLuong);
            this.pnlCongThuc.Controls.Add(this.txtTimNL);
            this.pnlCongThuc.Controls.Add(this.label4);
            this.pnlCongThuc.Controls.Add(this.lblTieuDeCT);
            this.pnlCongThuc.Location = new System.Drawing.Point(547, 168);
            this.pnlCongThuc.Name = "pnlCongThuc";
            this.pnlCongThuc.Size = new System.Drawing.Size(840, 517);
            this.pnlCongThuc.TabIndex = 4;
            // 
            // dtgvCongThuc
            // 
            this.dtgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCongThuc.Location = new System.Drawing.Point(13, 47);
            this.dtgvCongThuc.Name = "dtgvCongThuc";
            this.dtgvCongThuc.RowHeadersWidth = 51;
            this.dtgvCongThuc.RowTemplate.Height = 24;
            this.dtgvCongThuc.Size = new System.Drawing.Size(809, 337);
            this.dtgvCongThuc.TabIndex = 11;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(733, 455);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 49);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // cboTimNL
            // 
            this.cboTimNL.BackColor = System.Drawing.Color.Silver;
            this.cboTimNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTimNL.FormattingEnabled = true;
            this.cboTimNL.Location = new System.Drawing.Point(13, 470);
            this.cboTimNL.Name = "cboTimNL";
            this.cboTimNL.Size = new System.Drawing.Size(419, 29);
            this.cboTimNL.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(441, 422);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(87, 25);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(447, 470);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 29);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTimNL
            // 
            this.txtTimNL.Location = new System.Drawing.Point(13, 421);
            this.txtTimNL.Name = "txtTimNL";
            this.txtTimNL.Size = new System.Drawing.Size(419, 29);
            this.txtTimNL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm / Chọn nguyên liệu";
            // 
            // lblTieuDeCT
            // 
            this.lblTieuDeCT.AutoSize = true;
            this.lblTieuDeCT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeCT.Location = new System.Drawing.Point(271, 12);
            this.lblTieuDeCT.Name = "lblTieuDeCT";
            this.lblTieuDeCT.Size = new System.Drawing.Size(243, 25);
            this.lblTieuDeCT.TabIndex = 1;
            this.lblTieuDeCT.Text = "Công thức cho [Chưa chọn]";
            // 
            // frmCongThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1399, 697);
            this.Controls.Add(this.pnlCongThuc);
            this.Controls.Add(this.pnlSanPham);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCongThuc";
            this.Text = "Quản lý công thức ";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlSanPham.ResumeLayout(false);
            this.pnlSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.pnlCongThuc.ResumeLayout(false);
            this.pnlCongThuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongThuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel pnlSanPham;
        private System.Windows.Forms.Label lblChonSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlCongThuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboTimNL;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTimNL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTieuDeCT;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.DataGridView dtgvCongThuc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

