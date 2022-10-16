using PetApp.Data.Abstract;
using PetApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Data.Concrete.EfCore
{
    public class EfCorePetRepository : EfCoreGenericRepository<Pet, MainContext>, IPetRepository
    {
    }
}
