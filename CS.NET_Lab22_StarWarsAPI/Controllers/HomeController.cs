using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CS.NET_Lab22_StarWarsAPI.Models;
using System.Net.Http;

namespace CS.NET_Lab22_StarWarsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetPersonbyId(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"people/{id}");
            var result = await response.Content.ReadAsAsync<SWCharacterRoot>(); //Endpoints
            return View(result);
        }

        public async Task<IActionResult> GetPlanetbyId(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"planets/{id}");
            var result = await response.Content.ReadAsAsync<SWPlanetRoot>(); //Endpoints
            return View(result);
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
