using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Controllers
{
    public class BookManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Book(string name, int total)
        {
            ViewData["message"] = "Chào " + name;
            ViewData["total"] = total;
            return View();
        }
    }
}
