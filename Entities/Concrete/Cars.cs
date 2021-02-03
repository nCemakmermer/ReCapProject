using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
 public  class Cars : IEntitiy
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ColorId { get; set; }
        public short ModelYear { get; set; }
        public string Model { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
