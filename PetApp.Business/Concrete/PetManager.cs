using PetApp.Business.Abstract;
using PetApp.Data.Abstract;
using PetApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Business.Concrete
{
    public class PetManager : IPetService
    {
        private IPetRepository _petRepository;

        public PetManager(IPetRepository petRepository)
        {
            this._petRepository = petRepository;
        }

        public void Create(Pet pet)
        {
            // iş kuralları
            _petRepository.Create(pet);
        }

        public void Delete(Pet pet)
        {
            _petRepository.Delete(pet);
        }

        public List<Pet> GetAll()
        {
            return _petRepository.GetAll();
        }

        public Pet GetById(int id)
        {
            return _petRepository.GetById(id);
        }

        public void Update(Pet pet)
        {
            _petRepository.Update(pet);
        }
    }
}
