using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fugu.Models.FuguModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Fugu.Models
{
    public class FuguContext : DbContext
    {
        public FuguContext(DbContextOptions options) 
            : base(options)
        { }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Cookbook> Cookbooks { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
