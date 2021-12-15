﻿using InventoryWebApp.Data;
using InventoryWebApp.Models;
using InventoryWebApp.ViewModel;
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

        public IActionResult Add()
        {
            InventoryItemsViewModel vm = new InventoryItemsViewModel();

            return View(vm);
        }


        [HttpPost]
        public IActionResult AddPost(InventoryItemsViewModel vm)
        {
            if (ModelState.IsValid)
            {
                InventoryItem item = new InventoryItem
                {
                    Name = vm.Name,
                    Description = vm.Description,
                    Quantity = vm.Quantity,
                    PricePerItem = vm.PricePerItem
                };

                _context.Add(item);
                _context.SaveChanges();

                return Redirect("Add");
            }

            return View("Add", vm); 
        }


        
        public IActionResult Remove(int Id)
        {
            _context.InventoryItems.Remove(_context.InventoryItems.Find(Id));

            _context.SaveChanges();

            return Redirect("/Inventory/Index");
        }

    }
}
