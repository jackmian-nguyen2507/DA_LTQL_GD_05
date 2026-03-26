namespace QuanLyQuanCaPhe.Forms
{
    partial class frmChiTietHoaDon
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
            lblTitle = new Label();
            pnlMenu = new Panel();
            btnQuayLai = new Button();
            lblMaHD = new Label();
            lblMaHDValue = new Label();
            lblTongTien = new Label();
            lblTongTienValue = new Label();
            dtgvChiTiet = new DataGridView();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(450, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHI TIẾT HÓA ĐƠN BÁN";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(246, 236, 210);
            pnlMenu.Controls.Add(btnQuayLai);
            pnlMenu.Controls.Add(lblMaHD);
            pnlMenu.Controls.Add(lblMaHDValue);
            pnlMenu.Controls.Add(lblTongTien);
            pnlMenu.Controls.Add(lblTongTienValue);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 80);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1200, 90);
            pnlMenu.TabIndex = 1;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.FromArgb(224, 224, 224);
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnQuayLai.Location = new Point(1030, 18);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(150, 45);
            btnQuayLai.TabIndex = 0;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += BtnQuayLai_Click;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaHD.Location = new Point(20, 20);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(109, 21);
            lblMaHD.TabIndex = 1;
            lblMaHD.Text = "Mã hóa đơn: ";
            // 
            // lblMaHDValue
            // 
            lblMaHDValue.AutoSize = true;
            lblMaHDValue.Font = new Font("Segoe UI", 12F);
            lblMaHDValue.Location = new Point(160, 20);
            lblMaHDValue.Name = "lblMaHDValue";
            lblMaHDValue.Size = new Size(76, 21);
            lblMaHDValue.TabIndex = 2;
            lblMaHDValue.Text = "(Chưa có)";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.Location = new Point(20, 50);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(87, 21);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // lblTongTienValue
            // 
            lblTongTienValue.AutoSize = true;
            lblTongTienValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienValue.ForeColor = Color.Red;
            lblTongTienValue.Location = new Point(160, 50);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new Size(40, 25);
            lblTongTienValue.TabIndex = 4;
            lblTongTienValue.Text = "0 đ";
            // 
            // dtgvChiTiet
            // 
            dtgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { TenSP, SoLuong, DonGia, ThanhTien, GhiChu });
            dtgvChiTiet.Dock = DockStyle.Fill;
            dtgvChiTiet.Location = new Point(0, 170);
            dtgvChiTiet.Name = "dtgvChiTiet";
            dtgvChiTiet.RowHeadersWidth = 51;
            dtgvChiTiet.RowTemplate.Height = 24;
            dtgvChiTiet.Size = new Size(1200, 520);
            dtgvChiTiet.TabIndex = 2;
            dtgvChiTiet.CellFormatting += dtgvChiTiet_CellFormatting;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.Name = "GhiChu";
            // 
            // frmChiTietHoaDon
            // 
            ClientSize = new Size(1200, 690);
            Controls.Add(dtgvChiTiet);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Name = "frmChiTietHoaDon";
            Text = "Chi tiết hóa đơn";
            Load += frmChiTietHoaDon_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvChiTiet).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblMaHDValue;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienValue;
        private System.Windows.Forms.DataGridView dtgvChiTiet;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn GhiChu;
    }
}
