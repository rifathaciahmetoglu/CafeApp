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
    public class BillManager : IBillService
    {
        IBillDal _billDal;
        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public IResult Add(Bill bill)
        {
            _billDal.Add(bill);
            return new SuccessResult();
        }

        public IDataResult<List<Bill>> GetAll()
        {
            return new DataResult<List<Bill>>(_billDal.GetAll(), true);
        }

        public IDataResult<List<Bill>> GetByDeskId(int id)
        {
            return new SuccessDataResult<List<Bill>>(_billDal.GetAll(b => b.DeskId == id));
        }

        public IDataResult<Bill> GetById(int id)
        {
            return new SuccessDataResult<Bill>(_billDal.Get(b => b.BillId == id));
        }

        public IDataResult<Bill> GetByOrderId(int id)
        {
            return new SuccessDataResult<Bill>(_billDal.Get(b => b.OrderId == id));
        }

        public IResult Update(Bill bill)
        {
            _billDal.Update(bill);
            return new SuccessResult();
        }
    }
}
