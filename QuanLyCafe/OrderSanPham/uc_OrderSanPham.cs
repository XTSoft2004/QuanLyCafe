using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QuanLyCafe.OrderSanPham.Form_Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCafe.OrderSanPham.Helper_OrderSanPham;

namespace QuanLyCafe.OrderSanPham
{
    public partial class uc_OrderSanPham : UserControl
    {
        public int IdBan { get; set; }
        public uc_OrderSanPham(int idban)
        {
            InitializeComponent();
            IdBan = idban;
        }

        private void uc_OrderSanPham_Load(object sender, EventArgs e)
        {
            Helper_AddSanPham.FlowLayoutPanel_SanPham = fLayoutSanPham;
            Helper_AddSanPham._ModelAddSanPham = modelOrderSanPhamBindingSource;
            Helper_AddSanPham.Grid_SanPham = gridView1;

            LoadAllSanPham();

            LoadAllDuLieu();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private List<_ModelOrderSanPham> _ModelOrderSanPhams = new List<_ModelOrderSanPham>();
        private void LoadAllSanPham()
        {
            Helper_Project.ClearAllPanel(fLayoutSanPham);

            var list_sanpham = db_quanly.SanPhams
                .Select(p => new { p.IdSanPham, p.NameSanPham, p.GiaSanPham, p.Image })
                .ToList();


            foreach (var item in list_sanpham)
            {
                Helper_AddSanPham addsanpham = new Helper_AddSanPham(ref _ModelOrderSanPhams, item.IdSanPham.ToString(), item.NameSanPham, item.GiaSanPham, item.Image);
                addsanpham.AddPanel();
            }
        }
        private void LoadAllSanPham(List<SanPham> list_sanpham)
        {
            Helper_Project.ClearAllPanel(fLayoutSanPham);

            foreach (var item in list_sanpham)
            {
                Helper_AddSanPham addsanpham = new Helper_AddSanPham(ref _ModelOrderSanPhams, item.IdSanPham.ToString(), item.NameSanPham, item.GiaSanPham, item.Image);
                addsanpham.AddPanel();
            }
        }

        private void AddTopping_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;

            fAddTopping fAddTopping = new fAddTopping(_ModelOrderSanPhams[index].IdSanPham,ref _ModelOrderSanPhams);
            fAddTopping.ShowDialog();

            modelOrderSanPhamBindingSource.DataSource = _ModelOrderSanPhams;
            gridView1.RefreshData();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int row = gridView1.RowCount;
            for (int i = 0; i < row; i++)
            {
                //_ModelOrderSanPhams[i].SoLuong++;
                _ModelOrderSanPhams[i].TongTien = _ModelOrderSanPhams[i].SoLuong * _ModelOrderSanPhams[i].GiaSanPham;

                modelOrderSanPhamBindingSource.DataSource = _ModelOrderSanPhams;
                gridView1.RefreshData();
            }
        }
        public decimal GiaTien_SanPham(int idsanpham)
        {
            var result = db_quanly.SanPhams
                .Where(p=> p.IdSanPham == idsanpham)
                .Select(p => p.GiaSanPham).FirstOrDefault();

            return result;
        }

        private void btnShowVoucher_Click(object sender, EventArgs e)
        {
            fVoucher fVoucher = new fVoucher();
            fVoucher.ShowDialog();
            VoucherCbb.Text = string.IsNullOrEmpty(fVoucher._NameVoucher) ? "Không sử dụng voucher" : fVoucher._NameVoucher;
        }

        private void btnShowKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            fKhachHang.ShowDialog();
            KhachHangCbb.Text = string.IsNullOrEmpty(fKhachHang._NameKhachHang) ? "Không có tên khách hàng" : fKhachHang._NameKhachHang;
        }

        private void btnChooseNV_Click(object sender, EventArgs e)
        {
            fNhanVien fNhanVien = new fNhanVien();
            fNhanVien.ShowDialog();
            NVThanhToanCbb.Text = string.IsNullOrEmpty(fNhanVien.NameNhanVien) ? "Không có tên nhân viên" : fNhanVien.NameNhanVien;
        }
        private void LoadAllDuLieu()
        {
            var list_loaisp = db_quanly.LoaiSanPhams
                .Select(p=> p.NameType)
                .ToList();

            LoaiSanPhamCbb.Properties.Items.Clear();
            foreach (var item in list_loaisp)
            {
                LoaiSanPhamCbb.Properties.Items.Add(item);
            }

            var list_nhanvien = db_quanly.NhanViens
                .Select(p => new { p.IdNhanVien, p.NameNhanVien,p.ChucVu.NameChucVu, })
                .ToList();

            NVThanhToanCbb.Properties.Items.Clear();
            //ComboBoxItemCollection coll = NVThanhToanCbb.Properties.Items;
            //coll.BeginUpdate();
            foreach (var item in list_nhanvien)
            {
                NhanVienThanhToan nhanVienThanhToan = new NhanVienThanhToan(item.IdNhanVien,item.NameNhanVien, item.NameChucVu);
                NVThanhToanCbb.Properties.Items.Add(nhanVienThanhToan);
                //coll.Add(nhanVienThanhToan);
            }
            //coll.EndUpdate();
        }
        private void SearchEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            List<SanPham> result = db_quanly.SanPhams
                .Where(x => x.NameSanPham.Contains(SearchEdit.Text))
                .ToList();

            LoadAllSanPham(result);
        }

        private void LoaiSanPhamCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoaiSanPhamCbb.Text == "Tất cả sản phẩm")
            {
                LoadAllSanPham();
            }
            else
            {
                List<SanPham> result = db_quanly.SanPhams
                    .Where(x => x.LoaiSanPham.NameType == LoaiSanPhamCbb.Text)
                    .ToList();

                LoadAllSanPham(result);
            }
        }

        private void cbtnTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtnTienMat.Checked == false)
            {
                labelControl5.Enabled = false;
                text_Nhantien.Enabled = false;
                label8.Enabled = false;
            }
            else
            {
                labelControl5.Enabled = true;
                text_Nhantien.Enabled = true;
                label8.Enabled = true;

                cbtnNganHang.Checked = false;
                cbtnMomo.Checked = false;
            }
        }

        private void cbtnMomo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtnMomo.Checked)
            {
                cbtnNganHang.Checked = false;
                cbtnTienMat.Checked = false;
            }
        }

        private void cbtnNganHang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtnNganHang.Checked)
            {
                cbtnTienMat.Checked = false;
                cbtnMomo.Checked = false;
            }
        }
    }
}
