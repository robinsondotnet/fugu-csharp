using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Fugu.Models
{
    public class FuguDBContext : DbContext
    {
        public FuguDBContext(DbContextOptions options) 
            : base(options)
        { }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
