using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ETradeContext:DbContext // entity framework için bir context oluşturduk.
    {
        public DbSet<Product> Products { get; set; } // Product nesnesi için dedik.
    }
}
