using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarImageDal : IEntityRepository<CarImage>
    {
        bool IsExist(int id);

        List<CarImagesDetailDto> GetDetails();

        List<CarImage> GetImageByBrandId(int brandId);
        List<CarImage> GetImageByColorId(int colorId);
        List<CarImage> GetImageByBrandIdAndColorId(int brandId, int colorId);
    }
}
