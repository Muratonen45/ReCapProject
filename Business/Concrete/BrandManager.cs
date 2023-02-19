using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetBrandsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetBrandsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
