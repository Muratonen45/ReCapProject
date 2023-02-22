using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InMemoryTest();
            Console.WriteLine("EF");
            CarManager carManagerEF = new CarManager(new EfCarDal());
            BrandManager brandManagerEF = new BrandManager(new EfBrandDal());
            ColorManager colorManagerEF = new ColorManager(new EfColorDal());
            UserManager userManagerEF = new UserManager(new EfUserDal());
            CustomerManager customerManagerEF = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManagerEF = new RentalManager(new EfRentalDal());

            //Test Edildi:GetAll,GetById,Add,Update,Delete,DTO

            //AddEntries(carManagerEF, brandManagerEF, colorManagerEF,customerManagerEF,userManagerEF);

            //UpdateEntries(carManagerEF, brandManagerEF, colorManagerEF);
            //DeleteTest(colorManagerEF);

            //Console.WriteLine("===Car GetAll===");
            //GetAllCarDetail(carManagerEF);
            //Console.WriteLine("---DTO GetCarDetails:");
            //GetCarDetailsDtoTest(carManagerEF);

            //Console.WriteLine("---Car GetById:" + carManagerEF.GetById(2).Data.Description);

            //BrandGetAll(brandManagerEF);
            //ColorGetAll(colorManagerEF);
            //UserGetAll(userManagerEF);
            //CustomerGetAll(customerManagerEF);

            //RentalAddTest(rentalManagerEF);
            RentalGetAll(rentalManagerEF);

        }//Metodlar
            
        private static void RentalGetAll(RentalManager rentalManagerEF)
        {
            var result = rentalManagerEF.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentDate);
                }
            }
        }

        private static void RentalAddTest(RentalManager rentalManagerEF)
        {
            rentalManagerEF.Add(new Rental
            {
                
                CarId = 2,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Today
            });
        }

        private static void CustomerGetAll(CustomerManager customerManagerEF)
        {
            var result = customerManagerEF.GetAll();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }

        private static void UserGetAll(UserManager userManagerEF)
        {
            var result = userManagerEF.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName);
                }
            }
        }

        private static void ColorGetAll(ColorManager colorManagerEF)
        {
            Console.WriteLine("===Color===");

                foreach (var color in colorManagerEF.GetAll().Data)
                    Console.WriteLine("* Color Id:{0} | Color Name: {1}", color.ColorId, color.ColorName);
          
            Console.WriteLine("---Color GetById:" + colorManagerEF.GetById(3).Data.ColorName);
        }

        private static void BrandGetAll(BrandManager brandManagerEF)
        {
            Console.WriteLine("===Brand GetAll===");
            foreach (var brand in brandManagerEF.GetAll().Data)
                Console.WriteLine("* Brand Id:{0} | Brand Name: {1}", brand.BrandId, brand.BrandName);
            Console.WriteLine("---Brand GetById:" + brandManagerEF.GetById(4).Data.BrandName);
        }

        private static void GetCarDetailsDtoTest(CarManager carManagerEF)
        {
            
                foreach (var car in carManagerEF.GetCarDetails().Data)
                {
                    Console.WriteLine(
                        "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ",
                        car.Description,
                        car.DailyPrice,
                        car.ModelYear,
                        car.BrandName,
                        car.ColorName);
                }
        }

        private static void GetAllCarDetail(CarManager carManagerEF)
        {
                foreach (var car in carManagerEF.GetAll().Data)
                {
                    Console.WriteLine(
                    "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ",
                    car.Description,
                    car.DailyPrice,
                    car.ModelYear,
                    car.BrandId,
                    car.ColorId);
                }
        }

        //Metodlar
        private static void DeleteTest(ColorManager colorManagerEF)
        {
            colorManagerEF.Add(new Color { ColorId = 5, ColorName = "YanlışRenk" });
            colorManagerEF.Delete(new Color { ColorId = 5, ColorName = "YanlışRenk" });
        }

       
        private static void AddEntries(CarManager carManagerEF, BrandManager brandManagerEF, ColorManager colorManagerEF, CustomerManager customerManagerEF, UserManager userManagerEF)
        {
            carManagerEF.Add(new Car {  BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = 2002, Description = "Külüstür" });
            carManagerEF.Add(new Car {  BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear =1968, Description = "Retro" });
            carManagerEF.Add(new Car {  BrandId = 2, ColorId = 3, DailyPrice = 250000, ModelYear = 1996, Description = "Aile" });
            carManagerEF.Add(new Car {  BrandId = 2, ColorId = 1, DailyPrice = 300000, ModelYear = 2012, Description = "Spor" });
            carManagerEF.Add(new Car {  BrandId = 3, ColorId = 2, DailyPrice = 80000, ModelYear = 2008, Description = "Günlük" });
            carManagerEF.Add(new Car {  BrandId = 3, ColorId = 3, DailyPrice = 130000, ModelYear = 2018, Description = "Fiyat-Performans" });
            carManagerEF.Add(new Car {  BrandId = 4, ColorId = 1, DailyPrice = 260000, ModelYear = 2015, Description = "Dağ" });
            carManagerEF.Add(new Car {  BrandId = 5, ColorId = 3, DailyPrice = 110000, ModelYear = 2005, Description = "Külüstür v2" });
            carManagerEF.Add(new Car {  BrandId = 2, ColorId = 4, DailyPrice = 275000, ModelYear = 2014, Description = "Hız" });
            Console.WriteLine("Added Car Entries with EF...");
            brandManagerEF.Add(new Brand {  BrandName = "Tofaş" });
            brandManagerEF.Add(new Brand {  BrandName = "Ford" });
            brandManagerEF.Add(new Brand {  BrandName = "Volvo" });
            brandManagerEF.Add(new Brand {  BrandName = "Nissan" });
            brandManagerEF.Add(new Brand {  BrandName = "Volkswagen" });
            brandManagerEF.Add(new Brand {  BrandName = "Ferrari" });
            Console.WriteLine("Added Brand Entries with EF...");
            colorManagerEF.Add(new Color {  ColorName = "Kırmızı" });
            colorManagerEF.Add(new Color {  ColorName = "Beyaz" });
            colorManagerEF.Add(new Color {  ColorName = "Siyah" });
            colorManagerEF.Add(new Color {  ColorName = "Mavi" });

            Console.WriteLine("Added Color Entries with EF...");

            customerManagerEF.Add(new Customer { CompanyName = "A Firması", UserId = 1 });
            customerManagerEF.Add(new Customer { CompanyName = "B Firması", UserId = 2 });
            customerManagerEF.Add(new Customer { CompanyName = "C Firması", UserId = 3 });
            customerManagerEF.Add(new Customer { CompanyName = "D Firması", UserId = 4 });

            Console.WriteLine("Added Customer Entries with EF...");

            userManagerEF.Add(new User {  FirstName = "Murat", LastName = "Önen", Email = "muratonen2002@gmail.com", Password = "123456" });
            userManagerEF.Add(new User {  FirstName = "Ayşe", LastName = "Demir", Email = "a.demir@mail.com", Password = "123456" });
            userManagerEF.Add(new User {  FirstName = "Ahmet", LastName = "Yılmaz", Email = "a.yilmaz@mail.com", Password = "123456" });
            userManagerEF.Add(new User {  FirstName = "John", LastName = "Carpenter", Email = "j.carpenter@mail.com", Password = "123456" });
            userManagerEF.Add(new User {  FirstName = "Alfred", LastName = "Hitchcock", Email = "a.hitchcock@mail.com", Password = "123456" });


            Console.WriteLine("Added User Entries with EF...");
        }

        private static void UpdateEntries(CarManager carManagerEF, BrandManager brandManagerEF, ColorManager colorManagerEF)
        {
            carManagerEF.Update(new Car { CarId = 9, BrandId = 2, ColorId = 4, DailyPrice = 275000, ModelYear = 2014, Description = "Hızlı" });
            colorManagerEF.Update(new Color { ColorId = 4, ColorName = "Blue" });
            brandManagerEF.Update(new Brand { BrandId = 6, BrandName = "Ferrari S.p.A" });
        }
        private static void InMemoryTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            GetAllTest(inMemoryCarDal);
            Console.WriteLine("------");
            AddTestInMemory(inMemoryCarDal);
            Console.WriteLine("------");
            GetByIdTest(inMemoryCarDal);
            Console.WriteLine("------");
            inMemoryCarDal.Update(new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear = 1964, Description = "Retro Update" });

            Console.WriteLine("in memory");
            
                foreach (var car in carManager.GetByUnitPrice(40, 100).Data)
                {
                    Console.WriteLine(car.Description);
                }
        }
        private static void GetByIdTest(InMemoryCarDal inMemoryCarDal)
        {
            Console.WriteLine(inMemoryCarDal.GetById(5));
        }
        private static void AddTestInMemory(InMemoryCarDal inMemoryCarDal)
        {
            inMemoryCarDal.Add(new Car { CarId = 8, BrandId = 8, ColorId = 8, DailyPrice = 800000, ModelYear = 1972, Description = "Yeni Retro" });
            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(
                "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ", car.Description,
                car.DailyPrice,
                car.ModelYear,
                car.BrandId,
                car.ColorId);
            };
        }
        private static void GetAllTest(InMemoryCarDal inMemoryCarDal)
        {
            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(
                "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ", car.Description,
                car.DailyPrice,
                car.ModelYear,
                car.BrandId,
                car.ColorId);
            }; ;
        }
    }
}
    

