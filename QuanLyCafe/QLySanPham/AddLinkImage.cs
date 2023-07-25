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
    public partial class AddLinkImage : DevExpress.XtraEditors.XtraForm
    {
        public AddLinkImage()
        {
            InitializeComponent();
        }

        private void AddLinkImage_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Image ImageSanPham { get; set; }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            Image image = Helper_Project.ConvertImageUrlToImage(LinkImage.Text);
            ImageSanPham = image;
            this.Close();
        }
    }
}