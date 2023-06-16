﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllBySubCategoryId(int subId);
        IDataResult<List<Product>> GetAllByKindId(int kindId);
        IDataResult<List<Product>> GetAllByProductName(string productName);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
