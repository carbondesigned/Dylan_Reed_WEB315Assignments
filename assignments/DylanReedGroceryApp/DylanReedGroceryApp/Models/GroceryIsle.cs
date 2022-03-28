using System;
using System.Collections.Generic;

namespace DylanReedGroceryApp.Models
{
    public class GroceryIsle
    {
        public List<FoodItem> FoodItems { get; set; }
        public string IsleName { get; set; }
        public Guid IsleNumber { get; set; }
        public GroceryIsle()
        {
        }
    }
}
