using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kind:IEntity
    {
        public int KindId { get; set; }
        public int SubCategoryId { get; set; }
        public string ?KindName { get; set; }
    }
}
