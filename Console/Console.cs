using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Description = "Mercedees Benz S500", BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = 2021, CarId = 1 });
            Console.WriteLine("Eklendi" + Environment.NewLine);
            list();

            void list()
            {
                Console.WriteLine("Eklendi" + Environment.NewLine);
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.CarId + " " + car.Description + "  " + car.DailyPrice + "$ " + car.Description);
                }
            }
        }

    }
}