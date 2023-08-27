using DevExpress.Emf;
using DevExpress.XtraEditors;
using QuanLy;
using QuanLyCafe.Helper;
using QuanLyCafe.OrderSanPham.Form_Helper;
using QuanLyCafe.QLHoaDon;
using QuanLyCafe.TongQuan;
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
                XtraMessageBox.Show($"Bạn chưa điền tên nhân viên !!!", "Kiểm tra thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Helper_ShowNoti.ShowThongBao("Kiểm tra thông tin", $"Bạn chưa điền tên nhân viên !!!", Helper_ShowNoti.SvgImageIcon.Success);
                return false;
            }
            if (string.IsNullOrEmpty(NameChucVuCbb.Text) || NameChucVuCbb.Text == "")
            {
                XtraMessageBox.Show($"Bạn chưa chọn chức vụ cho nhận viên !!!", "Kiểm tra thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Helper_ShowNoti.ShowThongBao("Kiểm tra thông tin", $"Bạn chưa chọn chức vụ cho nhận viên !!!", Helper_ShowNoti.SvgImageIcon.Success);
                return false;
            }

            return true;
        }
        private void LoadAllNhanVien()
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
            if (!uc_TongQuat.InfoLogin.isAdmin)
            {
                Helper_ShowNoti.ShowXtraMessageBox("Xin lỗi, chỉ có admin mới vào được tính năng này !!!","Thông báo", Helper_ShowNoti.IconXtraMessageBox.Error);
                this.Hide();
            }

            LoadChucVu(); // Lấy thông tin chức vụ từ bản chức vụ

            LoadAllNhanVien();
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

            Helper_ShowNoti.ShowThongBao("Thêm nhân viên", $"Thêm nhân viên {NameNhanVienTextEdit.Text} vào hệ thống", Helper_ShowNoti.SvgImageIcon.Success);
            LoadAllNhanVien();
        }

        private void btnShowChucVu_Click(object sender, EventArgs e)
        {
            fChucVu fChucVu = new fChucVu();
            fChucVu.ShowDialog();

            LoadChucVu();
            LoadAllNhanVien();
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

            Helper_ShowNoti.ShowThongBao("Chỉnh sửa thông tin nhân viên", $"Chỉnh sửa nhân viên {namenhanvien} thành công", Helper_ShowNoti.SvgImageIcon.Success);

            LoadAllNhanVien();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có muốn xoá {indexSelected.Length} nhân viên không ?\n" +
                $"⚠️ Lưu ý sẽ bị xóa vài thứ:\n" +
                $"+ Xóa các hóa đơn liên quan đến nhân viên bạn chọn\n" +
                $"+ Xóa account của nhân viên bạn chọn\n" +
                $"🚨 Vui lòng đọc kĩ lưu ý trước khi thao tác !!!!\n", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    int IdNhanVien = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdNhanVien"));
                    string NameNhanVien = gridView1.GetRowCellValue(index, "NameNhanVien").ToString();

                    DeleteNhanVien(IdNhanVien); // Xóa nhân viên

                    Helper_ShowNoti.ShowThongBao("Xóa nhân viên", $"Xóa nhân viên {NameNhanVien} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);
                }

                db_quanly.SaveChanges();

                LoadAllNhanVien();
            }
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            int idnhanvien = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdNhanVien"));
            string namenhanvien = gridView1.GetRowCellValue(index, "NameNhanVien").ToString();

            CreateAccount createAccount = new CreateAccount(idnhanvien);
            createAccount.ShowDialog();

        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            int idnhanvien = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdNhanVien"));
            string namenhanvien = gridView1.GetRowCellValue(index, "NameNhanVien").ToString();

            if (XtraMessageBox.Show($"Bạn có muốn account của {namenhanvien} không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var account = db_quanly.Accounts
                    .Where(p => p.IdNhanVien == idnhanvien).FirstOrDefault();

                if (account != null)
                {
                    db_quanly.Accounts.Remove(account);
                    db_quanly.SaveChanges();
                    Helper_ShowNoti.ShowThongBao("Thông báo", $"Xóa account nhân viên {namenhanvien} ra khỏi hệ thống", Helper_ShowNoti.SvgImageIcon.Success);
                }
                else
                {
                    Helper_ShowNoti.ShowXtraMessageBox($"Không tồn tại account {namenhanvien}, vui lòng kiểm tra lại !!", "Thông báo", Helper_ShowNoti.IconXtraMessageBox.Error);
                }
            }

            LoadAllNhanVien();
        }
        public void DeleteNhanVien(int IdNhanVien)
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
    }
}
