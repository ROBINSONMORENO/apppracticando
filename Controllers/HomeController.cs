using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using apppracticando.Models;
using apppracticando.Data;

namespace apppracticando.Controllers
{
    public class HomeController : Controller
    {
     private ApppracticandoDbContext _context;
        public HomeController(ApppracticandoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();         
        }
    }
}  
