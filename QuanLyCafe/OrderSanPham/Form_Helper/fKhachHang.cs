using DevExpress.XtraEditors;
using QuanLyCafe;
using QuanLyCafe.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.OrderSanPham.Form_Helper
{
    public partial class fKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void LoadAllData(List<KhachHang> result)
        {
            khachHangBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private void LoadAllData()
        {
            var result = db_quanly.KhachHangs
                .Select(p => new { p.IdKhachHang, p.NameKhachHang, p.Phone, p.Email })
                .ToList();

            khachHangBindingSource.DataSource = result;
            gridView1.RefreshData();
        }

        private void text_SearchKhachHang_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var result = db_quanly.KhachHangs
                .Where(p => p.NameKhachHang.Contains(text_SearchKhachHang.Text))
                //.Select(p => new { p.IdKhachHang, p.NameKhachHang, p.Phone, p.Email })
                .ToList();

            LoadAllData(result);
        }

        private void DeleteKhachHang_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string IdKhachHang = gridView1.GetRowCellValue(selectedRowHandle, "IdKhachHang").ToString();
            string NameKhachHang = gridView1.GetRowCellValue(selectedRowHandle, "NameKhachHang").ToString();

            int id = Convert.ToInt32(IdKhachHang);

            KhachHang voucher = db_quanly.KhachHangs.Find(id);

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá khách hàng {NameKhachHang} không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db_quanly.KhachHangs.Remove(voucher);
                db_quanly.SaveChanges();
                Helper_ShowNoti.ShowThongBao($"Đã xoá khách hàng {NameKhachHang} ra khỏi danh sách !!!", "Thông báo", Helper_ShowNoti.SvgImageIcon.Success);
                LoadAllData();
            }
        }
        public string _NameKhachHang { get; set; }
        private void ChooseKhachHang_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string IdKhachHang = gridView1.GetRowCellValue(selectedRowHandle, "IdKhachHang").ToString();
            string NameKhachHang = gridView1.GetRowCellValue(selectedRowHandle, "NameKhachHang").ToString();

            if (XtraMessageBox.Show($"Bạn chắc chắn chọn khách hàng {NameKhachHang}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _NameKhachHang = IdKhachHang + "_" + NameKhachHang;
                this.Close();
            }
        }
        private bool CheckThongTinKhachHang()
        {
            if (string.IsNullOrEmpty(NameKhachHangTextEdit.Text))
            {
                Helper_ShowNoti.ShowXtraMessageBox($"Chưa nhập tên khách hàng, vui lòng kiểm tra lại", "Thông báo", Helper_ShowNoti.IconXtraMessageBox.Error);
                return false;
            }
            return true;
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (!CheckThongTinKhachHang()) return;

            KhachHang khachHang = new KhachHang()
            {
                NameKhachHang = NameKhachHangTextEdit.Text,
                Phone = PhoneTextEdit.Text,
                Email = EmailTextEdit.Text,
            };

            db_quanly.KhachHangs.Add(khachHang);
            db_quanly.SaveChanges();

            Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã thêm khách hàng {NameKhachHangTextEdit.Text} vào dữ liệu !!", Helper_ShowNoti.SvgImageIcon.Success);
            LoadAllData();
        }

        private void btnEditKhachHang_Click(object sender, EventArgs e)
        {
            if (!CheckThongTinKhachHang()) return;

            int selectedRowHandle = gridView1.FocusedRowHandle;

            string IdKhachHang = gridView1.GetRowCellValue(selectedRowHandle, "IdKhachHang").ToString();

            KhachHang khachHang = db_quanly.KhachHangs.Find(Convert.ToInt32(IdKhachHang));
            khachHang.NameKhachHang = NameKhachHangTextEdit.Text;
            khachHang.Email = EmailTextEdit.Text;
            khachHang.Phone = PhoneTextEdit.Text;

            db_quanly.SaveChanges();

            Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã chỉnh sửa khách hàng {NameKhachHangTextEdit.Text} !!", Helper_ShowNoti.SvgImageIcon.Success);
            LoadAllData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var result = db_quanly.KhachHangs.ToList();

            foreach (var item in result)
            {
                db_quanly.KhachHangs.Remove(item);
            }

            Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã xoá toàn bộ khách hàng !!!", Helper_ShowNoti.SvgImageIcon.Success);
            LoadAllData();
        }
    }
}