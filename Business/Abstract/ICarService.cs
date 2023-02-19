using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        public List<Car> GetCarsByBrandId(int id);
        public List<Car> GetCarsByColorId(int id);
        public List<CarDetailDto> GetProductDetails();
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
        public Car GetById(int id);
    }
}
