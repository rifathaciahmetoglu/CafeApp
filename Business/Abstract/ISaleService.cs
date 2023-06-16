using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaleService
    {
        IResult Add(Sale sale);

        IResult Update(Sale sale);
        IDataResult<List<Sale>> GetAll();

    }
}
