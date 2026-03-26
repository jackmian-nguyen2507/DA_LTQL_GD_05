namespace QuanLyQuanCaPhe.Forms
{
    partial class frmThemNguyenLieu
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
            lblTitle = new Label();
            lblMaNL = new Label();
            lblTenNL = new Label();
            lblDonVi = new Label();
            lblSoLuong = new Label();
            txtMaNL = new TextBox();
            txtTenNL = new TextBox();
            txtDonVi = new TextBox();
            numSoLuong = new NumericUpDown();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHI TIẾT NGUYÊN LIỆU";
            // 
            // lblMaNL
            // 
            lblMaNL.AutoSize = true;
            lblMaNL.Location = new Point(25, 80);
            lblMaNL.Name = "lblMaNL";
            lblMaNL.Size = new Size(59, 21);
            lblMaNL.TabIndex = 1;
            lblMaNL.Text = "Mã NL:";
            // 
            // lblTenNL
            // 
            lblTenNL.AutoSize = true;
            lblTenNL.Location = new Point(25, 130);
            lblTenNL.Name = "lblTenNL";
            lblTenNL.Size = new Size(60, 21);
            lblTenNL.TabIndex = 3;
            lblTenNL.Text = "Tên NL:";
            // 
            // lblDonVi
            // 
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(25, 180);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(59, 21);
            lblDonVi.TabIndex = 5;
            lblDonVi.Text = "Đơn vị:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(25, 230);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(76, 21);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtMaNL
            // 
            txtMaNL.Location = new Point(140, 76);
            txtMaNL.Name = "txtMaNL";
            txtMaNL.Size = new Size(220, 29);
            txtMaNL.TabIndex = 2;
            // 
            // txtTenNL
            // 
            txtTenNL.Location = new Point(140, 126);
            txtTenNL.Name = "txtTenNL";
            txtTenNL.Size = new Size(220, 29);
            txtTenNL.TabIndex = 4;
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(140, 176);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.Size = new Size(220, 29);
            txtDonVi.TabIndex = 6;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(140, 226);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(120, 29);
            numSoLuong.TabIndex = 8;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DarkGreen;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(70, 300);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 40);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(220, 300);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 40);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnCancel_Click;
            // 
            // frmThemNguyenLieu
            // 
            ClientSize = new Size(400, 370);
            Controls.Add(lblTitle);
            Controls.Add(lblMaNL);
            Controls.Add(txtMaNL);
            Controls.Add(lblTenNL);
            Controls.Add(txtTenNL);
            Controls.Add(lblDonVi);
            Controls.Add(txtDonVi);
            Controls.Add(lblSoLuong);
            Controls.Add(numSoLuong);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Font = new Font("Segoe UI", 12F);
            Name = "frmThemNguyenLieu";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaNL;
        private System.Windows.Forms.Label lblTenNL;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

        #endregion
    }
}