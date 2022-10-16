using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class PetOwners
    {
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
