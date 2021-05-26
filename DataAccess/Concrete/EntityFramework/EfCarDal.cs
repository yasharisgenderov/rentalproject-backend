using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             join img in context.CarImages on c.CarId equals img.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColorId = clr.ColorId,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                             };
                return result.ToList();
            }
        }
            public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
            {
                using (RentACarContext context = new RentACarContext())
                {
                    var result = from c in context.Cars
                                 join b in context.Brands on c.BrandId equals b.BrandId
                                 join clr in context.Colors on c.ColorId equals clr.ColorId
                                 where c.BrandId == brandId
                                 select new CarDetailDto
                                 {
                                     CarId = c.CarId,
                                     ColorId = clr.ColorId,
                                     BrandId = b.BrandId,
                                     BrandName = b.BrandName,
                                     ColorName = clr.ColorName,
                                     ModelYear = c.ModelYear,
                                     DailyPrice = c.DailyPrice,
                                     Description = c.Description,
                                     ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                                 };
                    return result.ToList();
                }
            }

            public List<CarDetailDto> GetCarDetailsByCarId(int carId)
            {
                using (RentACarContext context = new RentACarContext())
                {
                    var result = from c in context.Cars
                                 join b in context.Brands on c.BrandId equals b.BrandId
                                 join clr in context.Colors on c.ColorId equals clr.ColorId
                                 where c.CarId == carId
                                 select new CarDetailDto
                                 {
                                     CarId = c.CarId,
                                     ColorId = clr.ColorId,
                                     BrandId = b.BrandId,
                                     BrandName = b.BrandName,
                                     ColorName = clr.ColorName,
                                     ModelYear = c.ModelYear,
                                     DailyPrice = c.DailyPrice,
                                     Description = c.Description,
                                     ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                                 };
                    return result.ToList();
                }
            }

            public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
            {
                using (RentACarContext context = new RentACarContext())
                {
                    var result = from c in context.Cars
                                 join b in context.Brands on c.BrandId equals b.BrandId
                                 join clr in context.Colors on c.ColorId equals clr.ColorId
                                 where c.ColorId == colorId
                                 select new CarDetailDto
                                 {
                                     CarId = c.CarId,
                                     ColorId = clr.ColorId,
                                     BrandId = b.BrandId,
                                     BrandName = b.BrandName,
                                     ColorName = clr.ColorName,
                                     ModelYear = c.ModelYear,
                                     DailyPrice = c.DailyPrice,
                                     Description = c.Description,
                                     ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                                 };
                    return result.ToList();
                }
            }

            public List<CarDetailDto> GetCarsByBrandIdAndColorId(int brandId, int colorId)
            {
                using (RentACarContext context = new RentACarContext())
                {
                    var result = from c in context.Cars
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join clr in context.Colors
                                 on c.ColorId equals clr.ColorId
                                 where b.BrandId == brandId && clr.ColorId == colorId
                                 select new CarDetailDto
                                 {
                                     CarId = c.CarId,
                                     ColorId = clr.ColorId,
                                     BrandId = b.BrandId,
                                     BrandName = b.BrandName,
                                     ColorName = clr.ColorName,
                                     ModelYear = c.ModelYear,
                                     DailyPrice = c.DailyPrice,
                                     Description = c.Description,
                                     ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                                 };
                    return result.ToList();
                }
            }
        }
}   