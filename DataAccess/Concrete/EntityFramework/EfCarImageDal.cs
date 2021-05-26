using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentACarContext>, ICarImageDal
    {
        public List<CarImagesDetailDto> GetDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from img in context.CarImages
                             join ca in context.Cars on img.CarId equals ca.CarId
                             join b in context.Brands on ca.BrandId equals b.BrandId
                             join c in context.Colors on ca.ColorId equals c.ColorId

                             select new CarImagesDetailDto
                             {
                                 CarId = ca.CarId,
                                 ImagePath = img.ImagePath
                             };
                return result.ToList();
            }
        }

        public List<CarImage> GetImageByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from i in context.CarImages
                             join c in context.Cars on i.CarId equals c.CarId
                             where c.BrandId == brandId
                             select i;
                return result.ToList();
            }
        }

        public List<CarImage> GetImageByBrandIdAndColorId(int brandId, int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from i in context.CarImages
                             join c in context.Cars on i.CarId equals c.CarId
                             where c.BrandId == brandId && c.ColorId == colorId
                             select i;
                return result.ToList();
            }
        }

        public List<CarImage> GetImageByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from i in context.CarImages
                             join c in context.Cars on i.CarId equals c.CarId
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             where clr.ColorId == colorId
                             select i;
                return result.ToList();
            }
        }

        public bool IsExist(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }

    }
}
