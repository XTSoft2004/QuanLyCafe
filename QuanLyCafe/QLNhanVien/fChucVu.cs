using DevExpress.XtraEditors;
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

namespace QuanLy
{
    public partial class fChucVu : DevExpress.XtraEditors.XtraForm
    {
        public fChucVu()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly  = new QuanLyCafeEntities();
        private void LoadAllChucVu()
        {
            var result = db_quanly.ChucVus
                .Select(p => new { p.IdChucVu, p.NameChucVu }).ToList();

            chucVuBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private void fChucVu_Load(object sender, EventArgs e)
        {
            LoadAllChucVu();
        }

        private void btnAddChucVu_Click(object sender, EventArgs e)
        {
            string namechucvu = NameChucVuTextEdit.Text;

            if (!CheckNameChucVu()) return;

            ChucVu chucvu = new ChucVu()
            {
                //IdChucVu = Convert.ToInt32(IdChucVuTextEdit.Text),
                NameChucVu = namechucvu,
            };
            db_quanly.ChucVus.Add(chucvu);
            db_quanly.SaveChanges();
            
            XtraMessageBox.Show("Đã thêm thông tin chức vụ !!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllChucVu();
        }

        private void btnEditChucVu_Click(object sender, EventArgs e)
        {
            string namechucvu = NameChucVuTextEdit.Text;

            if (!CheckNameChucVu()) return;

            if (string.IsNullOrEmpty(namechucvu))
            {
                XtraMessageBox.Show("Chưa tiền tên chức vụ, vui lòng xem lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(IdChucVuTextEdit.Text);
            ChucVu chucVu = db_quanly.ChucVus.Find(id);
            chucVu.NameChucVu = namechucvu;
            db_quanly.SaveChanges();

            XtraMessageBox.Show($"Sửa thông tin thành {namechucvu} thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllChucVu();
        }
        private bool CheckNameChucVu()
        {
            string namechucvu = NameChucVuTextEdit.Text;

            if (string.IsNullOrEmpty(namechucvu))
            {
                XtraMessageBox.Show("Chưa điền tên chức vụ, vui lòng xem lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var result = db_quanly.ChucVus
                .Select(p => p.NameChucVu).ToList();

            if (result.Contains(namechucvu))
            {
                XtraMessageBox.Show("Chức vụ đã tồn tại, vui lòng kiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DeleteBtnChucVu_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string IdChucVu = gridView1.GetRowCellValue(selectedRowHandle, "IdChucVu").ToString();
            string NameChucVu = gridView1.GetRowCellValue(selectedRowHandle, "NameChucVu").ToString();

            int id = Convert.ToInt32(IdChucVu);

            ChucVu chucvu = db_quanly.ChucVus.Find(id);

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá chức vụ {NameChucVu} không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db_quanly.ChucVus.Remove(chucvu);
                db_quanly.SaveChanges();
                XtraMessageBox.Show($"Đã xoá chức vụ {NameChucVu} ra khỏi danh sách !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                LoadAllChucVu();
            }
        }
    }
}