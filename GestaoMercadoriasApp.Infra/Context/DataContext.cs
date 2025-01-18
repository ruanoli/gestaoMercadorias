using GestaoMercadoriasApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Movement> Movments { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
