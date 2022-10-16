using PetApp.Data.Abstract;
using PetApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Data.Concrete.EfCore
{
    public class EfCoreOwnerRepository : EfCoreGenericRepository<Owner, MainContext>, IOwnerRepository
    {
    }
}
