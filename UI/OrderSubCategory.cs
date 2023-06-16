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
    public partial class OrderSubCategory : Form
    {
        public int masaNo1;
        public OrderSubCategory()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public int SubCategoryNo;
        OrderPage order = new OrderPage();

        private void btnSubCategory1_Click(object sender, EventArgs e)
        {
            order.masaNo2= masaNo1;
            order.categoryNo = 1;
            order.subCategoryNo = 1;
            order.Show();
            this.Hide();
        }

        private void btnSubCategory2_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 2;
            this.Hide();
        }

        private void btnSubCategory3_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 3;
            this.Hide();
        }
        private void btnSubCategory4_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 4;
            this.Hide();
        }
        private void btnSubCategory5_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 5;
            this.Hide();
        }
        private void btnSubCategory6_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 6;
            this.Hide();
        }

        private void btnSubCategory7_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 7;
            this.Hide();
        }

        private void btnSubCategory8_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 8;
            this.Hide();
        }

        private void btnSubCategory9_Click(object sender, EventArgs e)
        {
            order.masaNo2 = masaNo1;
            order.Show();
            order.categoryNo = 1;
            order.subCategoryNo = 9;
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            OrderCategoryPage page = new OrderCategoryPage();
            page.Show();
            page.masaNo = masaNo1;
            this.Hide();
        }
    }
}
