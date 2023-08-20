using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.QLHoaDon
{
    public class _ModelHoaDon
    {
        public int? IdHoaDon { get;set; }
        public string NameNhanVien { get;set; }  
        public string NameKhachHang { get;set; }
        public string NameBan { get;set; }
        public string NameVoucher { get; set; }
        public DateTime? NgayMua { get;set; }    
        public decimal? TienNhan { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? Thue { get; set; }
        public string DatDoUong { get; set; }   
        public List<_ModelChiTietHoaDon> _listChiTietHoaDon { get; set; }
    }
    public class _ModelChiTietHoaDon
    {
        public int IdChiTietHoaDon { get; set; }
        public int IdSanPham { get; set; }
        public string NameSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaSanPham { get; set; }
        public string GhiChu { get; set; }
        public List<_ModelTopping> _listtoppings { get; set; }

}
    public class _ModelTopping
    {
        public int IdTopping { get; set; }
        public string NameTopping { get; set; }
        public decimal GiaTopping { get; set; }
        public decimal? Cost { get; set; }
    }
}
