using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryWebApp.Models;

namespace InventoryWebApp.ViewModel
{
    public class InventoryItemsViewModel
    {
            public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public double PricePerItem { get; set; }


        public InventoryItemsViewModel() { }
         
        
    }
}
