using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concret
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        /*public Car Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                Console.WriteLine("Masin adi 2 simvoldan boyuk olmalidir");
            }

            if (car.DailyPrice<=0)
            {
                Console.WriteLine("Masinin qiymeti 0dan boyuk olmalidir");
            }

            _cardal.Add(car);
            Console.WriteLine("Masin ugurla elave edildi");
            return car;
        }*/

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _cardal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_cardal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandid)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.BrandId == brandid));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.ColorId == colorid));
        }

        public IDataResult<List<CarDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetProductDetails());
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
