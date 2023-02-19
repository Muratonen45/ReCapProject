using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal() { 
            _cars = new List<Car>() {


                new Car {CarId = 1, BrandId =  2, ModelYear = 2022, DailyPrice = 1000, Description = "Mercedes-Benz"},
                new Car {CarId = 2, BrandId =  2, ModelYear = 2023, DailyPrice = 1200, Description = "Maybec"},
                new Car {CarId = 3, BrandId =  1, ModelYear = 2021, DailyPrice = 750, Description = "BMW 2 SERİSİ GRAN COUPÉ"},
                new Car {CarId = 4, BrandId =  1, ModelYear = 2022, DailyPrice = 800, Description = "YENİ BMW 3 SERİSİ SEDAN"},
                new Car {CarId = 5, BrandId =  3, ModelYear = 1969, DailyPrice = 2000, Description = "Mustang Elektirikli"},

            }; 
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Description + " Added");
        }

        public void Delete(Car car)
        {
            Car carForDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carForDelete);
            Console.WriteLine(carForDelete.Description + " Deleted");
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.CarId==Id).ToList();   
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carForUptate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carForUptate.Description = car.Description;
            carForUptate.ModelYear = car.ModelYear;
            carForUptate.DailyPrice = car.DailyPrice;
            carForUptate.BrandId = car.BrandId;
            carForUptate.ColorId= car.ColorId;  
        }
    }
}
