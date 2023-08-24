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
            if (AccountNhanVien == null)
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
    }
}