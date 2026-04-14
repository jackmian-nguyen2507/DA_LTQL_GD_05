namespace QuanLyQuanCaPhe.Forms
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            pnlHeader = new Panel();
            panel1 = new Panel();
            lblTitle = new Label();
            pnlMenu = new Panel();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            côngThứcToolStripMenuItem = new ToolStripMenuItem();
            nguyênLiệuToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            doanhThToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            tabFilter = new TabControl();
            tabEmpty = new TabPage();
            flpEmpty = new FlowLayoutPanel();
            tabBusy = new TabPage();
            flpBusy = new FlowLayoutPanel();
            tabAll = new TabPage();
            flpAll = new FlowLayoutPanel();
            imageList1 = new ImageList(components);
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlContent.SuspendLayout();
            tabFilter.SuspendLayout();
            tabEmpty.SuspendLayout();
            tabBusy.SuspendLayout();
            tabAll.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            pnlHeader.Controls.Add(panel1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1684, 70);
            pnlHeader.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 72);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 93);
            panel1.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(376, 8);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(640, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ QUÁN CÀ PHÊ - SƠ ĐỒ BÀN";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(255, 224, 192);
            pnlMenu.Controls.Add(menuStrip1);
            pnlMenu.Location = new Point(0, 72);
            pnlMenu.Margin = new Padding(2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1684, 50);
            pnlMenu.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, báoCáoThốngKêToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1684, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(102, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(132, 30);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmToolStripMenuItem, nguyênLiệuToolStripMenuItem, hóaĐơnToolStripMenuItem, kháchHàngToolStripMenuItem });
            quảnLýToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(89, 29);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { côngThứcToolStripMenuItem });
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(186, 30);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += btnSanPham_Click;
            // 
            // côngThứcToolStripMenuItem
            // 
            côngThứcToolStripMenuItem.Name = "côngThứcToolStripMenuItem";
            côngThứcToolStripMenuItem.Size = new Size(171, 30);
            côngThứcToolStripMenuItem.Text = "Công thức";
            côngThứcToolStripMenuItem.Click += côngThứcToolStripMenuItem_Click;
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            nguyênLiệuToolStripMenuItem.Size = new Size(186, 30);
            nguyênLiệuToolStripMenuItem.Text = "Nguyên liệu";
            nguyênLiệuToolStripMenuItem.Click += nguyênLiệuToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(186, 30);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(186, 30);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThToolStripMenuItem });
            báoCáoThốngKêToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(183, 29);
            báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo - thống kê";
            // 
            // doanhThToolStripMenuItem
            // 
            doanhThToolStripMenuItem.Name = "doanhThToolStripMenuItem";
            doanhThToolStripMenuItem.Size = new Size(173, 30);
            doanhThToolStripMenuItem.Text = "Doanh thu";
            doanhThToolStripMenuItem.Click += doanhThToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThuToolStripMenuItem });
            trợGiúpToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(93, 29);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(260, 30);
            doanhThuToolStripMenuItem.Text = "Thông tin phần mềm";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(215, 199, 189);
            pnlContent.Controls.Add(tabFilter);
            pnlContent.Location = new Point(0, 127);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1684, 773);
            pnlContent.TabIndex = 10;
            // 
            // tabFilter
            // 
            tabFilter.Appearance = TabAppearance.FlatButtons;
            tabFilter.Controls.Add(tabEmpty);
            tabFilter.Controls.Add(tabBusy);
            tabFilter.Controls.Add(tabAll);
            tabFilter.Dock = DockStyle.Top;
            tabFilter.ItemSize = new Size(100, 30);
            tabFilter.Location = new Point(0, 0);
            tabFilter.Margin = new Padding(4, 3, 4, 3);
            tabFilter.Name = "tabFilter";
            tabFilter.SelectedIndex = 0;
            tabFilter.Size = new Size(1684, 770);
            tabFilter.SizeMode = TabSizeMode.Fixed;
            tabFilter.TabIndex = 0;
            // 
            // tabEmpty
            // 
            tabEmpty.Controls.Add(flpEmpty);
            tabEmpty.Location = new Point(4, 34);
            tabEmpty.Margin = new Padding(4, 3, 4, 3);
            tabEmpty.Name = "tabEmpty";
            tabEmpty.Padding = new Padding(4, 3, 4, 3);
            tabEmpty.Size = new Size(1676, 732);
            tabEmpty.TabIndex = 1;
            tabEmpty.Text = "Trống";
            tabEmpty.UseVisualStyleBackColor = true;
            // 
            // flpEmpty
            // 
            flpEmpty.Dock = DockStyle.Fill;
            flpEmpty.Location = new Point(4, 3);
            flpEmpty.Margin = new Padding(4, 3, 4, 3);
            flpEmpty.Name = "flpEmpty";
            flpEmpty.Size = new Size(1668, 726);
            flpEmpty.TabIndex = 1;
            // 
            // tabBusy
            // 
            tabBusy.Controls.Add(flpBusy);
            tabBusy.Location = new Point(4, 34);
            tabBusy.Margin = new Padding(4, 3, 4, 3);
            tabBusy.Name = "tabBusy";
            tabBusy.Size = new Size(1676, 732);
            tabBusy.TabIndex = 2;
            tabBusy.Text = "Có khách";
            tabBusy.UseVisualStyleBackColor = true;
            // 
            // flpBusy
            // 
            flpBusy.Dock = DockStyle.Fill;
            flpBusy.Location = new Point(0, 0);
            flpBusy.Margin = new Padding(4, 3, 4, 3);
            flpBusy.Name = "flpBusy";
            flpBusy.Size = new Size(1676, 732);
            flpBusy.TabIndex = 2;
            // 
            // tabAll
            // 
            tabAll.Controls.Add(flpAll);
            tabAll.Location = new Point(4, 34);
            tabAll.Margin = new Padding(4, 3, 4, 3);
            tabAll.Name = "tabAll";
            tabAll.Padding = new Padding(4, 3, 4, 3);
            tabAll.Size = new Size(1676, 732);
            tabAll.TabIndex = 0;
            tabAll.Text = "Tất cả";
            tabAll.UseVisualStyleBackColor = true;
            // 
            // flpAll
            // 
            flpAll.Dock = DockStyle.Fill;
            flpAll.Location = new Point(4, 3);
            flpAll.Margin = new Padding(4, 3, 4, 3);
            flpAll.Name = "flpAll";
            flpAll.Size = new Size(1668, 726);
            flpAll.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "table_empty.png");
            imageList1.Images.SetKeyName(1, "table_busy.png");
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 901);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmMainMenu";
            Text = "Cửa sổ chính";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlContent.ResumeLayout(false);
            tabFilter.ResumeLayout(false);
            tabEmpty.ResumeLayout(false);
            tabBusy.ResumeLayout(false);
            tabAll.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem côngThứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.TabControl tabFilter;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabEmpty;
        private System.Windows.Forms.TabPage tabBusy;
        private System.Windows.Forms.FlowLayoutPanel flpAll;
        private System.Windows.Forms.FlowLayoutPanel flpEmpty;
        private System.Windows.Forms.FlowLayoutPanel flpBusy;
    }
}