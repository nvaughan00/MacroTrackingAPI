using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMacroTracking.Models
{
    public class Item
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbs { get; set; }
        public decimal Fat { get; set; }
        public string FoodType { get; set; }
    }
}
