using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Identity.Client;
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
    public partial class OrderPage : Form
    {
        SaleManager saleManager = new SaleManager(new EfSaleDal());
        BillManager billManager = new BillManager(new EfBillDal());
        DeskManager deskManager = new DeskManager(new EfDeskDal());
        ProductManager productManager = new ProductManager(new EfProductDal());

        public int categoryNo;
        public int subCategoryNo;
        public int masaNo2;
        public string masaName2;
        public OrderPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                OrderList.Items.Add(item.OrderName);
            }
        }
        private void GetAllBySubCategoryId(int id)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllBySubCategoryId(id).Data)
            {
                productList.Items.Add(item.ProductName);
            }
        }
        private void GetByDeskNoProduct(int id)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllBySubCategoryId(subCategoryNo);

            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                if (item.Status == true)
                {
                    OrderList.Items.Add(item.OrderName);
                }
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (categoryNo == 1)
            {
                OrderSubCategory orderSubCategory = new OrderSubCategory();
                orderSubCategory.Show();
                orderSubCategory.masaNo1 = masaNo2;
                this.Hide();

            }
            else if (categoryNo == 2)
            {
                OrderSubCategory2 orderSubCategory = new OrderSubCategory2();
                orderSubCategory.Show();
                orderSubCategory.masaNo1 = masaNo2;
                this.Hide();
            }
            else
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int piece;
        public int orderPrice;

        private void btn1x_Click(object sender, EventArgs e)
        {
            string orderProduct = productList.SelectedItem.ToString();
            OrderList.Items.Add(orderProduct);

            foreach (var item in productManager.GetAll().Data)
            {
                if (item.ProductName == productList.SelectedItem.ToString())
                {
                    orderPrice = Convert.ToInt32(item.SalePrice);
                }
            }
            labTotalPrice.Text = orderPrice.ToString();

            billManager.Add(new Bill
            {
                DeskId = masaNo2,
                OrderId = Convert.ToInt32(OrderList.Items.Count + 1),
                OrderName = productList.SelectedItem.ToString(),
                Piece = 1,
                Price = Convert.ToDouble(orderPrice),
                Status = true,
            });
            OrderList.Items.Clear();

            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                if (item.Status == true)
                {
                    OrderList.Items.Add(item.OrderName);
                }
            }
        }

        private void btn2x_Click(object sender, EventArgs e)
        {
            string orderProduct = productList.SelectedItem.ToString();
            OrderList.Items.Add("2 adet " + orderProduct);

            foreach (var item in productManager.GetAll().Data)
            {
                if (item.ProductName == productList.SelectedItem.ToString())
                {
                    orderPrice = Convert.ToInt32(item.SalePrice);
                }
            }
            labTotalPrice.Text = orderPrice.ToString();

            billManager.Add(new Bill
            {
                DeskId = masaNo2,
                OrderId = Convert.ToInt32(OrderList.Items.Count + 1),
                OrderName = productList.SelectedItem.ToString(),
                Piece = 2,
                Price = Convert.ToDouble(orderPrice * 2),
                Status = true,
            });
            OrderList.Items.Clear();

            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                if (item.Status == true)
                {
                    OrderList.Items.Add(item.OrderName);
                }
            }
        }

        private void btn3x_Click(object sender, EventArgs e)
        {

            string orderProduct = productList.SelectedItem.ToString();
            piece = 3;
            OrderList.Items.Add("3 adet " + orderProduct);

            foreach (var item in productManager.GetAll().Data)
            {
                if (item.ProductName == productList.SelectedItem.ToString())
                {
                    orderPrice = Convert.ToInt32(item.SalePrice);
                }
            }
            labTotalPrice.Text = orderPrice.ToString();

            billManager.Add(new Bill
            {
                DeskId = masaNo2,
                OrderId = Convert.ToInt32(OrderList.Items.Count + 1),
                OrderName = productList.SelectedItem.ToString(),
                Piece = 3,
                Price = Convert.ToDouble(orderPrice * 3),
                Status = true,
            });
            OrderList.Items.Clear();

            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                if (item.Status == true)
                {
                    OrderList.Items.Add(item.OrderName);
                }
            }
        }
        public int totalPrice;
        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                totalPrice += Convert.ToInt32(item.Price);
                item.Status = false;
            }
            labTotalPrice.Text = totalPrice.ToString();

            saleManager.Add(new Sale
            {
                SalesType = "Kredi Kartı",
                TotalPrice = totalPrice,
                SellDay = DateTime.Now
            });

            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                if (item.Status == true)
                {
                    billManager.Update(new Bill
                    {
                        BillId = item.BillId,
                        Status = false,
                        DeskId = masaNo2,
                        OrderId = item.OrderId,
                        OrderName = item.OrderName,
                        Piece = item.Piece,
                        Price = item.Price
                    });
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                totalPrice += Convert.ToInt32(item.Price);
                item.Status = false;
            }
            labTotalPrice.Text = totalPrice.ToString();

            saleManager.Add(new Sale
            {
                SalesType = "Nakit",
                TotalPrice = totalPrice,
                SellDay = DateTime.Now

            });
            foreach (var item in billManager.GetByDeskId(masaNo2).Data)
            {
                if (item.Status == true)
                {
                    billManager.Update(new Bill
                    {
                        BillId = item.BillId,
                        Status = false,
                        DeskId = masaNo2,
                        OrderId = item.OrderId,
                        OrderName = item.OrderName,
                        Piece = item.Piece,
                        Price = item.Price
                    });
                }

            }

        }

        private void OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (var item in productManager.GetAll().Data)
            //{
            //    if (item.ProductName==productList.SelectedItem)
            //    {
            //        orderPrice = Convert.ToInt32(item.SalePrice);
            //    }
            //}

        }
    }
}
