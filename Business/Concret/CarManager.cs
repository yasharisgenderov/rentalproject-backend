using Business.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concret
{
    public class CarManager : ICarService
    {
        IMemoryCarDal _cardal;

        public CarManager(IMemoryCarDal cardal)
        {
            _cardal = cardal;
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }
    }
}
