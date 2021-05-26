using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class IMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public IMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId=1,ColorId=1,ModelYear=2001,DailyPrice=10000,Description="Qezasiz"},
                new Car{CarId = 2,BrandId=1,ColorId=1,ModelYear=2002,DailyPrice=10000,Description="Qezasiz"},
                new Car{CarId = 3,BrandId=1,ColorId=1,ModelYear=2003,DailyPrice=10000,Description="Qezasiz"},
                new Car{CarId = 4,BrandId=1,ColorId=1,ModelYear=2004,DailyPrice=10000,Description="Qezasiz"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var result = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.BrandId == CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var UpdatedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            UpdatedCar.ColorId = car.ColorId;
            UpdatedCar.BrandId = car.BrandId;
            UpdatedCar.DailyPrice = car.DailyPrice;
            UpdatedCar.Description = car.Description;
            UpdatedCar.ModelYear = car.ModelYear;
        }
    }
}
