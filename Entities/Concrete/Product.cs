using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int KindId { get; set; }
        public string ?ProductName { get; set; }
        public double SalePrice { get; set; }
    }
}
