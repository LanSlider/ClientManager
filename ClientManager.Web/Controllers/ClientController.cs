using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            return View(_clientService.GetClients());
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

            return View(client);
        }

        [HttpPost("Client/Edit/{id}")]
        public IActionResult Edit(Client client)
        {
            _clientService.Update(client);

            return RedirectToAction("Index", "Client");
        }

        [HttpGet("Client/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _clientService.DeleteById(id);

            return RedirectToAction("Index", "Client");
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            _clientService.Create(client);

            return RedirectToAction("Index", "Client");
        }
    }
}