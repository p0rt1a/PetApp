using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class PetCategory
    {
        public int PetId { get; set; }
        public Hotel Pet { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
