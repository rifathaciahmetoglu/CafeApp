using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        public string? menuName;

        /*--------------------------------------------------------------------------------------------*/

        // METHOD COMMANDS START

        ProductManager productManager = new(new EfProductDal());
        UserManager userManager = new(new EfUserDal());
        SaleManager saleManager = new(new EfSaleDal());
        public void GetAllProduct()
        {
            dataGridProduct.DataSource = productManager.GetAll().Data;
        }
        public void GetAllUser()
        {
            dataGridPersons.DataSource = userManager.GetAll().Data;
        }
        public void ClearUserBox()
        {
            cmbRole.SelectedText = "";
            txtPersonFirstName.Text = "";
            txtPersonLastName.Text = "";
            txtPersonUserName.Text = "";
            txtPersonPassword.Text = "";
        }

        // METHOD COMMAND FNİSH

        /*----------------------------------------------------------------------------------------------*/

        //FORM COMMAND START

        private void AdminPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            labMenuName.Text = menuName;
            if (menuName == "Satışlar")
            {
                panelSales.Visible = true;
                panelSales.Dock = DockStyle.Fill;
                dataGridSales.Dock = DockStyle.Fill;
                panelFilters.Visible = false;
                sidePanelProduct.Visible = false;
                dataGridSales.DataSource = saleManager.GetAll().Data;
            }
            else if (menuName == "Ürünler")
            {
                panelFilters.Visible = true;
                sidePanelProduct.Visible = true;
                panelProduct.Visible = true;
                panelProduct.Dock = DockStyle.Fill;
                dataGridProduct.ReadOnly = true;
                dataGridProduct.DataSource = productManager.GetAll().Data;
                dataGridProduct.Columns[1].Visible = false;
                dataGridProduct.Columns[2].Visible = false;
                dataGridProduct.Columns[3].Visible = false;
                dataGridProduct.Columns[0].HeaderText = "Ürün Numarası";
                dataGridProduct.Columns[4].HeaderText = "Ürün Adı";
                dataGridProduct.Columns[5].HeaderText = "Ürün Fiyatı";


            }
            else if (menuName == "Personeller")
            {
                sidePanelProduct.Visible = false;
                panelFilters.Visible = false;
                dataGridPersons.Visible = true;
                panelPersons.Visible = true;
                sidePanelPerson.Visible = true;
                panelPersons.Dock = DockStyle.Fill;
                dataGridPersons.Dock = DockStyle.Fill;
                dataGridPersons.ReadOnly = true;
                dataGridPersons.DataSource = userManager.GetAll().Data;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUndoPage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.RoleNo = 1;
            homePage.Show();
            this.Hide();
        }

        //FORM COMMAND FNİSH

        /*---------------------------------------------------------------------------------------------*/

        //TXT DESIGN START

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            if (txtProductName.Text == Messages.productName)
                txtProductName.Text = Messages.space;
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == Messages.space)
                txtProductName.Text = Messages.productName;
        }

        private void txtSalePrice_Enter(object sender, EventArgs e)
        {
            if (txtSalePrice.Text == Messages.salePrice)
                txtSalePrice.Text = Messages.space;
        }

        private void txtSalePrice_Leave(object sender, EventArgs e)
        {
            if (txtSalePrice.Text == Messages.space)
                txtSalePrice.Text = Messages.salePrice;
        }

        private void txtPersonFirstName_Enter(object sender, EventArgs e)
        {
            if (txtPersonFirstName.Text == Messages.firstName)
                txtPersonFirstName.Text = Messages.space;
        }

        private void txtPersonFirstName_Leave(object sender, EventArgs e)
        {
            if (txtPersonFirstName.Text == Messages.space)
                txtPersonFirstName.Text = Messages.firstName;
        }

        private void txtPersonLastName_Enter(object sender, EventArgs e)
        {
            if (txtPersonLastName.Text == Messages.lastName)
                txtPersonLastName.Text = Messages.space;

        }

        private void txtPersonLastName_Leave(object sender, EventArgs e)
        {
            if (txtPersonLastName.Text == Messages.space)
                txtPersonLastName.Text = Messages.lastName;
        }

        private void txtPersonUserName_Enter(object sender, EventArgs e)
        {
            if (txtPersonUserName.Text == Messages.userName)
                txtPersonUserName.Text = Messages.space;
        }

        private void txtPersonUserName_Leave(object sender, EventArgs e)
        {
            if (txtPersonUserName.Text == Messages.space)
                txtPersonUserName.Text = Messages.userName;
        }

        private void txtPersonPassword_Enter(object sender, EventArgs e)
        {
            if (txtPersonPassword.Text == Messages.password)
                txtPersonPassword.Text = Messages.space;
        }

        private void txtPersonPassword_Leave(object sender, EventArgs e)
        {
            if (txtPersonPassword.Text == Messages.space)
                txtPersonPassword.Text = Messages.password;
        }
        //TXT DESIGN FNİSH

        /*------------------------------------------------------------------------------------*/

        //PRODUCT COMMAND START

        public int change;

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (panelAction.Visible == false)
            {
                panelAction.Visible = true;
                panelFilters.Visible = false;
            }
            else if (panelAction.Visible == true)
            {
                panelAction.Visible = false;
                panelFilters.Visible = true;
            }
            btnAction.Text = "Ürün Ekle";
            change = 1;
        }
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (panelAction.Visible == false)
            {
                panelAction.Visible = true;
                panelFilters.Visible = false;
            }
            else if (panelAction.Visible == true)
            {
                panelAction.Visible = false;
                panelFilters.Visible = true;
            }
            btnAction.Text = "Ürünü Güncelle";
            change = 2;
        }
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            productManager.Delete(new Product { ProductId = Convert.ToInt32(dataGridProduct.CurrentRow.Cells[0].Value) });
            GetAllProduct();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (change == 1)
            {
                try
                {
                    productManager.Add(new Product
                    {
                        CategoryId = Convert.ToInt32(cmbCategory.SelectedIndex + 1),
                        SubCategoryId = Convert.ToInt32(cmbSubCategory.SelectedIndex + 1),
                        KindId = Convert.ToInt32(cmbKind.SelectedIndex + 1),
                        ProductName = txtProductName.Text,
                        SalePrice = Convert.ToDouble(txtSalePrice.Text),
                    });
                    panelAction.Visible = false;
                    panelFilters.Visible = true;
                    MessageBox.Show("Ürün başarıyla eklendi");
                    GetAllProduct();

                }
                catch (Exception)
                {

                    MessageBox.Show("Bilgileri Kontrol ediniz");
                }
            }
            if (change == 2)
            {
                try
                {
                    productManager.Update(new Product
                    {
                        ProductId = productId,
                        CategoryId = Convert.ToInt32(cmbCategory.SelectedIndex + 1),
                        SubCategoryId = Convert.ToInt32(cmbSubCategory.SelectedIndex + 1),
                        KindId = Convert.ToInt32(cmbKind.SelectedIndex + 1),
                        ProductName = txtProductName.Text,
                        SalePrice = Convert.ToDouble(txtSalePrice.Text),
                    });
                    GetAllProduct();
                    panelAction.Visible = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bilgileri Kontrol ediniz");
                }
            }
        }


        public int productId;
        private void dataGridProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (change == 2)
            {
                cmbCategory.Text = "";
                cmbSubCategory.Text = "";
                cmbKind.Text = "";
                string? productIds = dataGridProduct.CurrentRow.Cells[0].Value.ToString();
                string? categoryId = dataGridProduct.CurrentRow.Cells[1].Value.ToString();
                string? subCategoryId = dataGridProduct.CurrentRow.Cells[2].Value.ToString();
                string? kindId = dataGridProduct.CurrentRow.Cells[3].Value.ToString();
                string? productName = dataGridProduct.CurrentRow.Cells[4].Value.ToString();
                string? salePrice = dataGridProduct.CurrentRow.Cells[5].Value.ToString();

                productId = Convert.ToInt32(productIds);
                cmbCategory.SelectedText = categoryId;
                cmbSubCategory.SelectedText = subCategoryId;
                cmbKind.SelectedText = kindId;
                txtProductName.Text = productName;
                txtSalePrice.Text = salePrice;
            }
        }
        public int userId;
        private void dataGridPersons_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (change == 4)
            {
                ClearUserBox();
                cmbRole.Text = "";
                string? userIds = dataGridPersons.CurrentRow.Cells[0].Value.ToString();

                string? firstName = dataGridPersons.CurrentRow.Cells[2].Value.ToString();
                string? lastName = dataGridPersons.CurrentRow.Cells[3].Value.ToString();
                string? userName = dataGridPersons.CurrentRow.Cells[4].Value.ToString();
                string? password = dataGridPersons.CurrentRow.Cells[5].Value.ToString();

                userId = Convert.ToInt32(userIds);
                cmbRole.SelectedText = "Yetki Seç";
                txtPersonFirstName.Text = firstName;
                txtPersonLastName.Text = lastName;
                txtPersonUserName.Text = userName;
                txtPersonPassword.Text = password;

            }
        }
        public int subCategoryAdds;
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            subCategoryAdds = cmbCategory.SelectedIndex + 1;
            cmbSubCategory.Items.Clear();
            SubCategoryManager subCategoryManager = new(new EfSubCategoryDal());
            foreach (var item in subCategoryManager.GetAllBySubCategoryId(subCategoryAdds).Data)
            {
                cmbSubCategory.Items.Add(item.SubCategoryName);
            }
        }
        public int kindAdds;
        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subCategoryAdds == 1)
                kindAdds = cmbSubCategory.SelectedIndex + 1;
            else
                kindAdds = cmbSubCategory.SelectedIndex + 10;
            cmbKind.Items.Clear();
            KindManager kindManager = new(new EfKindDal());
            foreach (var item in kindManager.GetAllByCategoryId(kindAdds).Data)
            {
                cmbKind.Items.Add(item.KindName);
            }
        }

        //PRODUCT COMMAND FNİSH

        /*-----------------------------------------------------------------------------*/

        //PERSON COMMANDS START

        private void btnPersonAdd_Click(object sender, EventArgs e)
        {
            if (panelPerson.Visible == false)
            {
                panelPerson.Visible = true;
                panelFilters.Visible = false;
            }
            else if (panelPerson.Visible == true)
            {
                panelPerson.Visible = false;
                panelFilters.Visible = true;

            }
            btnPersonAction.Text = "Personel Ekle";
            change = 3;
        }

        private void btnPersonEdit_Click(object sender, EventArgs e)
        {
            if (panelPerson.Visible == false)
            {
                panelPerson.Visible = true;
            }
            else if (panelPerson.Visible == true)
            {
                panelPerson.Visible = false;
            }
            change = 4;
            btnPersonAction.Text = "Personel Güncelle";
        }

        private void btnPersonDel_Click(object sender, EventArgs e)
        {
            userManager.Delete(new User { Id = Convert.ToInt32(dataGridPersons.CurrentRow.Cells[0].Value) });
            GetAllUser();
        }
        private void btnPersonAction_Click(object sender, EventArgs e)
        {
            if (change == 3)
            {
                try
                {
                    userManager.Add(new User
                    {
                        RoleId = cmbRole.SelectedIndex + 2,
                        FirstName = txtPersonFirstName.Text,
                        LastName = txtPersonLastName.Text,
                        UserName = txtPersonUserName.Text,
                        Password = txtPersonPassword.Text,

                    });
                    panelPerson.Visible = false;
                    userManager.GetAll();

                    MessageBox.Show("Personel başarıyla eklendi");
                    GetAllUser();

                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz");
                }
            }
            if (change == 4)
            {
                try
                {
                    userManager.Update(new User
                    {
                        Id = userId,
                        RoleId = Convert.ToInt32(cmbRole.SelectedIndex + 2),
                        FirstName = txtPersonFirstName.Text,
                        LastName = txtPersonLastName.Text,
                        UserName = txtPersonUserName.Text,
                        Password = txtPersonPassword.Text,
                    });
                    MessageBox.Show("Personel Güncellendi");
                    GetAllUser();
                    panelPerson.Visible = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bilgileri Kontrol ediniz");
                }
            }
        }

        //PERSON COMMANDS FNİSH

        /*-----------------------------------------------------------------------------------*/

        //FILTERS COMMANDS START

        public int categoryFilters;
        private void btnFilter_Click(object sender, EventArgs e)
        {

            if (cmbFilterCategory.Text != "Kategori Seç")
            {
                categoryFilters = cmbFilterCategory.SelectedIndex;
                if (categoryFilters == 0)
                    dataGridProduct.DataSource = productManager.GetAll().Data;
                else
                    dataGridProduct.DataSource = productManager.GetAllByCategoryId(categoryFilters).Data;
            }

            if (cmbFilterSubCategory.Text != "Alt Kategori Seç")
            {
                int subCategoryFilters = cmbFilterSubCategory.SelectedIndex + 1;
                if (categoryFilters == 1)
                {
                    dataGridProduct.DataSource = productManager.GetAllBySubCategoryId(subCategoryFilters).Data;
                }
                else if (categoryFilters == 2)
                {
                    subCategoryFilters = cmbFilterSubCategory.SelectedIndex + 10;
                    dataGridProduct.DataSource = productManager.GetAllBySubCategoryId(subCategoryFilters).Data;
                }
            }

            if (cmbFilterKind.Text != "Tür Seç")
            {
                int kindFilter = cmbFilterKind.SelectedIndex + 1;
                if (categoryFilters == 1)
                {
                    dataGridProduct.DataSource = productManager.GetAllByKindId(kindFilter).Data;
                }
                else if (categoryFilters == 2)
                {
                    kindFilter = cmbFilterKind.SelectedIndex + 10;
                    dataGridProduct.DataSource = productManager.GetAllByKindId(kindFilter).Data;
                }
            }
        }
        public int subCategoryFilters;
        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            subCategoryFilters = cmbFilterCategory.SelectedIndex;
            cmbFilterSubCategory.Items.Clear();
            SubCategoryManager subCategoryManager = new(new EfSubCategoryDal());
            foreach (var item in subCategoryManager.GetAllBySubCategoryId(subCategoryFilters).Data)
            {
                cmbFilterSubCategory.Items.Add(item.SubCategoryName);
            }
        }
        public int kindFilters;
        private void cmbFilterSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subCategoryFilters == 1)
                kindFilters = cmbFilterSubCategory.SelectedIndex + 1;
            else
                kindFilters = cmbFilterSubCategory.SelectedIndex + 10;
            cmbFilterKind.Items.Clear();
            KindManager kindManager = new(new EfKindDal());
            foreach (var item in kindManager.GetAllByCategoryId(kindFilters).Data)
            {
                cmbFilterKind.Items.Add(item.KindName);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelPerson_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        //FİLTERS COMMAND FNİSH
    }
}
