using Business.Concret;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
        }

        private static void ProductTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.ColorName);
            }
        }

    }
}
