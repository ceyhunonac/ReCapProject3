﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());

        }

        public IDataResult<List<User>> GetAllById(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.Id == userId));
         }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Güncelllendi");
        }
    }
}
