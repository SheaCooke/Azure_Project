using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
