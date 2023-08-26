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

namespace QuanLyCafe.OrderSanPham.Form_Helper
{
    public partial class fNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public fNhanVien()
        {
            InitializeComponent();
        }
        public string NameNhanVien { get; set; }
        private void AddNhanVien_Click(object sender, EventArgs e)
        {
            int indexSelect = gridView1.FocusedRowHandle;

            int idnhanvien = Convert.ToInt32(gridView1.GetRowCellValue(indexSelect, "IdNhanVien"));
            string namenhanvien = gridView1.GetRowCellValue(indexSelect, "NameNhanVien").ToString();
            NameNhanVien = idnhanvien + "_" + namenhanvien;

            this.Close();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void LoadAllDB()
        {
            var result = db_quanly.NhanViens
                .Select(p=> new {p.IdNhanVien,p.NameNhanVien,p.ChucVu.NameChucVu,p.Thongtin})
                .ToList();

            modelQLNhanVienBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            LoadAllDB();
        }
    }
}