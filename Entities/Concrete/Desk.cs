using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class Desk:IEntity
    {
        public int DeskId { get; set; }
        public string DeskName { get; set; }
    }
}
