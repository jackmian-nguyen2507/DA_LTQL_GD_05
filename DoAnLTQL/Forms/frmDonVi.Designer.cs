namespace QuanLyQuanCaPhe.Forms
{
    partial class frmDonVi
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
            txtTenDonVi = new TextBox();
            btnThem = new Button();
            grbDanhSachDonVi = new GroupBox();
            dtgvDonVi = new DataGridView();
            MaDonVi = new DataGridViewTextBoxColumn();
            TenDonVi = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnDong = new Button();
            grbDanhSachDonVi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDonVi).BeginInit();
            SuspendLayout();
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.Location = new Point(14, 24);
            txtTenDonVi.Margin = new Padding(5);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(259, 33);
            txtTenDonVi.TabIndex = 0;
            txtTenDonVi.KeyDown += txtTenDonVi_KeyDown;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(281, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 33);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbDanhSachDonVi
            // 
            grbDanhSachDonVi.Controls.Add(dtgvDonVi);
            grbDanhSachDonVi.Location = new Point(14, 78);
            grbDanhSachDonVi.Name = "grbDanhSachDonVi";
            grbDanhSachDonVi.Size = new Size(398, 237);
            grbDanhSachDonVi.TabIndex = 2;
            grbDanhSachDonVi.TabStop = false;
            grbDanhSachDonVi.Text = "Danh sách đơn vị";
            // 
            // dtgvDonVi
            // 
            dtgvDonVi.AllowUserToAddRows = false;
            dtgvDonVi.AllowUserToDeleteRows = false;
            dtgvDonVi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDonVi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDonVi.Columns.AddRange(new DataGridViewColumn[] { MaDonVi, TenDonVi });
            dtgvDonVi.Dock = DockStyle.Fill;
            dtgvDonVi.Location = new Point(3, 29);
            dtgvDonVi.Name = "dtgvDonVi";
            dtgvDonVi.Size = new Size(392, 205);
            dtgvDonVi.TabIndex = 0;
            // 
            // MaDonVi
            // 
            MaDonVi.DataPropertyName = "MaDonVi";
            MaDonVi.HeaderText = "Mã đơn vị";
            MaDonVi.Name = "MaDonVi";
            // 
            // TenDonVi
            // 
            TenDonVi.DataPropertyName = "TenDonVi";
            TenDonVi.HeaderText = "Tên đơn vị";
            TenDonVi.Name = "TenDonVi";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(46, 330);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 37);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(254, 330);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(118, 37);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // frmDonVi
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 388);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(grbDanhSachDonVi);
            Controls.Add(btnThem);
            Controls.Add(txtTenDonVi);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "frmDonVi";
            Text = "Thêm đơn vị";
            Load += frmDonVi_Load;
            grbDanhSachDonVi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDonVi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDonVi;
        private Button btnThem;
        private GroupBox grbDanhSachDonVi;
        private DataGridView dtgvDonVi;
        private Button btnXoa;
        private Button btnDong;
        private DataGridViewTextBoxColumn MaDonVi;
        private DataGridViewTextBoxColumn TenDonVi;
    }
}