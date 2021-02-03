using Business.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarService _carService;
        public CarManager(ICarService carService)
        {
            _carService = carService;
        }

        public List<Cars> GetCars()
        {
            return _carService.GetCars();
        }
    }
}
