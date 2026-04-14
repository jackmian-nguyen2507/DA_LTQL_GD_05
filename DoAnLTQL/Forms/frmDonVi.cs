using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmDonVi : Form
    {

        QLCPDbContext context = new QLCPDbContext();
        public frmDonVi()
        {
            InitializeComponent();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            dtgvDonVi.AutoGenerateColumns = false;
            LoadDonVi();
            txtTenDonVi.Focus();
        }

        void LoadDonVi()
        {
            var list = context.DonVi
                .Select(d => new
                {
                    d.MaDonVi,
                    d.TenDonVi
                })
                .ToList();

            dtgvDonVi.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenDonVi.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị!");
                return;
            }

            // tránh trùng
            var check = context.DonVi
                .FirstOrDefault(d => d.TenDonVi.ToLower() == ten.ToLower());

            if (check != null)
            {
                MessageBox.Show("Đơn vị đã tồn tại!");
                return;
            }

            DonVi dv = new DonVi();
            dv.TenDonVi = ten;

            context.DonVi.Add(dv);
            context.SaveChanges();

            MessageBox.Show("Thêm đơn vị thành công!");

            txtTenDonVi.Clear();
            LoadDonVi();

            // báo về form cha
            this.DialogResult = DialogResult.OK;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDonVi.CurrentRow == null) return;

            int ma = (int)dtgvDonVi.CurrentRow.Cells["MaDonVi"].Value;

            var dv = context.DonVi.Find(ma);

            // check FK
            bool dangSuDung = context.NguyenLieu.Any(nl => nl.MaDonVi == ma);

            if (dangSuDung)
            {
                MessageBox.Show("Đơn vị đang được sử dụng, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Xóa đơn vị?", "Xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.DonVi.Remove(dv);
                context.SaveChanges();
                LoadDonVi();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDonVi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Nhập Đơn Vị",
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
                        if (isFirstRow)
                        {
                            if (row.Cell(1).GetValue<string>().Trim() != "MaDonVi" ||
                                row.Cell(2).GetValue<string>().Trim() != "TenDonVi")
                            {
                                throw new Exception("File Excel không đúng format (MaDonVi | TenDonVi)");
                            }
                            isFirstRow = false;
                            continue;
                        }

                        string maDonViStr = row.Cell(1).GetValue<string>().Trim();
                        string tenDonVi = row.Cell(2).GetValue<string>().Trim();

                        if (string.IsNullOrWhiteSpace(tenDonVi))
                        {
                            skipCount++;
                            continue;
                        }

                        int maDonVi;
                        bool hasMaDonVi = int.TryParse(maDonViStr, out maDonVi);

                        if (hasMaDonVi)
                        {
                            var existing = context.DonVi.FirstOrDefault(x => x.MaDonVi == maDonVi);
                            if (existing != null)
                            {
                                existing.TenDonVi = tenDonVi;
                                updateCount++;
                            }
                            else
                            {
                                context.DonVi.Add(new DonVi { TenDonVi = tenDonVi });
                                insertCount++;
                            }
                        }
                        else
                        {
                            context.DonVi.Add(new DonVi { TenDonVi = tenDonVi });
                            insertCount++;
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show($"Insert: {insertCount}\nUpdate: {updateCount}\nBỏ qua: {skipCount}", "Kết quả import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDonVi();
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
                Title = "Xuất Đơn Vị",
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"DonVi_{DateTime.Now:dd_MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var data = context.DonVi.ToList();
                if (data.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("DonVi");

                    ws.Cell(1, 1).Value = "MaDonVi";
                    ws.Cell(1, 2).Value = "TenDonVi";

                    var header = ws.Range(1, 1, 1, 2);
                    header.Style.Font.Bold = true;
                    header.Style.Fill.BackgroundColor = XLColor.LightGray;

                    int row = 2;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaDonVi;
                        ws.Cell(row, 2).Value = item.TenDonVi;
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
    }
}
