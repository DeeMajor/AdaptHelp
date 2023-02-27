using DisplayDetyails.Models;
using DisplayDetyails.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DisplayDetyails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ReadData _readData;

        public HomeController(ILogger<HomeController> logger, ReadData readData)
        {
            _logger = logger;
            _readData = readData;
        }

        public IActionResult Index()
        {
            List<Client> clients = _readData.ReadFile();

            return View(clients);
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