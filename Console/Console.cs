﻿using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //    CarManager carManager = new CarManager(new EfCarDal());
            //    foreach (var car in carManager.GetCarDetails())
            //    {
            //        Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName);
            //    }
            //}
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}