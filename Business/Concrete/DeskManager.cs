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
    public class DeskManager : IDeskService
    {
        IDeskDal _deskDal;
        public DeskManager(IDeskDal deskDal)
        {
            _deskDal = deskDal;
        }
        public IDataResult<List<Desk>> GetAll()
        {
            return new DataResult<List<Desk>>(_deskDal.GetAll(), true);
        }

        public IDataResult<Desk> GetById(int id)
        {
            return new SuccessDataResult<Desk>(_deskDal.Get(p => p.DeskId == id));
        }

        public IResult Update(Desk order)
        {
            _deskDal.Update(order);
            return new SuccessResult();
        }
    }
}
