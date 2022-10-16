using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<Pet> Pets { get; set; }
        public Hotel? FavouriteHotel { get; set; }
    }
}
