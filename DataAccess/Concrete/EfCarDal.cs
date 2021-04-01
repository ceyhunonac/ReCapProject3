using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;


namespace DataAccess.Concrete
{

	public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (ReCapContext context = new ReCapContext())
			{
				var result = from c in context.Cars
							 join r in context.Colors
							 on c.ColorId equals r.ColorId
							 join b in context.Brands on c.BrandId equals b.BrandId
							 orderby c.BrandId
							 select new CarDetailDto
							 {
								
								 DailyPrice = c.DailyPrice,
								 
							 };

				return result.ToList();
			}
		}
	}
}
