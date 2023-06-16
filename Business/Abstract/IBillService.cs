using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillService
    {
        IDataResult<List<Bill>> GetAll();
        IDataResult<List<Bill>> GetByDeskId(int id);
        IDataResult<Bill> GetById(int id);
        IDataResult<Bill> GetByOrderId(int id);
        IResult Add(Bill bill);
        IResult Update(Bill bill);
    }
}
