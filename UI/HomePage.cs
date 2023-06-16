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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class HomePage : Form
    {
        public int RoleNo;
        public string userName;
        public HomePage()
        {
            InitializeComponent();
        }
        public int DeskNo;
        public bool status;
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            labDateTime.Text = DateTime.Now.ToString();
            if (RoleNo == 1)
                TableButtonsPanel.Visible = true;
            labUsername.Text = userName;
            labUsername.Text = labUsername.Text.ToUpper();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TableTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        OrderCategoryPage menu = new OrderCategoryPage();

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.masaNo = 1;
            menu.RoleeNo= RoleNo;
            this.Hide();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            menu.masaNo = 2;
            menu.Show();
            this.Hide();
            menu.RoleeNo = RoleNo;
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 3;
            menu.Show();
            this.Hide();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            menu.masaNo = 4;
            menu.RoleeNo = RoleNo;
            menu.Show();
            this.Hide();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 5;
            menu.Show();
            this.Hide();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 6;
            menu.Show();
            this.Hide();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 7;
            menu.Show();
            this.Hide();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 8;
            menu.Show();
            this.Hide();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 9;
            menu.Show();
            this.Hide();
        }

        private void btnMasa18_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 18;
            menu.Show();
            this.Hide();
        }

        private void btnMasa17_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 17;
            menu.Show();
            this.Hide();
        }

        private void btnMasa16_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 16;
            menu.Show();
            this.Hide();
        }

        private void btnMasa15_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 15;
            menu.Show();
            this.Hide();
        }

        private void btnMasa14_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 14;
            menu.Show();
            this.Hide();
        }

        private void btnMasa13_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 13;
            menu.Show();
            this.Hide();
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 12;
            menu.Show();
            this.Hide();
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 11;
            menu.Show();
            this.Hide();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 10;
            menu.Show();
            this.Hide();
        }

        private void btnDis1_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 19;
            menu.Show();
            this.Hide();
        }

        private void btnDis2_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 20;
            menu.Show();
            this.Hide();
        }

        private void btnDis3_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 21;
            menu.Show();
            this.Hide();
        }

        private void btnDis4_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 22;
            menu.Show();
            this.Hide();
        }

        private void btnDis5_Click(object sender, EventArgs e)
        {
            menu.RoleeNo = RoleNo;
            menu.masaNo = 23;
            menu.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.menuName = "Satışlar";
            adminPage.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.menuName = "Ürünler";
            adminPage.Show();
            this.Hide();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.menuName = "Personeller";
            adminPage.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

    }
}
