using ClientManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientService _clientService;

        public HomeController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            return View(_clientService.GetClients());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
