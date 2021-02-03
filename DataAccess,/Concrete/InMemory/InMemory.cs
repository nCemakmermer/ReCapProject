using DataAccess_.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess_.Concrete.InMemory
{
    public class InMemory : ICarDal
    {
        List<Cars> _cars;

        public InMemory()
        {
            _cars = new List<Cars>()
            {
                new Cars{Id=1,BrandId=1,Model="Toyata",ColorId="#230C0C",DailyPrice=60504,ModelYear=2020,Description="2.0T Petrol 8 sp Automatic RWD" },
                new Cars{Id=2,BrandId=1,Model="Toyata",ColorId="#230C0C",DailyPrice=24354,ModelYear=2016,Description="1.6 Tdi Super Dynamic" },
                new Cars{Id=3,BrandId=2,Model="BMW",ColorId="#240C0C",DailyPrice=25504,ModelYear=2012,Description="2.5T Ultra Turbo Elagant+" },
                new Cars{Id=4,BrandId=3,Model="Tesla",ColorId="#330C0C",DailyPrice=50434,ModelYear=2018,Description="Normal Charger 9V 150 Minutes" },
                new Cars{Id=5,BrandId=3,Model="Tesla",ColorId="#520A0C",DailyPrice=76543,ModelYear=2020,Description="Faster Charge 12V 120 Minutes" },

            };

        }

        public void Add(Cars cars)
        {
            _cars.Add(cars);
        }

        public void Delete(Cars cars)
        {
            Cars DeleteToCars = _cars.SingleOrDefault(c => c.Id == cars.Id);

            _cars.Remove(DeleteToCars);
        }

        public List<Cars> GetAllCategory(int BrendId)
        {
            return _cars.Where(p => p.Id == BrendId).ToList();
        } 
        public List<Cars> GetCars()
        {
            return _cars;
        }

        public void Update(Cars cars)
        {
            Cars UpdateToCars = _cars.SingleOrDefault(c=>c.Id == cars.Id);

            UpdateToCars.Id = cars.Id;
            UpdateToCars.BrandId = cars.BrandId;
            UpdateToCars.ColorId = cars.ColorId;
            UpdateToCars.Model = cars.Model;
            UpdateToCars.DailyPrice = cars.DailyPrice;
            UpdateToCars.Description= cars.Description;
        }
    }
}