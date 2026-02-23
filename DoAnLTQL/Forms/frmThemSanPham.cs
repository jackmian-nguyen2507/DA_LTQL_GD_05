using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmThemSanPham : Form
    {
        QLCPDbContext context = new QLCPDbContext();

        SanPham sp = new SanPham();

        string maSP = "";
        bool isEdit = false;

        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

        string fileName = "";
        string selectedImageName = "";

        // Constructor để nhận mã sp từ frmSanPham
        public frmThemSanPham(string maSP)
        {
            InitializeComponent();

            this.maSP = maSP;
            isEdit = true;
        }
        public frmThemSanPham()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImageName))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh sản phẩm.");
                return;
            }



            if (isEdit)
            {
                var sp = context.SanPham.Find(maSP);

                if (sp != null)
                {
                    sp.TenSP = txtTenSP.Text;
                    sp.MaLoai = (int)cboLoaiSP.SelectedValue;
                    sp.DonGia = numDonGia.Value;
                    sp.TrangThai = cboTrangThai.Text;
                    sp.ImagePath = selectedImageName;
                }
            }
            else
            {
                SanPham sp = new SanPham();

                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.MaLoai = (int)cboLoaiSP.SelectedValue;
                sp.DonGia = numDonGia.Value;
                sp.TrangThai = cboTrangThai.Text;
                sp.ImagePath = selectedImageName;

                context.SanPham.Add(sp);
            }

            context.SaveChanges();

            MessageBox.Show("Lưu thành công!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImageName = Path.GetFileName(openFileDialog.FileName);

                string fileSavePath = Path.Combine(imagesFolder, selectedImageName);

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                File.Copy(openFileDialog.FileName, fileSavePath, true);

                picHinhAnh.Image = Image.FromFile(fileSavePath);
            }
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSP.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSP.ValueMember = "MaLoai";
            cboLoaiSP.DisplayMember = "TenLoai";
        }

        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            LayLoaiSanPhamVaoComboBox();
            LayTrangThaiSanPhamChoComboBox();

            if (isEdit)
            {
                txtMaSP.Enabled = false;
                var sp = context.SanPham.Find(maSP);

                if (sp != null)
                {
                    txtMaSP.Text = sp.MaSP;
                    txtMaSP.Enabled = false; // không cho sửa mã

                    txtTenSP.Text = sp.TenSP;
                    cboLoaiSP.SelectedValue = sp.MaLoai;
                    numDonGia.Value = sp.DonGia;
                    cboTrangThai.Text = sp.TrangThai;

                    selectedImageName = sp.ImagePath;

                    if (!string.IsNullOrEmpty(sp.ImagePath))
                    {
                        string filePath = Path.Combine(imagesFolder, sp.ImagePath);

                        if (File.Exists(filePath))
                        {
                            picHinhAnh.Image = LoadImageNoLock(filePath);
                        }
                    }
                }
            }
            if (!isEdit)
            {
                txtMaSP.Text = TaoMaSanPhamTuDong();
                txtMaSP.Enabled = false;
            }
        }

        Image LoadImageNoLock(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public void LayTrangThaiSanPhamChoComboBox()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Còn bán");
            cboTrangThai.Items.Add("Hết hàng");

            cboTrangThai.SelectedIndex = 0; // mặc định chọn "Còn bán"
        }

        string TaoMaSanPhamTuDong()
        {
            QLCPDbContext context = new QLCPDbContext();

            var listMa = context.SanPham
                .Select(x => x.MaSP)
                .ToList();

            List<int> numbers = listMa
                .Where(x => x.StartsWith("SP"))
                .Select(x =>
                {
                    int n;
                    return int.TryParse(x.Substring(2), out n) ? n : 0;
                })
                .Where(x => x > 0)
                .OrderBy(x => x)
                .ToList();

            int newNumber = 1;

            foreach (var num in numbers)
            {
                if (num == newNumber)
                    newNumber++;
                else
                    break;
            }

            return "SP" + newNumber.ToString("D3"); // SP001
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
