using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public List<PetOwners> PetOwners { get; set; }
    }
}
