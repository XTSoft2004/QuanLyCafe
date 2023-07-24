using DevExpress.XtraEditors;
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
    public partial class fVoucher : DevExpress.XtraEditors.XtraForm
    {
        public fVoucher()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void fVoucher_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }
        private void LoadAllData()
        {
            var result = db_quanly.Vouchers
                .Select(p=> new {p.IdVoucher,p.NameVoucher,p.Discount,p.SoLuongSuDung})
                .ToList();

            voucherBindingSource.DataSource = result;
            gridView1.RefreshData();
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameVoucherTextEdit.Text))
            {
                XtraMessageBox.Show("Bạn chưa điền tên voucher, vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(DiscountSpinEdit.Text) || DiscountSpinEdit.Value <= 0)
            {
                XtraMessageBox.Show("Bạn chưa điền giảm giá, vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(SoLuongSuDungSpinEdit.Text) || SoLuongSuDungSpinEdit.Value <= 0)
            {
                XtraMessageBox.Show("Bạn chưa số lượt sử dụng voucher, vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Voucher voucher = new Voucher()
            {
                NameVoucher = NameVoucherTextEdit.Text,
                Discount = DiscountSpinEdit.Value,
                SoLuongSuDung = Convert.ToInt32(SoLuongSuDungSpinEdit.Value),
            };

            db_quanly.Vouchers.Add(voucher);
            db_quanly.SaveChanges();

            XtraMessageBox.Show($"Thêm voucher {NameVoucherTextEdit.Text} thành công !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadAllData();
        }

        private void btnEditVoucher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdVoucherSpinEdit.Value);

            Voucher voucher = db_quanly.Vouchers.Find(id);
            voucher.NameVoucher = NameVoucherTextEdit.Text;
            voucher.Discount = DiscountSpinEdit.Value;
            voucher.SoLuongSuDung = Convert.ToInt32(SoLuongSuDungSpinEdit.Value);
            db_quanly.SaveChanges();

            XtraMessageBox.Show($"Chỉnh sửa voucher {NameVoucherTextEdit.Text} thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllData();
        }

        private void btnDeleteVoucher_Click(object sender, EventArgs e)
        {
            var result = db_quanly.Vouchers.ToList();

            foreach (var voucher in result)
            {
                db_quanly.Vouchers.Remove(voucher);
            }
            db_quanly.SaveChanges();

            XtraMessageBox.Show($"Đã xoá tất cả voucher !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string IdVoucher = gridView1.GetRowCellValue(selectedRowHandle, "IdVoucher").ToString();
            string NameVoucher = gridView1.GetRowCellValue(selectedRowHandle, "NameVoucher").ToString();

            int id = Convert.ToInt32(IdVoucher);

            Voucher voucher = db_quanly.Vouchers.Find(id);

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá voucher {NameVoucher} không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db_quanly.Vouchers.Remove(voucher);
                db_quanly.SaveChanges();
                XtraMessageBox.Show($"Đã xoá voucher {NameVoucher} ra khỏi danh sách !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllData();
            }
        }
        public string _NameVoucher { get; set; }
        private void ChooseVoucher_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string IdVoucher = gridView1.GetRowCellValue(selectedRowHandle, "IdVoucher").ToString();
            string NameVoucher = gridView1.GetRowCellValue(selectedRowHandle, "NameVoucher").ToString();

            if (XtraMessageBox.Show($"Bạn chắc chắn chọn khách hàng {NameVoucher}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _NameVoucher = IdVoucher + "_" + NameVoucher;
                this.Close();
            }
        }
    }
}