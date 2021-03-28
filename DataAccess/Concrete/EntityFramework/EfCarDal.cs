using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IEntityRepository<Car>, ICarDal
    {
        public void Add(Car entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var addedcontext = context.Entry(entity);
                addedcontext.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var deletedcontext = context.Entry(entity);
                deletedcontext.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var updatedcontext = context.Entry(entity);
                updatedcontext.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
