﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Entity
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<PetOwners> PetOwners { get; set; }
    }
}
