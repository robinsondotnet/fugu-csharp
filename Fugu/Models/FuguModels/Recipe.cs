using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fugu.Models.FuguModels
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        public string Description { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public int CookbookId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Inserted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }
    }
}
