using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarTest();

            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //foreach (var cars in carManager.GetAll())
            //{
            //    System.Console.WriteLine("ARAÇ BİLGİLERİ : " + " " + cars.Description);
            //    System.Console.WriteLine("MODEL YILI : " + " " + cars.ModelYear);
            //    System.Console.WriteLine("GÜNLÜK FİYATI : " + " " + cars.DailyPrice);
            //}


        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.CarName + "/" + car.BrandName);
            }
        }
    }
}
