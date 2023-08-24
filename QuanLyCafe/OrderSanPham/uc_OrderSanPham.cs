using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using QuanLyCafe.Helper;
using QuanLyCafe.OrderSanPham.Form_Helper;
using QuanLyCafe.QLHoaDon;
using QuanLyCafe.QLHoaDon;
using QuanLyCafe.QuanLyBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCafe.Helper.Helper_ShowNoti;
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
        public List<_ModelOrderSanPham> _ModelOrderSanPhams = new List<_ModelOrderSanPham>();

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

            fAddTopping fAddTopping = new fAddTopping(_ModelOrderSanPhams[index].IdSanPham, ref _ModelOrderSanPhams);
            fAddTopping.ShowDialog();

            modelOrderSanPhamBindingSource.DataSource = _ModelOrderSanPhams;
            gridView1.RefreshData();

            TinhTongHoaDon();
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
            VoucherSearchLookUp.Text = string.IsNullOrEmpty(fVoucher._NameVoucher) ? "Chọn voucher ( Không bắt buộc )" : fVoucher._NameVoucher;
            LoadAllDuLieu();
        }

        private void btnShowKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            fKhachHang.ShowDialog();
            KhachHangSearchLookUp.Text = string.IsNullOrEmpty(fKhachHang._NameKhachHang) ? "Chọn khách hàng ( Không bắt buộc )" : fKhachHang._NameKhachHang;
            LoadAllDuLieu();
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


            var list_voucher = db_quanly.Vouchers
                .Select(p => new { p.IdVoucher,p.NameVoucher, p.SoLuongSuDung })
                .ToList();

            VoucherSearchLookUp.Properties.DataSource = list_voucher;

            var list_khachhang = db_quanly.KhachHangs
                .Select(p => new { p.IdKhachHang,p.NameKhachHang, p.Phone,p.Email })
                .ToList();

            KhachHangSearchLookUp.Properties.DataSource = list_khachhang;
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

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator && e.RowHandle > 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            uc_QuanLyBan uc_QuanLyBan = new uc_QuanLyBan();
            Helper_Project.ShowFormUC(uc_QuanLyBan);
        }
        public bool TinhTongHoaDon()
        {
            decimal sum_hoadon = 0;
            for(int i = 0;i < _ModelOrderSanPhams.Count;i++)
            {
                decimal GiaTriSanPham = _ModelOrderSanPhams[i].GiaSanPham * _ModelOrderSanPhams[i].SoLuong;
                sum_hoadon += GiaTriSanPham;
                if (_ModelOrderSanPhams[i]._list_toppings != null)
                {
                    var toppings = _ModelOrderSanPhams[i]._list_toppings;
                    foreach (var topp in toppings)
                    {
                        sum_hoadon += topp.GiaTopping;
                    }
                }
            }
            sum_hoadon *= 1 - (num_Thue.Value / 100);

            int giamgia = VoucherSearchLookUp.EditValue == null ? -1 : Convert.ToInt32(VoucherSearchLookUp.EditValue);

            sum_hoadon *= 1 - (GET_VOUCHER(giamgia) / 100);

            lbTongTien.Text = Helper_Project.ChuyenDoiGiaTriTien(sum_hoadon) + " VNĐ";

            SoluongSanPham.Text = $"{gridView1.RowCount} sản phẩm";

            //if(cbtnTienMat.Checked == false)
            //{
            //    XtraMessageBox.Show("Chưa chọn thanh toán tiền mặt !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //if(NVThanhToanCbb.Text == "Không có tên nhân viên")
            //{
            //    XtraMessageBox.Show("Bạn chưa chọn nhân viên thanh toán hóa đơn !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }
        private decimal GET_VOUCHER(int idvoucher)
        {
            if(idvoucher < 0) return 0;

            var discount = db_quanly.Vouchers
                .Where(p=> p.IdVoucher == idvoucher)
                .Select(p=> p.Discount)
                .FirstOrDefault();

            return discount;
        }
        private bool KiemTraThanhToan()
        {
            if (NVThanhToanCbb.Text == "Không có tên nhân viên")
            {
                Helper_ShowNoti.ShowThongBao("Thông báo", "Chưa chọn nhân viên thanh toán hóa đơn !!", Helper_ShowNoti.SvgImageIcon.Error);
                //XtraMessageBox.Show("Chưa chọn nhân viên thanh toán hóa đơn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(gridView1.RowCount == 0)
            {
                Helper_ShowNoti.ShowThongBao("Thông báo", "Chưa thêm sản phẩm, vui lòng xem lại !!!", Helper_ShowNoti.SvgImageIcon.Error);
                //XtraMessageBox.Show("Chưa thêm sản phẩm, vui lòng xem lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (text_Nhantien.Text == "")
            {
                Helper_ShowNoti.ShowThongBao("Thông báo", "Chưa nhập tiền khách đưa, vui lòng xem lại !!!", Helper_ShowNoti.SvgImageIcon.Error);
                //XtraMessageBox.Show("Chưa nhập tiền khách đưa, vui lòng xem lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal tiennhan = Convert.ToDecimal(text_Nhantien.Text);
            decimal tongtien = Convert.ToDecimal(lbTongTien.Text.Replace(" VNĐ",""));

            if (tiennhan < tongtien)
            {
                Helper_ShowNoti.ShowThongBao("Thông báo", $"Tiền khách đưa thiếu {tongtien - tiennhan} VNĐ, vui lòng kiểm tra lại nhé !!", Helper_ShowNoti.SvgImageIcon.Error);
                //XtraMessageBox.Show($"Tiền khách đưa thiếu {tongtien - tiennhan} VNĐ, vui lòng kiểm tra lại nhé !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            TinhTongHoaDon();

            if (VoucherSearchLookUp.EditValue != null)
            {
                int idvoucher = Convert.ToInt32(VoucherSearchLookUp.EditValue);
                Voucher voucher = db_quanly.Vouchers
                    .Where(p => p.IdVoucher == idvoucher)
                    .FirstOrDefault();

                if (voucher.SoLuongSuDung <= 0)
                {
                    XtraMessageBox.Show($"Voucher {voucher.NameVoucher} đã hết lượt sử dụng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if (!KiemTraThanhToan() || TinhTongHoaDon() == false)
            {
                return;
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Đang chờ thanh toán ....");
            Thread.Sleep(3000);

            List<_ModelChiTietHoaDon> listsanpham = new List<_ModelChiTietHoaDon>();
            for (int index = 0; index < gridView1.RowCount; index++)
            {
                int idsanpham = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdSanPham"));
                _ModelChiTietHoaDon sanPham = new _ModelChiTietHoaDon()
                {
                    IdSanPham = idsanpham,
                    NameSanPham = gridView1.GetRowCellValue(index, "NameSanPham").ToString(),
                    SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(index, "SoLuong")),
                    GiaSanPham = Convert.ToDecimal(gridView1.GetRowCellValue(index, "GiaSanPham")),
                    GhiChu = gridView1.GetRowCellValue(index, "GhiChu").ToString(),
                    _listtoppings = _ModelOrderSanPhams.Find(p => p.IdSanPham == idsanpham)._list_toppings,
                };
                listsanpham.Add(sanPham);
            }

            //string NameBan = db_quanly.QLBans.Find(IdBan).NameBan;
            int idNhanVien = NVThanhToanCbb.Text == "Không có tên nhân viên" ? -1 : Convert.ToInt32(NVThanhToanCbb.Text.Split('_')[0]);
            int idKhachHang = KhachHangSearchLookUp.EditValue == null ? -1 : Convert.ToInt32(KhachHangSearchLookUp.EditValue);
            int idVoucher = VoucherSearchLookUp.EditValue == null ? -1 : Convert.ToInt32(VoucherSearchLookUp.EditValue);
            decimal NhanTien = Convert.ToDecimal(text_Nhantien.Text);
            decimal TongTien = Convert.ToDecimal(lbTongTien.Text.Replace(" VNĐ",""));

            string DatDoUong = string.Empty;
            if (rbMangVe.Checked) DatDoUong = "Mang về";
            else if (rbTaiQuan.Checked) DatDoUong = "Tại quán";
            ThanhToan thanhtoan = new ThanhToan(IdBan, idNhanVien, idKhachHang, idVoucher, NhanTien, TongTien, num_Thue.Value, listsanpham, DatDoUong);
            thanhtoan.ThanhToanHoaDon();

            SplashScreenManager.CloseForm();
        }
        public class ThanhToan
        {         
            public List<_ModelChiTietHoaDon> _ListSanPham = new List<_ModelChiTietHoaDon> ();
            public int IdBan { get; set; }
            public int IdNhanVien { get; set; }
            public int? IdKhachHang { get; set; }
            public int? IdVoucher { get; set; }
            public decimal TienNhan { get; set; }
            public decimal TongTien { get; set; }
            public decimal Thue { get; set; }
            public string DatDoUong { get; set; }
            QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
            public ThanhToan(int idBan, int idNhanVien, int? idKhachHang, int? idVoucher, decimal tienNhan, decimal tongTien, decimal thue, List<_ModelChiTietHoaDon> _listsanpham,string datdouong)
            {
                IdBan = idBan;
                IdNhanVien = idNhanVien;
                IdKhachHang = idKhachHang == -1 ? null : idKhachHang;
                IdVoucher = idVoucher == -1 ? null : idVoucher;
                TienNhan = tienNhan;
                TongTien = tongTien;
                Thue = thue;
                _ListSanPham = _listsanpham;
                DatDoUong = datdouong;
            }
            public void ThanhToanHoaDon()
            {
                string dateTimeString = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                DateTime dateTime = DateTime.ParseExact(dateTimeString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                decimal? TotalCost = 0;
                HoaDon hoaDon = new HoaDon()
                {
                    IdNhanVien = IdNhanVien,
                    IdKhachHang = IdKhachHang,
                    IdVoucher = IdVoucher,
                    IdBan = IdBan,
                    NgayMua = dateTime,
                    TienNhan = TienNhan,
                    TongTien = TongTien,
                    Thue = Thue,
                    DatDoUong = DatDoUong,
                };

                if(IdVoucher != null)
                {
                    Voucher voucher = db_quanly.Vouchers
                        .Where(p => p.IdVoucher == IdVoucher)
                        .FirstOrDefault();
                    voucher.SoLuongSuDung = voucher.SoLuongSuDung - 1;
                    db_quanly.SaveChanges();
                }

                db_quanly.HoaDons.Add(hoaDon);
                db_quanly.SaveChanges();

                int idHoaDon = db_quanly.HoaDons
                    .Where(p => p.NgayMua == dateTime)
                    .Select(p => p.IdHoaDon)
                    .FirstOrDefault();

                for (int rows = 0;rows < _ListSanPham.Count; rows++)
                {
                    var sanphams = _ListSanPham[rows];
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                    {
                        IdHoaDon = idHoaDon,
                        IdSanPham = sanphams.IdSanPham,
                        SoLuong = sanphams.SoLuong,
                        GiaSanPham = sanphams.GiaSanPham,
                        GhiChu = sanphams.GhiChu,
                    };
                    db_quanly.ChiTietHoaDons.Add(chiTietHoaDon);
                    db_quanly.SaveChanges();
                    TotalCost += db_quanly.SanPhams
                        .Where(p=> p.IdSanPham == sanphams.IdSanPham)
                        .Select(p=> p.Cost).FirstOrDefault() * _ListSanPham[rows].SoLuong; // Tính cost của sản phẩm

                    int idchitiethoadon = db_quanly.ChiTietHoaDons
                        .Where(p=> p.IdHoaDon == idHoaDon && p.IdSanPham == sanphams.IdSanPham && p.SoLuong == sanphams.SoLuong)
                        .Select(p => p.IdChiTietHoaDon)
                        .FirstOrDefault();

                    if(_ListSanPham[rows]._listtoppings != null)
                    {
                        var toppings = _ListSanPham[rows]._listtoppings;
                        foreach (var item in toppings)
                        {
                            HoaDonTopping hoaDonTopping = new HoaDonTopping()
                            {
                                IdTopping = item.IdTopping,
                                NameTopping = item.NameTopping,
                                GiaTopping = item.GiaTopping,
                                IdChiTietHoaDon = idchitiethoadon,
                            };
                            db_quanly.HoaDonToppings.Add(hoaDonTopping);
                            TotalCost += item.Cost == null ? 0 : item.Cost * _ListSanPham[rows].SoLuong; // Tính cost của toppings
                        }
                    }
                    db_quanly.SaveChanges();
                }
                hoaDon.TotalCost = TotalCost;
                db_quanly.SaveChanges();

                var list_hoadon = db_quanly.HoaDons
                    .Where(p => p.NgayMua == dateTime)
                    .FirstOrDefault();

                List<_ModelHoaDon> _ModelHoaDons = new List<_ModelHoaDon>();

                _ModelHoaDon _Hoadon = uc_HoaDon.ImportHoaDon(list_hoadon, ref _ModelHoaDons);

                ReportPhaChe fBaocao = new ReportPhaChe();
                fBaocao.DataSource = _ModelHoaDons;
                ReportPrintTool tool = new ReportPrintTool(fBaocao);
                tool.ShowRibbonPreview();

                ReportHoaDon fHoadon = new ReportHoaDon();
                fHoadon.DataSource = _ModelHoaDons;
                ReportPrintTool tool123 = new ReportPrintTool(fHoadon);
                tool123.ShowRibbonPreview();

                var NhanVien = db_quanly.NhanViens.Find(IdNhanVien);

                CafeLog.SaveLog($"Mã hóa đơn: {list_hoadon.IdHoaDon} | {NhanVien.NameNhanVien} đã thanh toán hóa đơn {TongTien} VNĐ | Trạng thái: Thành công");

                Helper_ShowNoti.ShowThongBao("Thanh toán hóa đơn", $"Thanh toán thành công {_ListSanPham.Count} sản phẩm !", Helper_ShowNoti.SvgImageIcon.Success);
            }
        }

        private void btnSumHoaDon_Click(object sender, EventArgs e)
        {
            TinhTongHoaDon();
        }

        private void DeleteSanPham_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;

            int IdSanPham = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdSanPham"));

            _ModelOrderSanPham order = Helper_AddSanPham._ListOrder
                .Where(p => p.IdSanPham == IdSanPham)
                .FirstOrDefault();
            Helper_AddSanPham._ListOrder.Remove(order);

            modelOrderSanPhamBindingSource.DataSource = Helper_AddSanPham._ListOrder;
            gridView1.RefreshData();

        }

        private void NVThanhToanCbb_EditValueChanged(object sender, EventArgs e)
        {
            TinhTongHoaDon();
        }

        private void VoucherSearchLookUp_EditValueChanged(object sender, EventArgs e)
        {
            TinhTongHoaDon();
        }

        private void num_Thue_ValueChanged(object sender, EventArgs e)
        {
            TinhTongHoaDon();
        }

        private void gridControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            TinhTongHoaDon();
        }
    }
}
