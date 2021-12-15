using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApp.Models
{
    public class InventoryItem
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public double PricePerItem { get; set; }


        public InventoryItem(string name, string description, int quantity, double pricePerItem)
            {
                this.Name = name;
                this.Description = description;
                this.Quantity = quantity;
                this.PricePerItem = pricePerItem;
            }



        
    }
}
