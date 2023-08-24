using DevExpress.XtraEditors;
using QuanLyCafe.TongQuan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class XtrLogin : DevExpress.XtraEditors.XtraForm
    {
        public XtrLogin()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = UsernameEdit.Text;
            string password = PasswordEdit.Text;

            var account = db_quanly.Accounts
                .Where(p => p.Username == username)
                .FirstOrDefault();
            if (account != null && account.Password == password)
            {
                string NameNhanVien = account.NhanVien.NameNhanVien;

                // Lưu username
                if (cbRemember.Checked)
                {
                    string path = Application.StartupPath + "\\DATA\\Account.txt";
                    if (File.Exists(path)) File.Delete(path);
                    File.WriteAllText(path, username);
                }

                XtraMessageBox.Show("Đăng nhập thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AccountLogin infoaccount = new AccountLogin()
                {
                    NameNhanVien = account.NhanVien.NameNhanVien,
                    ChucVu = account.NhanVien.ChucVu.NameChucVu,
                };
                TongQuan.uc_TongQuat.InfoLogin = infoaccount;

                uc_TongQuat uc_TongQuat = new uc_TongQuat();
                Helper_Project.ShowFormUC(uc_TongQuat);

                this.Hide();
            }
            else if (account != null && account.Password != password)
            {
                XtraMessageBox.Show("Password không đúng vui lòng kiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Username không tồn tại, vui lòng kiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAccount()
        {
            string path = Application.StartupPath + "\\DATA\\Account.txt";
            if (File.Exists(path)) UsernameEdit.Text = File.ReadAllText(path);
        }
        private void XtrLogin_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}