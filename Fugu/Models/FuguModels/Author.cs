using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fugu.Models.FuguModels
{
    public class Author
    {
        public int AuthorId { get; set; }
        
        [Required]
        public List<Cookbook> Cookbooks { get; set; }
    }
}
