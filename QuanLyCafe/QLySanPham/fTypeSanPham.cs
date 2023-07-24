using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using QuanLyCafe;
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
    public partial class fTypeSanPham : DevExpress.XtraEditors.XtraForm
    {
        public fTypeSanPham()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void fTypeSanPham_Load(object sender, EventArgs e)
        {
            LoadAllType();
        }
        private void LoadAllType()
        {
            var result = db_quanly.LoaiSanPhams
                .Select(p=> new { p.IdTypeSP,p.NameType}).ToList();
              
            loaiSanPhamBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private bool CheckName(string name)
        {
            var result = db_quanly.LoaiSanPhams
                .Select(p=>p.NameType)
                .ToList();

            if (result.Contains(name))
            {
                XtraMessageBox.Show("Loại tên này đã tồn tại vui lòng chọn tên loại khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else return false;
        }
        private void btnAddLoai_Click(object sender, EventArgs e)
        {
            string name = NameTypeTextEdit.Text;

            if (CheckName(name)) return;

            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                NameType = name,
            };

            db_quanly.LoaiSanPhams.Add(loaiSanPham);
            db_quanly.SaveChanges();

            XtraMessageBox.Show($"Đã nhập thành công loại {name} !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllType();
        }

        private void btnEditLoai_Click(object sender, EventArgs e)
        {
            string name = NameTypeTextEdit.Text;
            int id = Convert.ToInt32(IdTypeSPTextEdit.Text);

            if (CheckName(name)) return;

            LoaiSanPham chucVu = db_quanly.LoaiSanPhams.Find(id);
            chucVu.NameType = NameTypeTextEdit.Text;

            db_quanly.SaveChanges();
            XtraMessageBox.Show($"Chỉnh sửa thông tin thành {name} thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllType();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string NameType = gridView1.GetRowCellValue(selectedRowHandle, "NameType").ToString();
            string IdTypeSP = gridView1.GetRowCellValue(selectedRowHandle, "IdTypeSP").ToString();

            int id = Convert.ToInt32(IdTypeSP);

            LoaiSanPham loaiSanPham = db_quanly.LoaiSanPhams.Find(id);

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá loại {NameType} không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db_quanly.LoaiSanPhams.Remove(loaiSanPham);
                db_quanly.SaveChanges();
                XtraMessageBox.Show($"Đã xoá loại {NameType} ra khỏi danh sách !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllType();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Lấy GridControl

            // Lấy dòng được chọn
            int selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                // Lấy giá trị của các cột trong dòng được chọn
                object columnValue1 = gridView1.GetRowCellValue(selectedRowHandle, "NameType");
                // và các cột khác tương tự...

                // Sử dụng giá trị của các cột
                Console.WriteLine("Column 1 Value: " + columnValue1.ToString());
                // và các cột khác tương tự...
            }

        }
    }
}
