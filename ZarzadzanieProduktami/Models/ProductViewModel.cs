using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZarzadzanieProduktami.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public List<SelectListItem> CategoryList { get; set; }

        public string SelectedCategory { get; set; }

        public decimal? Price { get; set; }
    }
}
