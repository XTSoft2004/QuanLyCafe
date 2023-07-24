using DevExpress.XtraEditors;
using QuanLyCafe.QLySanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class uc_QLSanPham : UserControl
    {
        public uc_QLSanPham()
        {
            InitializeComponent();
        }

        private fMain fMain = new fMain();
        private void AddTopping_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            string IdSanPham = gridView1.GetRowCellValue(selectedRowHandle, "IdSanPham").ToString();

            fTopping fTopping = new fTopping(Convert.ToInt32(IdSanPham));
            fTopping.ShowDialog();

            LoadAllDB();
        }
        private string GET_NAME_TYPESP(int idtype)
        {
            string name = db_quanly.LoaiSanPhams
                    .Where(x => x.IdTypeSP == idtype)
                    .Select(p => p.NameType)
                    .FirstOrDefault();
            return name;
        }
        private int GET_ID_TYPESP(string nametype)
        {
            int id = db_quanly.LoaiSanPhams
                    .Where(x => x.NameType == nametype)
                    .Select(p => p.IdTypeSP)
                    .FirstOrDefault();
            return id;
        }

        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void LoadAllDB()
        {
            NameTypeSanPhamCbbEdit.Properties.Items.Clear();
            var list_typesanpham = db_quanly.LoaiSanPhams.Select(p => p.NameType).ToList();
            if (list_typesanpham.Count > 0)
            {
                foreach (var type in list_typesanpham)
                {
                    NameTypeSanPhamCbbEdit.Properties.Items.Add(type);
                }
            }

            var list_sanpham = db_quanly.SanPhams.ToList();

            List<_Model_QLSanPham> _model_sanpham = new List<_Model_QLSanPham>();

            foreach (var sanpham in list_sanpham)
            {

                var list_topping = db_quanly.Toppings
                    .Where(p => p.IdSanPham == sanpham.IdSanPham)
                    .ToList();

                List<_Model_QlTopping> _Model_QlToppings = new List<_Model_QlTopping>();

                foreach (var topping in list_topping)
                {
                    _Model_QlTopping ToppingName = new _Model_QlTopping()
                    {
                        IdTopping = topping.IdTopping,
                        NameTopping = topping.NameTopping,
                        GiaTopping = topping.GiaTopping,
                    };
                    _Model_QlToppings.Add(ToppingName);
                }

                _Model_QLSanPham _Model_QLSanPham = new _Model_QLSanPham()
                {
                    IdSanPham = sanpham.IdSanPham,
                    NameSanPham = sanpham.NameSanPham,
                    GiaSanPham = sanpham.GiaSanPham,
                    NameTypeSanPham = GET_NAME_TYPESP(sanpham.IdTypeSP),
                    Image = sanpham.Image,
                    Cost = sanpham.Cost,
                    list_topping = _Model_QlToppings,
                };

                _model_sanpham.Add(_Model_QLSanPham);
            }

            modelQLSanPhamBindingSource.DataSource = _model_sanpham;
            gridView1.RefreshData();
        }

        private void uc_QLSanPham_Load(object sender, EventArgs e)
        {
            LoadAllDB();
        }

        private void btnAddSanPham_Click(object sender, EventArgs e)
        {
            #region Kiểm tra đầy đủ thông tin
            if (string.IsNullOrEmpty(NameSanPhamTextEdit.Text))
            {
                fMain.ShowNotification("Thông báo", "Thêm sản phẩm", "Chưa điền tên sản phẩm, vui lòng xem lại !!!", Helper_Project.svgImages["Error"]);
                return;
            }
            if (string.IsNullOrEmpty(NameTypeSanPhamCbbEdit.Text))
            {
                fMain.ShowNotification("Thông báo", "Thêm sản phẩm", "Chưa điền đơn giá, vui lòng xem lại !!!", Helper_Project.svgImages["Error"]);
                return;
            }
            if (pictureEdit1.Image == null)
            {
                fMain.ShowNotification("Thông báo", "Thêm sản phẩm", "Chưa điền đường dẫn ảnh, vui lòng xem lại !!!", Helper_Project.svgImages["Error"]);
                return;
            }
            if(GiaSanPhamSpinEdit.Value < CostSpinEdit.Value)
            {
                fMain.ShowNotification("Thông báo", "Thêm sản phẩm", "Tiền sản phẩm bé hơn tiền cost, vui lòng xem lại", Helper_Project.svgImages["Error"]);
                return;
            }
            #endregion

            //string path = ImageTextEdit.Text;
            //if (path.Contains("https://"))
            //{
            //    path = Helper_Project.DownloadImage(path);

            //    if (path == null)
            //    {
            //        fMain.ShowNotification("Thông báo", "Thêm sản phẩm", $"Download ảnh thất bại !!!!", Helper_Project.svgImages["Error"]);
            //        return;
            //    }
            //}
            //else
            //{
            //    path = Helper_Project.CopyIMGToFolder(path);
            //}

            //byte[] image = Helper_Project.ConvertImageToByte(path);
            //if(image == null)
            //{
            //    fMain.ShowNotification("Thông báo", "Thêm sản phẩm", $"Thêm ảnh thất bại !!!!", Helper_Project.svgImages["Error"]);
            //    return;
            //}

            SanPham sanPham = new SanPham()
            {
                NameSanPham = NameSanPhamTextEdit.Text,
                GiaSanPham = GiaSanPhamSpinEdit.Value,
                IdTypeSP = GET_ID_TYPESP(NameTypeSanPhamCbbEdit.Text),
                Image = Helper_Project.ConvertImageToByte(pictureEdit1.Image),
                Cost = CostSpinEdit.Value,
            };

            db_quanly.SanPhams.Add(sanPham);
            db_quanly.SaveChanges();

            fMain.ShowNotification("Thông báo", "Thêm sản phẩm", $"Thêm sản phầm {NameSanPhamTextEdit.Text} thành công", Helper_Project.svgImages["Success"]);

            LoadAllDB();
        }

        private void DeleteSanPham_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            string IdSanPham = gridView1.GetRowCellValue(selectedRowHandle, "IdSanPham").ToString();
            string NameSanPham = gridView1.GetRowCellValue(selectedRowHandle, "NameSanPham").ToString();
            int id = Convert.ToInt32(IdSanPham);
            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá sản phẩm {NameSanPham} không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var list_topping = db_quanly.Toppings
                        .Where(p => p.IdSanPham == id)
                        .ToList();

                foreach (var p in list_topping)
                {
                    db_quanly.Toppings.Remove(p);
                }

                SanPham sanpham = db_quanly.SanPhams.Find(Convert.ToInt32(IdSanPham));

                db_quanly.SanPhams.Remove(sanpham);

                db_quanly.SaveChanges();        
            }

            LoadAllDB();
        }

        private void btnDeleteSanPham_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có muốn xoá {indexSelected.Length} dòng không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for(int i = 0;i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    string IdSanPham = gridView1.GetRowCellValue(index, "IdSanPham").ToString();
                    string NameSanPham = gridView1.GetRowCellValue(index, "NameSanPham").ToString();

                    int id = Convert.ToInt32(IdSanPham);

                    var list_topping = db_quanly.Toppings
                        .Where(p => p.IdSanPham == id)
                        .ToList();

                    foreach (var p in list_topping)
                    {
                        db_quanly.Toppings.Remove(p);
                    }

                    SanPham sanpham = db_quanly.SanPhams.Find(Convert.ToInt32(IdSanPham));
                    db_quanly.SanPhams.Remove(sanpham);
                    fMain.ShowNotification("Thông báo", "Xóa sản phẩm", $"Đã xóa sản phẩm {NameSanPham} thành công", Helper_Project.svgImages["Success"]);
                }

                db_quanly.SaveChanges();

                LoadAllDB();
            }

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                byte[] image = Helper_Project.ConvertImageToByte(selectedFile);
                pictureEdit1.Image = Helper_Project.ConverByteToImage(image);
                byte[] a = Helper_Project.ConvertImageToByte(pictureEdit1.Image);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            string PathImage = gridView1.GetRowCellValue(selectedRowHandle, "Image").ToString();
            string path = Application.StartupPath + "\\" + PathImage;
            if (File.Exists(path))
            {
                Image image = Image.FromFile(path);
                pictureEdit1.Image = image;
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            fTypeSanPham fTypeSanPham = new fTypeSanPham();
            fTypeSanPham.ShowDialog();

            LoadAllDB();
        }

        private void btnEditSanPham_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdSanPhamSpinEdit.Text);

            byte[] image = Helper_Project.ConvertImageToByte(pictureEdit1.Image);
            if (image == null)
            {
                fMain.ShowNotification("Thông báo", "Thêm sản phẩm", $"Chỉnh sửa ảnh thất bại !!", Helper_Project.svgImages["Error"]);
                return;
            }

            SanPham sanpham = db_quanly.SanPhams.Find(id);
            sanpham.NameSanPham = NameSanPhamTextEdit.Text;
            sanpham.GiaSanPham = GiaSanPhamSpinEdit.Value;
            sanpham.IdTypeSP = GET_ID_TYPESP(NameTypeSanPhamCbbEdit.Text);
            sanpham.Image = image;
            sanpham.Cost = CostSpinEdit.Value;

            db_quanly.SaveChanges();

            fMain.ShowNotification("Thông báo", "Chỉnh sửa sản phẩm", $"Chỉnh sửa sản phẩm {NameSanPhamTextEdit.Text} thành công", Helper_Project.svgImages["Success"]);
        }
    }
}

