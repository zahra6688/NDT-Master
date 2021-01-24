using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NDT.Infra.Data.Repositories;

namespace NDTManagement.MVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        

        public IActionResult Index()
        {
            return View(_clientRepository.Clients);
        }
    }
}
