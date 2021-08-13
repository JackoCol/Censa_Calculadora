using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mi_Calculadora.Models;

namespace Mi_Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalculadoraController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
