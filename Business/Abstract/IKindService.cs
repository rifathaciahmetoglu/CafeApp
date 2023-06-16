using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKindService
    {
        IDataResult<List<Kind>> GetAll();
        IDataResult<Kind> GetById(int id);
        IDataResult<List<Kind>> GetAllByCategoryId(int kindId);
    }
}
