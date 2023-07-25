using DevExpress.XtraEditors;
using QuanLy;
using QuanLyCafe.OrderSanPham.Form_Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.QLNhanVien
{
    public partial class uc_QLNhanVien : UserControl
    {
        public uc_QLNhanVien()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private bool CheckThongTin()
        {
            if(string.IsNullOrEmpty(NameNhanVienTextEdit.Text) || NameNhanVienTextEdit.Text == "")
            {
                Helper_Project.fMain.ShowNotification("Thông báo", "Kiểm tra thông tin", $"Bạn chưa điền tên nhân viên !!!", Helper_Project.svgImages["Error"]);
                return false;
            }
            if (string.IsNullOrEmpty(NameChucVuCbb.Text) || NameChucVuCbb.Text == "")
            {
                Helper_Project.fMain.ShowNotification("Thông báo", "Kiểm tra thông tin", $"Bạn chưa chọn chức vụ cho nhận viên !!!", Helper_Project.svgImages["Error"]);
                return false;
            }

            return true;
        }
        private void LoadAllDB()
        {
            var result = db_quanly.NhanViens
                .Select(p => new { p.IdNhanVien, p.NameNhanVien, p.ChucVu.NameChucVu, p.Thongtin })
                .ToList();

            modelQLNhanVienBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        public void LoadChucVu()
        {
            NameChucVuCbb.Properties.Items.Clear();
            var listchucvu = db_quanly.ChucVus
                .Select(p => p.NameChucVu).ToList();
            foreach (var chucVu in listchucvu)
            {
                NameChucVuCbb.Properties.Items.Add(chucVu);
            }
            NameChucVuCbb.Text = NameChucVuCbb.Properties.Items[0].ToString();
        }
        private void uc_QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu(); // Lấy thông tin chức vụ từ bản chức vụ

            LoadAllDB();
        }
        private int GET_ID_CHUCYU(string namechucvu)
        {
            int id = db_quanly.ChucVus
                .Where(x => x.NameChucVu == namechucvu)
                .Select(x => x.IdChucVu)
                .FirstOrDefault();
            return id;
        }
        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            if(CheckThongTin() == false) return;

            NhanVien nhanVien = new NhanVien
            {
                NameNhanVien = NameNhanVienTextEdit.Text,
                IdChucVu = GET_ID_CHUCYU(NameChucVuCbb.Text),
                Thongtin = ThongtinTextEdit.Text,
            };

            db_quanly.NhanViens.Add(nhanVien);
            db_quanly.SaveChanges();
                 
            LoadAllDB();
        }

        private void btnShowChucVu_Click(object sender, EventArgs e)
        {
            fChucVu fChucVu = new fChucVu();
            fChucVu.ShowDialog();

            LoadChucVu();
        }

        private void btnEditNhanVien_Click(object sender, EventArgs e)
        {
            if (CheckThongTin() == false) return;

            int index = gridView1.FocusedRowHandle;
            int idnhanvien = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdNhanVien"));
            string namenhanvien = gridView1.GetRowCellValue(index, "NameNhanVien").ToString();

            NhanVien nhanvien = db_quanly.NhanViens.Find(idnhanvien);
            nhanvien.NameNhanVien = NameNhanVienTextEdit.Text;
            nhanvien.IdChucVu = GET_ID_CHUCYU(NameChucVuCbb.Text);
            nhanvien.Thongtin = ThongtinTextEdit.Text;

            db_quanly.SaveChanges();

            Helper_Project.fMain.ShowNotification("Thông báo", "Chỉnh sửa thông tin nhân viên", $"Chỉnh sửa nhân viên {namenhanvien} thành công", Helper_Project.svgImages["Success"]);

            LoadAllDB();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có muốn xoá topping {indexSelected.Length} dòng không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    string IdNhanVien = gridView1.GetRowCellValue(index, "IdNhanVien").ToString();
                    string NameNhanVien = gridView1.GetRowCellValue(index, "NameNhanVien").ToString();
                    int id = Convert.ToInt32(IdNhanVien);

                    NhanVien topping = db_quanly.NhanViens.Find(id);

                    db_quanly.NhanViens.Remove(topping);

                    Helper_Project.fMain.ShowNotification("Thông báo", "Xóa nhân viên", $"Xóa nhân viên {NameNhanVien} thành công !!!", Helper_Project.svgImages["Success"]);
                }

                db_quanly.SaveChanges();

                LoadAllDB();
            }
        }
    }
}
