using QuanLyQuanCaPhe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        QLCPDbContext context = new QLCPDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            dataGridView.AutoGenerateColumns = false;

            List<LoaiSanPham> lsp = new List<LoaiSanPham>();
            lsp = context.LoaiSanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaLoai"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.TenLoai = txtTenLoai.Text;
                    context.LoaiSanPham.Add(lsp);

                    context.SaveChanges();
                }
                else
                {
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                        context.LoaiSanPham.Update(lsp);

                        context.SaveChanges();
                    }
                }

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaLoai"].Value.ToString());
                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                }
                context.SaveChanges();

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Nhập Loại Sản Phẩm",
                Filter = "Excel (*.xlsx)|*.xlsx|Excel (*.xls)|*.xls"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (var wb = new XLWorkbook(ofd.FileName))
                {
                    var ws = wb.Worksheet(1);
                    var rows = ws.RowsUsed();

                    bool isFirstRow = true;
                    int insertCount = 0;
                    int updateCount = 0;
                    int skipCount = 0;

                    foreach (var row in rows)
                    {
                        // 🔹 Header check
                        if (isFirstRow)
                        {
                            string col1 = row.Cell(1).GetValue<string>().Trim();
                            string col2 = row.Cell(2).GetValue<string>().Trim();

                            if (col1 != "MaLoai" || col2 != "TenLoai")
                                throw new Exception("File Excel không đúng format (MaLoai | TenLoai)");

                            isFirstRow = false;
                            continue;
                        }

                        // 🔹 Đọc dữ liệu
                        string maLoaiStr = row.Cell(1).GetValue<string>().Trim();
                        string tenLoai = row.Cell(2).GetValue<string>().Trim();

                        if (string.IsNullOrWhiteSpace(tenLoai))
                        {
                            skipCount++;
                            continue;
                        }

                        // 🔹 Parse MaLoai (có thể rỗng)
                        int maLoai;
                        bool hasMaLoai = int.TryParse(maLoaiStr, out maLoai);

                        if (hasMaLoai)
                        {
                            // 🔸 Check tồn tại → UPDATE
                            var existing = context.LoaiSanPham
                                .FirstOrDefault(x => x.MaLoai == maLoai);

                            if (existing != null)
                            {
                                existing.TenLoai = tenLoai;
                                updateCount++;
                            }
                            else
                            {
                                // 🔸 Không tồn tại → INSERT
                                context.LoaiSanPham.Add(new LoaiSanPham
                                {
                                    TenLoai = tenLoai
                                });
                                insertCount++;
                            }
                        }
                        else
                        {
                            // 🔸 Không có MaLoai → INSERT
                            context.LoaiSanPham.Add(new LoaiSanPham
                            {
                                TenLoai = tenLoai
                            });
                            insertCount++;
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show(
                        $"Insert: {insertCount}\nUpdate: {updateCount}\nBỏ qua: {skipCount}",
                        "Kết quả import",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    frmLoaiSanPham_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Xuất Loại Sản Phẩm",
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"LoaiSanPham_{DateTime.Now:dd_MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var data = context.LoaiSanPham.ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("LoaiSanPham");

                    // Header (CHUẨN CHUNG)
                    ws.Cell(1, 1).Value = "MaLoai";
                    ws.Cell(1, 2).Value = "TenLoai";

                    var header = ws.Range(1, 1, 1, 2);
                    header.Style.Font.Bold = true;
                    header.Style.Fill.BackgroundColor = XLColor.LightGray;

                    int row = 2;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaLoai;
                        ws.Cell(row, 2).Value = item.TenLoai;
                        row++;
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
