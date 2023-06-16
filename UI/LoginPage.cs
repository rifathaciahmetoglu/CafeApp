using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Kullanıcı Adı")
                txtUsername.Text = "";
            txtUsername.ForeColor = Color.Blue;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Kullanıcı Adı";
            txtUsername.ForeColor = Color.DarkOrange;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifre")
                txtPassword.Text = "";
            txtPassword.ForeColor = Color.Blue;

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                txtPassword.Text = "Şifre";
            txtPassword.ForeColor = Color.DarkOrange;
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogin.ForeColor = Color.Blue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.DarkOrange;
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.MaxLength = 16;
            txtPassword.PasswordChar = '•';
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            txtUsername.MaxLength = 8;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Succes == true)
            {
                foreach (var manager in userManager.GetAll().Data)
                {
                    if (manager.UserName == txtUsername.Text && manager.Password == txtPassword.Text)
                    {
                        labErrorLogin.Visible = true;
                        labErrorLogin.Text = "Giriş Başarılı!";
                        HomePage homePage = new();
                        this.Hide();
                        if (manager.RoleId == 1)//yönetici
                        {
                            homePage.RoleNo = 1;
                            homePage.userName = manager.UserName;
                            homePage.ShowDialog();

                        }
                        else if (manager.RoleId == 2)//kasa
                        {
                            homePage.RoleNo = 2;
                            homePage.userName = txtUsername.Text;
                            homePage.ShowDialog();
                        }
                        else if (manager.RoleId == 3)//çalışan garson
                        {
                            homePage.RoleNo = 3;
                            homePage.userName = txtUsername.Text;
                            homePage.ShowDialog();

                        }
                        else
                        {
                            btnLogin.ForeColor = Color.Red;
                        }
                    }
                    else
                    {

                        labErrorLogin.Visible = true;
                        labErrorLogin.Text = "Hatalı Giriş Yaptınız!";
                    }
                }
            }
        }
    }
}
