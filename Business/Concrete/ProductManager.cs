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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new DataResult<List<Product>>(_productDal.GetAll(), true);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Product>> GetAllBySubCategoryId(int subId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.SubCategoryId == subId));
        }
        public IDataResult<List<Product>> GetAllByKindId(int kindId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.KindId == kindId));
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAllByProductName(string productName)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.ProductName == productName));
        }
    }
}
