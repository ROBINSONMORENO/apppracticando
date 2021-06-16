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
    public class FailController : Controller
    {
     private ApppracticandoDbContext _context;
        public FailController(ApppracticandoDbContext context)
        {
            _context = context;
        }
        public IActionResult SubirFail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubirFail(Fail f)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f);
                _context.SaveChanges();

                return RedirectToAction("SubirFail");
            }
            return View(f);
        }
        public IActionResult ComentarioFoto()
        {
            return View();
        }
    }
}  
