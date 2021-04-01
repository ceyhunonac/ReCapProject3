//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete
//{
//public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//            new Car{CarId=1, BrandId=1, ColorId =1, ModelYear=2021, DailyPrice=550, Description="Mercedes Benz S500" },
//            new Car{CarId=2, BrandId=2, ColorId =2, ModelYear=2020, DailyPrice=300, Description="Honda Accord" },
//            new Car{CarId=3, BrandId=3, ColorId =1, ModelYear=2020, DailyPrice=375, Description="BMW 3.30İXDRIVE" },
//            new Car{CarId=4, BrandId=4, ColorId =3, ModelYear=2021, DailyPrice=190, Description="Renault Clio" },
//            new Car{CarId=5, BrandId=5, ColorId =2, ModelYear=2021, DailyPrice=475, Description="Tesla Model S" }
//            };
        
//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            _cars.Remove(car);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetById(int CarId)
//        {
//            return _cars.Where(c => c.CarId == CarId).ToList();
            
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;
//        }
//    }
//}
