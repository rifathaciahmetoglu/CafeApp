using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Sale:IEntity
    {
        public int Id { get; set; }
        public DateTime SellDay { get; set; }
        public int TotalPrice { get; set; }
        public string SalesType { get; set; }
    }
}
