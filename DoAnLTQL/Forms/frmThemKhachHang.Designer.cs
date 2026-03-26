namespace QuanLyQuanCaPhe.Forms
{
    partial class frmThemKhachHang
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
            lblMaKH = new Label();
            lblTenKH = new Label();
            lblSDT = new Label();
            lblDiem = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            numDiem = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numDiem).BeginInit();
            SuspendLayout();
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI", 12F);
            lblMaKH.Location = new Point(30, 30);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(118, 21);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã khách Hàng";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Segoe UI", 12F);
            lblTenKH.Location = new Point(30, 80);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(117, 21);
            lblTenKH.TabIndex = 1;
            lblTenKH.Text = "Tên khách hàng";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 12F);
            lblSDT.Location = new Point(30, 130);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(101, 21);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Segoe UI", 12F);
            lblDiem.Location = new Point(30, 180);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(101, 21);
            lblDiem.TabIndex = 3;
            lblDiem.Text = "Điểm tích lũy";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 12F);
            txtMaKH.Location = new Point(170, 27);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(280, 29);
            txtMaKH.TabIndex = 5;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Segoe UI", 12F);
            txtTenKH.Location = new Point(170, 77);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(280, 29);
            txtTenKH.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(170, 127);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(280, 29);
            txtSDT.TabIndex = 7;
            // 
            // numDiem
            // 
            numDiem.Font = new Font("Segoe UI", 12F);
            numDiem.Location = new Point(170, 178);
            numDiem.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numDiem.Name = "numDiem";
            numDiem.Size = new Size(120, 29);
            numDiem.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(73, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnLuu_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(350, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmThemKhachHang
            // 
            ClientSize = new Size(500, 400);
            Controls.Add(lblMaKH);
            Controls.Add(lblTenKH);
            Controls.Add(lblSDT);
            Controls.Add(lblDiem);
            Controls.Add(txtMaKH);
            Controls.Add(txtTenKH);
            Controls.Add(txtSDT);
            Controls.Add(numDiem);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmThemKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết khách hàng";
            Load += frmThemKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)numDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiem;

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.NumericUpDown numDiem;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
