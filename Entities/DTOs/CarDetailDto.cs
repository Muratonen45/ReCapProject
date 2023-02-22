using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public short UnitsInStock { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string Colorname { get; set; }
        public object ColorName { get; set; }
        public int DailyPrice { get; set; }
        public int Description { get; set; }
        public object ModelYear { get; set; }
    }
}
