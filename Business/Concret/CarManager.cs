using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
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

        public Car Add(Car car)
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
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _cardal.GetAll(c => c.BrandId == brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _cardal.GetAll(c => c.ColorId == colorid);
        }

        public List<CarDetailDto> GetProductDetails()
        {
            return _cardal.GetProductDetails();
        }
    }
}
