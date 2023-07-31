using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCafe.QLHoaDon
{
    public partial class fBaoCao : DevExpress.XtraReports.UI.XtraReport
    {
        public List<_ModelHoaDon> _ModelHoaDons = new List<_ModelHoaDon>();
        public fBaoCao(List<_ModelHoaDon> _hoadon)
        {
            InitializeComponent();
            _ModelHoaDons = _hoadon;
        }

        private void fBaoCao_AfterPrint(object sender, EventArgs e)
        {
            //MessageBox.Show("A");
        }

        private void fBaoCao_BeforePrint(object sender, CancelEventArgs e)
        {
            xrlbDiaChi.Text = "Ngự Bình,Phường An Cựu, Thừa Thiên Huế";
            


            //MessageBox.Show("B");
        }
    }
}
