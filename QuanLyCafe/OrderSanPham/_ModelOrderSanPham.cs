using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using QuanLyCafe.QLHoaDon;
using QuanLyCafe.QLHoaDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.OrderSanPham
{
    public class _ModelOrderSanPham
    {
        public int IdSanPham { get; set; }
        public string NameSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaSanPham { get; set; }
        public decimal TongTien { get; set; }
        public string GhiChu { get; set; }
        public List<_ModelTopping> _list_toppings { get; set; }
    }
    public class _ModelDanhMucTopping
    {
        public int IdDanhMuc { get; set; }
        public string NameDanhMuc { get; set; }

        //public List<_ModelAddTopping> _list_topping { get; set; }
    }
}