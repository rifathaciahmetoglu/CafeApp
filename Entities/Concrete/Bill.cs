using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bill:IEntity
    {
        public int BillId { get; set; }
        public int DeskId { get; set; }
        public int OrderId { get; set; }
        public string? OrderName { get; set; }
        public int Piece { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
    }
}
