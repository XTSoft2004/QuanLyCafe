using DevExpress.XtraEditors;
using QuanLyCafe;
using QuanLyCafe.Helper;
using QuanLyCafe.QLNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCafe.Helper.Helper_ShowNoti;

namespace QuanLy
{
    public partial class fChucVu : DevExpress.XtraEditors.XtraForm
    {
        public fChucVu()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly  = new QuanLyCafeEntities();
        private void LoadAllChucVu()
        {
            var result = db_quanly.ChucVus
                .Select(p => new { p.IdChucVu, p.NameChucVu }).ToList();

            chucVuBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private void fChucVu_Load(object sender, EventArgs e)
        {
            LoadAllChucVu();
        }

        private void btnAddChucVu_Click(object sender, EventArgs e)
        {
            string namechucvu = NameChucVuTextEdit.Text;

            if (!CheckNameChucVu()) return;

            ChucVu chucvu = new ChucVu()
            {
                //IdChucVu = Convert.ToInt32(IdChucVuTextEdit.Text),
                NameChucVu = namechucvu,
            };
            db_quanly.ChucVus.Add(chucvu);
            db_quanly.SaveChanges();

            Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã thêm chức vụ {namechucvu} thành công !!!", SvgImageIcon.Success);

            LoadAllChucVu();
        }

        private void btnEditChucVu_Click(object sender, EventArgs e)
        {
            string namechucvu = NameChucVuTextEdit.Text;

            if (!CheckNameChucVu()) return;

            if (string.IsNullOrEmpty(namechucvu))
            {
                XtraMessageBox.Show("Chưa tiền tên chức vụ, vui lòng xem lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int IdChucVu = Convert.ToInt32(IdChucVuTextEdit.Value);
            ChucVu chucVu = db_quanly.ChucVus.Find(IdChucVu);
            string name_old = chucVu.NameChucVu;
            chucVu.NameChucVu = namechucvu;
            db_quanly.SaveChanges();

            Helper_ShowNoti.ShowThongBao("Thông báo", $"Sửa thông tin chức vụ {name_old} thành {namechucvu} thành công !!! ", SvgImageIcon.Success);

            LoadAllChucVu();
        }
        private bool CheckNameChucVu()
        {
            string namechucvu = NameChucVuTextEdit.Text;

            if (string.IsNullOrEmpty(namechucvu))
            {
                XtraMessageBox.Show("Chưa điền tên chức vụ, vui lòng xem lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var result = db_quanly.ChucVus
                .Select(p => p.NameChucVu).ToList();

            if (result.Contains(namechucvu))
            {
                XtraMessageBox.Show("Chức vụ đã tồn tại, vui lòng kiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DeleteBtnChucVu_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            int IdChucVu = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdChucVu"));
            string NameChucVu = gridView1.GetRowCellValue(selectedRowHandle, "NameChucVu").ToString();

            ChucVu chucvu = db_quanly.ChucVus
                .Where(p => p.IdChucVu == IdChucVu).FirstOrDefault();

            var nhanviens = db_quanly.NhanViens
                    .Where(p => p.IdChucVu == IdChucVu).ToList();

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá chức vụ {NameChucVu} không ?\n" +
                $"⚠️ Lưu ý:\n" +
                $"+ Xóa hết các nhân viên có chức vụ {NameChucVu}\n" +
                $"+ Xóa các hóa đơn liên quan đến nhân viên có chức vụ {NameChucVu}\n" +
                $"+ 🚨 Vui lòng đọc kĩ lưu ý trước khi thao tác !!!!\n", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                foreach(var nhanvien in nhanviens)
                {
                    DeleleNhanVien(nhanvien.IdNhanVien);
                }

                db_quanly.ChucVus.Remove(chucvu);

                db_quanly.SaveChanges();

                Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã xoá chức vụ {NameChucVu} ra khỏi danh sách !!!", SvgImageIcon.Success);
                Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã xoá {nhanviens.Count} nhân viên ra khỏi danh sách !!!", SvgImageIcon.Success);
            }
            LoadAllChucVu();
        }
        private void DeleleNhanVien(int IdNhanVien)
        {
            var hoadon = db_quanly.HoaDons
                .Where(p => p.IdNhanVien == IdNhanVien).ToList();

            foreach (var hoadons in hoadon)
            {
                var chitiethoadon = db_quanly.ChiTietHoaDons
                .Where(p => p.IdHoaDon == hoadons.IdHoaDon).ToList();

                foreach (var item in chitiethoadon)
                {
                    var hoadontopping = db_quanly.HoaDonToppings.
                        Where(p => p.IdChiTietHoaDon == item.IdChiTietHoaDon).ToList();

                    foreach (var topping in hoadontopping)
                    {
                        db_quanly.HoaDonToppings.Remove(topping); // Xóa toppings
                    }

                    db_quanly.ChiTietHoaDons.Remove(item); // Xóa chi tiết hóa đơn
                }

                db_quanly.HoaDons.Remove(hoadons); // Xóa hóa đơn
            }

            var account = db_quanly.Accounts
                .Where(p => p.IdNhanVien == IdNhanVien).FirstOrDefault();
            if (account != null) db_quanly.Accounts.Remove(account); // Xóa account

            var nhanvien = db_quanly.NhanViens
                .Where(p => p.IdNhanVien == IdNhanVien).FirstOrDefault();

            if (nhanvien != null) db_quanly.NhanViens.Remove(nhanvien); //Xóa nhân viên

            db_quanly.SaveChanges();
        }

        private void btnRemoveChucVu_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá các chức vụ không ?\n" +
                $"⚠️ Lưu ý:\n" +
                $"+ Xóa hết các nhân viên có chức vụ được chọn\n" +
                $"+ Xóa các hóa đơn liên quan đến nhân viên có chức vụ được chọn\n" +
                $"+ 🚨 Vui lòng đọc kĩ lưu ý trước khi thao tác !!!!\n", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    int IdChucVu = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdChucVu"));
                    string NameChucVu = gridView1.GetRowCellValue(index, "NameChucVu").ToString();

                    var chucvu = db_quanly.ChucVus
                        .Where(p => p.IdChucVu == IdChucVu).FirstOrDefault();

                    var nhanviens = db_quanly.NhanViens
                        .Where(p => p.IdChucVu == IdChucVu).ToList();

                    foreach(var nhanvien in nhanviens)
                    {
                        DeleleNhanVien(nhanvien.IdNhanVien);
                    }

                    db_quanly.ChucVus.Remove(chucvu);

                    db_quanly.SaveChanges();

                    Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã chức vụ {NameChucVu} !!", Helper_ShowNoti.SvgImageIcon.Success);
                }
                LoadAllChucVu();
            }
        }
    }
}