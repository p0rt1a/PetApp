using PetApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Business.Abstract
{
    public interface IPetService
    {
        public List<Pet> GetAll();
        public void Create(Pet pet);
        public void Delete(Pet pet);
        public void Update(Pet pet);
        public Pet GetById(int id);
    }
}
