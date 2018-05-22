using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
            int aldina=12,ball,col,vm;
            ball=aldina*minutos;
            DateTime lol = DateTime.Today;
            TimeSpan p=ProximoCumple-lol;
            
            int fecha=p.Days;
            int mes=p.Days/30;
            col=ball*fecha;
            vm=col/30;

            ViewBag.Dias = fecha;
            ViewBag.Botellas = col;
            ViewBag.Botemes = vm;
            ViewBag.Meses = col;

            return View();
        }

    }
}
