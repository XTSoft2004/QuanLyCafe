using DevExpress.XtraEditors;
using QuanLy;
using QuanLyCafe.Helper;
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
                Helper_ShowNoti.ShowThongBao("Kiểm tra thông tin", $"Bạn chưa điền tên nhân viên !!!", Helper_ShowNoti.SvgImageIcon.Success);
                return false;
            }
            if (string.IsNullOrEmpty(NameChucVuCbb.Text) || NameChucVuCbb.Text == "")
            {
                Helper_ShowNoti.ShowThongBao("Kiểm tra thông tin", $"Bạn chưa chọn chức vụ cho nhận viên !!!", Helper_ShowNoti.SvgImageIcon.Success);
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

            Helper_ShowNoti.ShowThongBao("Chỉnh sửa thông tin nhân viên", $"Chỉnh sửa nhân viên {namenhanvien} thành công", Helper_ShowNoti.SvgImageIcon.Success);

            LoadAllDB();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có muốn xoá {indexSelected.Length} nhân viên không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    string IdNhanVien = gridView1.GetRowCellValue(index, "IdNhanVien").ToString();
                    string NameNhanVien = gridView1.GetRowCellValue(index, "NameNhanVien").ToString();
                    int id = Convert.ToInt32(IdNhanVien);

                    NhanVien topping = db_quanly.NhanViens.Find(id);

                    db_quanly.NhanViens.Remove(topping);

                    Helper_ShowNoti.ShowThongBao("Xóa nhân viên", $"Xóa nhân viên {NameNhanVien} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);
                }

                db_quanly.SaveChanges();

                LoadAllDB();
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
    }
}
