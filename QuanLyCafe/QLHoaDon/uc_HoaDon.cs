using DevExpress.XtraReports.UI;
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
            var list_hoadon = db_quanly.HoaDons.ToList();

            _ModelHoaDons = new List<_ModelHoaDon>();

            foreach(var item in list_hoadon)
            {
                string NameKhachHang = item.KhachHang == null ? "Không có khách hàng" : item.KhachHang.NameKhachHang;
                string NameVoucher = item.Voucher == null ? "Không sử dụng voucher" : item.Voucher.NameVoucher;
                _ModelHoaDon hoadon = new _ModelHoaDon()
                {
                    IdHoaDon = item.IdHoaDon,
                    NameNhanVien = item.NhanVien.NameNhanVien,
                    NameKhachHang = NameKhachHang,
                    NameBan = item.QLBan.NameBan,
                    NameVoucher = NameVoucher,
                    NgayMua = item.NgayMua,
                    TienNhan = item.TienNhan,
                    TongTien = item.TongTien,
                    Thue = item.Thue,
                };

                var list_chitiethoadon = db_quanly.ChiTietHoaDons
                    .Where(p=> p.IdHoaDon == hoadon.IdHoaDon)
                    .ToList();
                List<_ModelChiTietHoaDon> _ModelChiTietHoaDons = new List<_ModelChiTietHoaDon>();

                foreach(var chitiet in list_chitiethoadon)
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
                        };
                        _ModelToppings.Add(_chitiettoppings);
                    }
                    chitiethoadon._listtoppings = _ModelToppings;

                    _ModelChiTietHoaDons.Add(chitiethoadon);
                }

                hoadon._listChiTietHoaDon = _ModelChiTietHoaDons;

                _ModelHoaDons.Add(hoadon);
            }

            modelHoaDonBindingSource.DataSource = _ModelHoaDons;
            gridView1.RefreshData();
        }
        private void HoaDon_Click(object sender, EventArgs e)
        {
            int IdHoaDon = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoaDon"));

            var hoadon = _ModelHoaDons.Where(p => p.IdHoaDon == IdHoaDon).ToList();

            //System.IO.Directory.CreateDirectory("PDF_HOADON");
            //string NameFile = Application.StartupPath + "\\PDF_HOADON\\HoaDon_" + DateTime.Now.ToString("dd-MM-yyyy HH.mm.ss") + ".pdf"; 
            fBaoCao fBaocao = new fBaoCao();
            fBaocao.DataSource = hoadon;
            //fBaocao.ExportToPdf(NameFile);

            //pdfViewer1.DocumentFilePath = NameFile;

            ReportPrintTool tool = new ReportPrintTool(fBaocao);
            tool.ShowPreview();

            //pdfViewer1.LoadDocument();

            //documentViewer1.DocumentSource = fBaocao;
        }

        private void uc_HoaDon_Load(object sender, EventArgs e)
        {
            LoadAllHoaDon();
        }
    }
}
