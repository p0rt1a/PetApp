using PetApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace PetApp.WebUI.ViewModels
{
    public class PetViewModel
    {
        public List<Pet> Pets { get; set; }
        public List<Owner> Owners { get; set; }
    }
}
