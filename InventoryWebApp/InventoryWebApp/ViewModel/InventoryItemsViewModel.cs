using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApp.ViewModel
{
    public class InventoryItemsViewModel
    {
        public class InventoryItemViewModel
        {
            [Required(ErrorMessage = "This property is required")]
            public string Name { get; set; }

            [Required(ErrorMessage = "This property is required")]
            public string Description { get; set; }

            [Required(ErrorMessage = "This property is required")]
            public int Quantity { get; set; }

            [Required(ErrorMessage = "This property is required")]
            public double PricePerItem { get; set; }
        }
    }
}
