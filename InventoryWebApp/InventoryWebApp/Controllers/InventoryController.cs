using InventoryWebApp.Data;
using InventoryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApp.Controllers
{
    public class InventoryController : Controller
    {
        private InventoryDbContext _context;

        public InventoryController(InventoryDbContext dbContext)
        {
            this._context = dbContext;
        }

        public IActionResult Index()
        {
            List<InventoryItem> items = _context.InventoryItems.ToList();
            return View(items);
        }

    }
}
