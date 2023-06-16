using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EmployeeTest();
            //RoleTest();
            //PersonTest();
            //productTest();
            //UserManager userManager=new UserManager(new EfUserDal());
            //foreach (var item in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(item);
            //}
            SaleManager saleManager = new SaleManager(new EfSaleDal());
            foreach (var item in saleManager.GetAll().Data)
            {
                Console.WriteLine(item.Id+item.SalesType+item.SellDay);
            }
        }

        private static void productTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAll().Data)
            {
                //Console.WriteLine(item.ProductName + " " + item.PurchasePrice + " " + item.SalePrice);
            }
        }


        private static void RoleTest()
        {
            RoleManager roleManager = new RoleManager(new EfRoleDal());
            foreach (var item in roleManager.GetAll().Data)
            {
                Console.WriteLine(item.RoleName);
            }
        }


    }
}