using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZarzadzanieProduktami.Models
{
    public class ZarzadzanieProduktamiContext : DbContext
    {
        public ZarzadzanieProduktamiContext (DbContextOptions<ZarzadzanieProduktamiContext> options)
            : base(options)
        {
        }

        public DbSet<ZarzadzanieProduktami.Models.Product> Product { get; set; }
        public DbSet<ZarzadzanieProduktami.Models.Category> Categories { get; set; }
    }
}
