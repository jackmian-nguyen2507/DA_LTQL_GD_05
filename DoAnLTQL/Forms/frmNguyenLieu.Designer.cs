namespace QuanLyQuanCaPhe.Forms
{
    partial class frmNguyenLieu
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
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblQLNL = new Label();
            panelControl = new Panel();
            btnTaiLai = new Button();
            btnXoa = new Button();
            btnDieuChinh = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            lblTimNL = new Label();
            btnQuayLai = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dtgvNguyenLieu = new DataGridView();
            MaNL = new DataGridViewTextBoxColumn();
            TenNL = new DataGridViewTextBoxColumn();
            TenDonVi = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNguyenLieu).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblQLNL);
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1515, 77);
            pnlHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(469, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblQLNL
            // 
            lblQLNL.AutoSize = true;
            lblQLNL.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQLNL.ForeColor = Color.White;
            lblQLNL.Location = new Point(517, 17);
            lblQLNL.Name = "lblQLNL";
            lblQLNL.Size = new Size(262, 30);
            lblQLNL.TabIndex = 0;
            lblQLNL.Text = "QUẢN LÝ NGUYÊN LIỆU ";
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.FromArgb(246, 236, 210);
            panelControl.Controls.Add(btnTaiLai);
            panelControl.Controls.Add(btnXoa);
            panelControl.Controls.Add(btnDieuChinh);
            panelControl.Controls.Add(btnSua);
            panelControl.Controls.Add(btnThem);
            panelControl.Controls.Add(txtTimKiem);
            panelControl.Controls.Add(lblTimNL);
            panelControl.Controls.Add(btnQuayLai);
            panelControl.Location = new Point(7, 84);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1498, 70);
            panelControl.TabIndex = 3;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.FromArgb(224, 224, 224);
            btnTaiLai.FlatAppearance.BorderSize = 0;
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.ForeColor = Color.Maroon;
            btnTaiLai.Location = new Point(437, 11);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(133, 44);
            btnTaiLai.TabIndex = 16;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(1063, 10);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 47);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDieuChinh
            // 
            btnDieuChinh.BackColor = Color.FromArgb(224, 224, 224);
            btnDieuChinh.FlatAppearance.BorderSize = 0;
            btnDieuChinh.FlatStyle = FlatStyle.Flat;
            btnDieuChinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDieuChinh.ForeColor = Color.Navy;
            btnDieuChinh.Location = new Point(744, 11);
            btnDieuChinh.Name = "btnDieuChinh";
            btnDieuChinh.Size = new Size(133, 45);
            btnDieuChinh.TabIndex = 13;
            btnDieuChinh.Text = "Điều chỉnh ";
            btnDieuChinh.UseVisualStyleBackColor = false;
            btnDieuChinh.Click += btnDieuChinh_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(224, 224, 224);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(907, 11);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 45);
            btnSua.TabIndex = 13;
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
            btnThem.Location = new Point(589, 11);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 45);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(79, 17);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(314, 29);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimNL
            // 
            lblTimNL.AutoSize = true;
            lblTimNL.Location = new Point(5, 16);
            lblTimNL.Name = "lblTimNL";
            lblTimNL.Size = new Size(67, 21);
            lblTimNL.TabIndex = 9;
            lblTimNL.Text = "Tìm NL: ";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Right;
            btnQuayLai.BackColor = Color.FromArgb(224, 224, 224);
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1347, 10);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(127, 47);
            btnQuayLai.TabIndex = 8;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dtgvNguyenLieu
            // 
            dtgvNguyenLieu.AllowUserToAddRows = false;
            dtgvNguyenLieu.AllowUserToDeleteRows = false;
            dtgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNguyenLieu.Columns.AddRange(new DataGridViewColumn[] { MaNL, TenNL, TenDonVi, SoLuongTon });
            dtgvNguyenLieu.Location = new Point(7, 178);
            dtgvNguyenLieu.MultiSelect = false;
            dtgvNguyenLieu.Name = "dtgvNguyenLieu";
            dtgvNguyenLieu.RowHeadersWidth = 51;
            dtgvNguyenLieu.RowTemplate.Height = 24;
            dtgvNguyenLieu.Size = new Size(1498, 404);
            dtgvNguyenLieu.TabIndex = 5;
            dtgvNguyenLieu.CellFormatting += dtgvNguyenLieu_CellFormatting;
            // 
            // MaNL
            // 
            MaNL.DataPropertyName = "MaNL";
            MaNL.HeaderText = "Mã nguyên liệu";
            MaNL.Name = "MaNL";
            // 
            // TenNL
            // 
            TenNL.DataPropertyName = "TenNL";
            TenNL.HeaderText = "Tên nguyên liệu";
            TenNL.Name = "TenNL";
            // 
            // TenDonVi
            // 
            TenDonVi.DataPropertyName = "TenDonVi";
            TenDonVi.HeaderText = "Đơn vị";
            TenDonVi.Name = "TenDonVi";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.Name = "SoLuongTon";
            // 
            // frmNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 236, 210);
            ClientSize = new Size(1517, 594);
            Controls.Add(dtgvNguyenLieu);
            Controls.Add(panelControl);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmNguyenLieu";
            Text = "Quản lý nguyên liệu ";
            Load += frmNguyenLieu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNguyenLieu).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQLNL;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimNL;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDieuChinh;
        private System.Windows.Forms.DataGridView dtgvNguyenLieu;
        private DataGridViewTextBoxColumn MaNL;
        private DataGridViewTextBoxColumn TenNL;
        private DataGridViewTextBoxColumn TenDonVi;
        private DataGridViewTextBoxColumn SoLuongTon;
    }
}

