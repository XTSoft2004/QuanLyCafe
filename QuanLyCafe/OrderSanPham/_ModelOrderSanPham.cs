using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.OrderSanPham
{
    public class _ModelOrderSanPham
    {
        public int STT { get; set; }
        public int IdSanPham { get; set; }
        public string NameSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaSanPham { get; set; }
        public decimal TongTien { get; set; }
        public string GhiChu { get; set; }
        public List<_ModelAddTopping> ToppingList { get; set; }
    }
    public class _ModelAddTopping
    {
        public int IdTopping { get; set; }
        public string NameTopping { get; set; }
        public decimal GiaTopping { get; set; } 
    }
}
