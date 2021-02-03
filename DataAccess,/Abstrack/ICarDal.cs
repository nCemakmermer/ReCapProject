using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess_.Abstrack
{
    interface ICarDal
    {
        List<Cars> GetCars();

        void Add(Cars cars);
        void Update(Cars cars);

        void Delete(Cars cars);
        List<Cars> GetAllCategory(int BrendId);
    }
}
