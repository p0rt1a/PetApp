using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public decimal NightlyPrice { get; set; }
        public string Address { get; set; }
        public List<Category> Categories { get; set; }
    }
}
