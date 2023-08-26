using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QuanLyCafe.Helper;
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

namespace QuanLyCafe.QLHoaDon
{
    public partial class uc_HoaDon : UserControl
    {
        public uc_HoaDon()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        public List<_ModelHoaDon> _ModelHoaDons = new List<_ModelHoaDon>();
        private void LoadAllHoaDon()
        {
            var list_hoadon = db_quanly.HoaDons
                        .OrderByDescending(log => log.NgayMua)
                        .ToList();

            _ModelHoaDons = new List<_ModelHoaDon>();

            foreach(var item in list_hoadon)
            {
                ImportHoaDon(item,ref _ModelHoaDons);
            }

            modelHoaDonBindingSource.DataSource = _ModelHoaDons;
            gridView1.RefreshData();
        }
        public static _ModelHoaDon ImportHoaDon(HoaDon _hoadon,ref List<_ModelHoaDon> _ModelHoaDons) 
        {
            QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
            string NameKhachHang = _hoadon.KhachHang == null ? "Không có khách hàng" : _hoadon.KhachHang.NameKhachHang;
            string NameVoucher = _hoadon.Voucher == null ? "Không sử dụng voucher" : _hoadon.Voucher.NameVoucher;
            //string NameNhanVien = _hoadon?.NhanVien?.NameNhanVien == null ? "" : _hoadon.QLBan.NameBan;
            //string Nameban = _hoadon?.QLBan?.NameBan == null ? "" : _hoadon.QLBan.NameBan;

            _ModelHoaDon hoadon = new _ModelHoaDon()
            {
                IdHoaDon = _hoadon.IdHoaDon,
                NameNhanVien = _hoadon?.NhanVien?.NameNhanVien,
                NameBan = _hoadon?.QLBan?.NameBan,
                NameKhachHang = NameKhachHang,
                NameVoucher = NameVoucher,
                NgayMua = _hoadon.NgayMua,
                TienNhan = _hoadon.TienNhan,
                TotalCost = _hoadon?.TotalCost,
                TongTien = _hoadon.TongTien,
                Thue = _hoadon.Thue,
                DatDoUong = _hoadon.DatDoUong,
            };

            var list_chitiethoadon = db_quanly.ChiTietHoaDons
                .Where(p => p.IdHoaDon == hoadon.IdHoaDon)
                .ToList();
            List<_ModelChiTietHoaDon> _ModelChiTietHoaDons = new List<_ModelChiTietHoaDon>();

            foreach (var chitiet in list_chitiethoadon)
            {
                _ModelChiTietHoaDon chitiethoadon = new _ModelChiTietHoaDon()
                {
                    IdChiTietHoaDon = chitiet.IdChiTietHoaDon,
                    IdSanPham = chitiet.IdSanPham,
                    NameSanPham = chitiet.SanPham.NameSanPham,
                    SoLuong = chitiet.SoLuong,
                    GiaSanPham = chitiet.GiaSanPham,
                    GhiChu = chitiet.GhiChu,
                };

                var list_toppings = db_quanly.HoaDonToppings
                    .Where(p => p.IdChiTietHoaDon == chitiethoadon.IdChiTietHoaDon)
                    .ToList();

                List<_ModelTopping> _ModelToppings = new List<_ModelTopping>();
                foreach (var toppings in list_toppings)
                {
                    _ModelTopping _chitiettoppings = new _ModelTopping()
                    {
                        IdTopping = toppings.IdTopping,
                        NameTopping = toppings.NameTopping,
                        GiaTopping = toppings.GiaTopping,
                        Cost = toppings.Topping.Cost,
                    };
                    _ModelToppings.Add(_chitiettoppings);
                }
                chitiethoadon._listtoppings = _ModelToppings;

                _ModelChiTietHoaDons.Add(chitiethoadon);
            }

            hoadon._listChiTietHoaDon = _ModelChiTietHoaDons;

            _ModelHoaDons.Add(hoadon);

            return hoadon;
        }
        private void HoaDon_Click(object sender, EventArgs e)
        {
            ShowPdfHoaDon();
        }

        private void uc_HoaDon_Load(object sender, EventArgs e)
        {
            if (!uc_TongQuat.InfoLogin.isAdmin)
            {
                btnDeleteHoaDon.Visible = false;
            }

            LoadAllHoaDon();
        }

        private void documentViewer1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ShowPdfHoaDon();
        }
        private void ShowPdfHoaDon()
        {
            int IdHoaDon = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoaDon"));
            var hoadon = _ModelHoaDons.Where(p => p.IdHoaDon == IdHoaDon).ToList();
            System.IO.Directory.CreateDirectory("PDF_HOADON");
            //string NameFile = Application.StartupPath + "\\PDF_HOADON\\HoaDon_" + DateTime.Now.ToString("dd-MM-yyyy HH.mm.ss") + ".pdf";

            string NameFile = Application.StartupPath + $"\\PDF_HOADON\\HoaDon_{IdHoaDon}_{DateTime.Now.ToString("dd-MM-yyyy")}.pdf";
            ReportHoaDon fBaocao = new ReportHoaDon();
            fBaocao.DataSource = hoadon;
            fBaocao.ExportToPdf(NameFile);
            documentViewer1.DocumentSource = fBaocao;
            documentViewer1.Show();
        }
        private void ShowPDFPhaChe()
        {
            int IdHoaDon = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoaDon"));

            var hoadon = _ModelHoaDons.Where(p => p.IdHoaDon == IdHoaDon).ToList();

            System.IO.Directory.CreateDirectory("PDF_HOADON");
            string NameFile = Application.StartupPath + "\\PDF_HOADON\\PhaChe_" + DateTime.Now.ToString("dd-MM-yyyy HH.mm.ss") + ".pdf";
            //fBaoCao fBaocao = new fBaoCao(hoadon);
            //fBaocao.DataSource = hoadon;
            //ReportPrintTool tool = new ReportPrintTool(fBaocao);
            //tool.ShowRibbonPreview();

            ReportPhaChe fBaocao = new ReportPhaChe();
            fBaocao.DataSource = hoadon;
            fBaocao.ExportToPdf(NameFile);
            documentViewer1.DocumentSource = fBaocao;
            documentViewer1.Show();
        }
        private void PhaChe_Click(object sender, EventArgs e)
        {
            ShowPDFPhaChe();
        }

        private void DeleteHoaDon_Click(object sender, EventArgs e)
        {
            int IdHoaDon = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoaDon"));
            string title_remove = $"Bạn xóa hóa đơn với ID:{IdHoaDon}\n" +
                $"=> Lưu ý:\n" +
                $" + Sẽ xóa hết dữ liệu liên quan đến hóa đơn\n" +
                $" + Sẽ xóa hết dữ liệu liên quan đến chi tiết hóa đơn\n" +
                $" + Sẽ xóa hết dữ liệu liên quen đến hóa đơn toppings\n";


            if (XtraMessageBox.Show(title_remove, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var hoadon = db_quanly.HoaDons.Where(p => p.IdHoaDon == IdHoaDon).FirstOrDefault();

                var chitiethoadon = db_quanly.ChiTietHoaDons
                    .Where(p => p.IdHoaDon == IdHoaDon).ToList();

                foreach(var item in chitiethoadon)
                {
                    var hoadontopping = db_quanly.HoaDonToppings.
                        Where(p => p.IdChiTietHoaDon == item.IdChiTietHoaDon).ToList();

                    foreach(var topping  in hoadontopping)
                    {
                        db_quanly.HoaDonToppings.Remove(topping);
                    }

                    db_quanly.ChiTietHoaDons.Remove(item);

                }

                db_quanly.HoaDons.Remove(hoadon);
            }

            db_quanly.SaveChanges();
            Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã xóa hóa đơn {IdHoaDon} ra khỏi hệ thống", Helper_ShowNoti.SvgImageIcon.Success);

            LoadAllHoaDon();
        }
    }
}
