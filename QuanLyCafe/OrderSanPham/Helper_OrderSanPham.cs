using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyCafe.OrderSanPham
{
    internal class Helper_OrderSanPham
    {
        public class NhanVienThanhToan
        {
            public int IdNhanVien { get; set; }
            public string FullName { get; set; }
            public string Department { get; set; }
            public NhanVienThanhToan(int idnhanvien,string fullName, string department)
            {
                IdNhanVien = idnhanvien;
                FullName = fullName;
                Department = department;
            }
            public override string ToString()
            {
                return $"{IdNhanVien}_{FullName}";
            }
        }
    }
}
