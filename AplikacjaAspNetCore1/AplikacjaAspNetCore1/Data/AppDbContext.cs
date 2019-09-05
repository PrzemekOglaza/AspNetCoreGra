using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplikacjaAspNetCore1.Model;

namespace AplikacjaAspNetCore1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AplikacjaAspNetCore1.Model.Game> Game { get; set; }
    }
}
