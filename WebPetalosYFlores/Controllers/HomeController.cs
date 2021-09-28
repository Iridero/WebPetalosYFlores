using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPetalosYFlores.Models;
using WebPetalosYFlores.Repositories;

namespace WebPetalosYFlores.Controllers
{
    
    public class HomeController : Controller
    {
        floresContext context;
        public HomeController()
        {
            context = new();
        }
        public IActionResult Index()
        {
            DatosFloresRepository df = new(context);
            return View(df.GetDatosFlores());
        }

        [ActionName("Flor")]
        public IActionResult DatosFlores(int id)
        {
            DatosFloresRepository df = new(context);
            return View("DatosFlores",df.GetDatosById(id));
        }
    }
}
