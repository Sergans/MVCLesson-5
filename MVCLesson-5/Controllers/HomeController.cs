using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLesson_5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVCLesson_5.Operation;

namespace MVCLesson_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WeatherYandex _weather;

        public HomeController(ILogger<HomeController> logger,WeatherYandex weather)
        {
            _logger = logger;
            _weather = weather;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Weather()
        {
            _weather.GetWeather();
            return View(new WeatherModel {WeatherM=_weather.weather});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
