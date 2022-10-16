using PetApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetApp.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new MainContext();

            if (context.Owners.Count() == 0)
            {
                context.Owners.AddRange(Owners);
            }

            if (context.Pets.Count() == 0)
            {
                context.Pets.AddRange(Pets);
            }
        }

        private static Pet[] Pets =
        {
            new Pet() { Name = "Huysuz" },
            new Pet() { Name = "Dişsiz" },
            new Pet() { Name = "Mestan" },
            new Pet() { Name = "Cankız" },
            new Pet() { Name = "Sarı" },
            new Pet() { Name = "Limon" },
            new Pet() { Name = "Minnak" },
        };

        private static Owner[] Owners =
        {
            new Owner() { Name = "Alp", Age = 23, Surname = "Polat" },
            new Owner() { Name = "Melisa", Age = 14, Surname = "Kaya" },
            new Owner() { Name = "Hilal", Age = 20, Surname = "Yıldız" },
            new Owner() { Name = "Can", Age = 27, Surname = "Demirören" },
            new Owner() { Name = "Kaya", Age = 32, Surname = "Bıyıklı" },
        };
    }
}
