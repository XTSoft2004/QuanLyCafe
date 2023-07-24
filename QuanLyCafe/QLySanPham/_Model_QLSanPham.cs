using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.QLySanPham
{
    public class _Model_QLSanPham
    {
        public int IdSanPham { get; set; }
        public string NameSanPham { get; set; }
        public decimal GiaSanPham { get; set; }
        public string NameTypeSanPham { get; set; }
        public byte[] Image { get; set; }
        public decimal Cost { get; set; }
        public List<_Model_QlTopping> list_topping { get; set; }
    }
    public class _Model_QlTopping
    {
        public int IdTopping { get; set; }
        public string NameTopping { get; set; }
        public decimal GiaTopping { get; set; }
    }
}
