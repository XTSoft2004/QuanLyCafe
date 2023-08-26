using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.TongQuan
{
    public class ShowLog
    {
        public string LogText { get; set; }
        public string DateLog { get; set; }
    }
    public class AccountLogin
    {
        public int IdNhanVien { get; set; }
        public string NameNhanVien { get; set; }
        public string ChucVu { get; set; }
        public bool isAdmin { get; set; }
    }
}
