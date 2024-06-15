using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoNLayerApp.Domain.Entity;

namespace DemoNLayerApp.DAL.Context
{
    public class DemoNLayerAppDbContext : DbContext
    {
        public DemoNLayerAppDbContext(DbContextOptions<DemoNLayerAppDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
