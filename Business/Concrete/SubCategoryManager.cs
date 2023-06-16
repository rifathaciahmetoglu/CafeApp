using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubCategoryManager:ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;
        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {

            _subCategoryDal = subCategoryDal;

        }

        public IDataResult<List<SubCategory>> GetAll()
        {
            return new DataResult<List<SubCategory>>(_subCategoryDal.GetAll(), true);
        }

        public IDataResult<SubCategory> GetById(int id)
        {
            return new SuccessDataResult<SubCategory>(_subCategoryDal.Get(p => p.SubCategoryId == id));
        }
        public IDataResult<List<SubCategory>> GetAllBySubCategoryId(int subId)
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll(p => p.CategoryId == subId));
        }
    }
}
