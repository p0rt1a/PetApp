using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class HotelCategory
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
