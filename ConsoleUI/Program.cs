using Business.Concret;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new IMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
        }

        
    }
}
