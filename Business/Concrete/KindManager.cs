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
    public class KindManager:IKindService
    {
        IKindDal _kindDal;
        public KindManager(IKindDal kindDal)
        {
            _kindDal = kindDal;
        }
        public IDataResult<List<Kind>> GetAll()
        {
            return new DataResult<List<Kind>>(_kindDal.GetAll(), true);
        }

        public IDataResult<List<Kind>> GetAllByCategoryId(int kindId)
        {
            return new SuccessDataResult<List<Kind>>(_kindDal.GetAll(p => p.SubCategoryId == kindId));
        }

        public IDataResult<Kind> GetById(int id)
        {
            return new SuccessDataResult<Kind>(_kindDal.Get(p => p.KindId == id));
        }
    }
}
