using Microsoft.AspNetCore.Mvc;
using PetApp.Data.Abstract;
using PetApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IPetRepository _petRepository;
        private IOwnerRepository _ownerRepository;

        public HomeController(IPetRepository petRepository, IOwnerRepository ownerRepository)
        {
            this._petRepository = petRepository;
            this._ownerRepository = ownerRepository;
        }

        public IActionResult Index()
        {
            PetViewModel petViewModel = new PetViewModel()
            {
                Pets = _petRepository.GetAll(),
                Owners = _ownerRepository.GetAll()
            };
            return View(petViewModel);
        }
    }
}
