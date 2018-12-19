using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AutoMapper;
using ClientManager.Domain.Models;
using ClientManager.Domain.Services;
using ClientManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;      

        public ClientController(IClientService clientService, IMapper mapper)
        {
            _mapper = mapper;
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            var clientList = _clientService.GetClients();

            return View(_mapper.Map<ICollection<ClientViewModel>>(clientList));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("Client/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var client = _clientService.GetClientById(id);

            return View(_mapper.Map<ClientViewModel>(client));
        }

        [HttpPost("Client/Edit/{id}")]
        public IActionResult Edit(ClientViewModel client)
        {
            var clientModel = _mapper.Map<ClientModel>(client);
            _clientService.Update(clientModel);

            return RedirectToAction("Index", "Client");
        }

        [HttpGet("Client/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _clientService.DeleteById(id);

            return RedirectToAction("Index", "Client");
        }

        [HttpPost]
        public IActionResult Create(ClientViewModel client)
        {
            var clientModel = _mapper.Map<ClientModel>(client);
            _clientService.Create(clientModel);

            return RedirectToAction("Index", "Client");
        }
    }
}