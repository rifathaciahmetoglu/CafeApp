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
    public partial class OrderCategoryPage : Form
    {
        public int RoleeNo;
        public int masaNo;
        public OrderCategoryPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            OrderSubCategory orderSub = new OrderSubCategory();
            orderSub.masaNo1 = masaNo;
            orderSub.Show();
            this.Hide();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OrderSubCategory2 orderSub = new OrderSubCategory2();
            orderSub.masaNo1 = masaNo;
            orderSub.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.RoleNo= RoleeNo;
            homePage.Show();
            this.Hide();
        }
    }

}

