using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsBrandId(int carId);
        List<Car> GetCarsColorId(int carId);
        List<CarDetailDto> GetCarDetails();
    }
}
