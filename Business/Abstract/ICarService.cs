using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int brandid);

        IDataResult<List<Car>> GetCarsByColorId(int colorid);

        IDataResult<List<CarDetailDto>> GetProductDetails();

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult AddTransactionalTest(Car car);

        IResult Update(Car car);
    }
}
