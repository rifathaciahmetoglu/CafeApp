using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;
        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }
        public IResult Add(Sale sale)
        {
            _saleDal.Add(sale);
            return new SuccessResult();
        }

        public IDataResult<List<Sale>> GetAll()
        {
            return new DataResult<List<Sale>>(_saleDal.GetAll(),true);
        }

        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult();
        }
    }
}
