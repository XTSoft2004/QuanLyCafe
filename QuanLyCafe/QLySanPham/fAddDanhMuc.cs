using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.QLySanPham
{
    public partial class fAddDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public int IdSanPham { get; set; }
        public fAddDanhMuc(int idSanPham)
        {
            InitializeComponent();
            IdSanPham = idSanPham;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void btnAddDanhMuc_Click(object sender, EventArgs e)
        {
            var idtext = db_quanly.DanhMucToppings
                .Where(p => p.NameDanhMuc == NameDanhMucEditText.Text)
                .FirstOrDefault();

            if(idtext != null)
            {
                XtraMessageBox.Show($"Danh mục {NameDanhMucEditText.Text} đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanhMucTopping danhMucTopping = new DanhMucTopping()
            {
                NameDanhMuc = NameDanhMucEditText.Text,
                IdSanPham = IdSanPham,
            };

            db_quanly.DanhMucToppings.Add(danhMucTopping);

            db_quanly.SaveChanges();

            XtraMessageBox.Show($"Thêm thành công danh mục {NameDanhMucEditText.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}