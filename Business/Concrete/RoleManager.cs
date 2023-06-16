﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public IDataResult<List<Role>> GetAll()
        {
            return new DataResult<List<Role>>(_roleDal.GetAll(), true);
        }

        public IDataResult<Role> GetById(int id)
        {
            return new SuccessDataResult<Role>(_roleDal.Get(p => p.RoleId == id));
        }
    }
}
