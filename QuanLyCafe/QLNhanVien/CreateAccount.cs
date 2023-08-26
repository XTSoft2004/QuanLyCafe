using DevExpress.XtraEditors;
using QuanLyCafe.Helper;
using QuanLyCafe.TongQuan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.QLNhanVien
{
    public partial class CreateAccount : DevExpress.XtraEditors.XtraForm
    {
        public int IdNhanVien { get; set; }
        public CreateAccount(int idNhanVien)
        {
            InitializeComponent();
            IdNhanVien = idNhanVien;
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private Account AccountNhanVien { get; set; }
        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            var username = db_quanly.Accounts
                .Where(p => p.Username == UsernameEdit.Text).FirstOrDefault();

            if(username != null)
            {
                Helper_ShowNoti.ShowXtraMessageBox("Username này đã tồn tại, vui lòng chọn username khác !!!", "Thông báo", Helper_ShowNoti.IconXtraMessageBox.Error);
                return;
            }
            else if (AccountNhanVien == null)
            {
                Account account = new Account()
                {
                    Username = UsernameEdit.Text,
                    Password = PasswordEdit.Text,
                    IdNhanVien = IdNhanVien,
                    Admin = cbAdmin.Checked ? 1 : 0,
                };
                db_quanly.Accounts.Add(account);
            }
            else
            {
                AccountNhanVien.Username = UsernameEdit.Text;
                AccountNhanVien.Password = PasswordEdit.Text;
                AccountNhanVien.Admin = cbAdmin.Checked ? 1 : 0;
            }

            db_quanly.SaveChanges();

            //Lấy tên nhân viên
            var NhanVien = db_quanly.NhanViens.Where(p => p.IdNhanVien == IdNhanVien).FirstOrDefault();
            Helper_ShowNoti.ShowThongBao("Thông báo", $"{uc_TongQuat.InfoLogin.NameNhanVien} đã thêm account cho {NhanVien.NameNhanVien} với username là {UsernameEdit.Text}", Helper_ShowNoti.SvgImageIcon.Success);

            this.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            AccountNhanVien = db_quanly.Accounts
                    .Where(p => p.IdNhanVien == IdNhanVien).FirstOrDefault();
            if(AccountNhanVien != null)
            {
                UsernameEdit.Text = AccountNhanVien.Username;
                PasswordEdit.Text = AccountNhanVien.Password;
                cbAdmin.Checked = AccountNhanVien.Admin == 1 ? true : false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            var account = db_quanly.Accounts
                .Where(p => p.IdNhanVien == IdNhanVien).FirstOrDefault();

            account.Username = UsernameEdit.Text;
            account.Password = PasswordEdit.Text;
            account.Admin = cbAdmin.Checked ? 1 : 0;

            db_quanly.SaveChanges();
            Helper_ShowNoti.ShowThongBao("Thông báo", $"{uc_TongQuat.InfoLogin.NameNhanVien} đã chỉnh sửa account {account.NhanVien.NameNhanVien}", Helper_ShowNoti.SvgImageIcon.Success);
      
            this.Close();
        }
    }
}