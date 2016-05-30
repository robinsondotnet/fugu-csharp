using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fugu.Models.FuguModels
{
    public class Cookbook
    {
        public int CookbookId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Recipe> Recipes { get; set; }


        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
