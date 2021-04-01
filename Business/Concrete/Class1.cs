using Business.Abstract;

using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalsManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAllById(int rentalId)
        {

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.RentalId == rentalId));
        }

        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate == null)
            {

                return new ErrorResult("Hata bulundu!");

            }

            _rentalDal.Add(rental);
            return new SuccessResult("Eklendi");

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Güncellendi");
        }
    }
}