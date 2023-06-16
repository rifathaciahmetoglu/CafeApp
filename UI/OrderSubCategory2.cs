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
    public partial class OrderSubCategory2 : Form
    {
        public int masaNo1;
        public OrderSubCategory2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public int SubCategoryNo;
        OrderPage order = new OrderPage();
        private void btnSubCategory10_Click_1(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 10;
            this.Hide();
        }

        private void btnSubCategory11_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 11;
            this.Hide();
        }

        private void btnSubCategory12_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 12;
            this.Hide();
        }

        private void btnSubCategory13_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 13;
            this.Hide();
        }
        private void btnSubCategory14_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 14;
            this.Hide();
        }
        private void btnSubCategory15_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 15;
            this.Hide();
        }

        private void btnSubCategory16_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 2;
            order.subCategoryNo = 16;
            this.Hide();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            OrderCategoryPage page = new OrderCategoryPage();
            page.Show();
            page.masaNo = masaNo1;
            this.Hide();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
