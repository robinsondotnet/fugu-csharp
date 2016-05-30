using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fugu.Models.FuguModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Fugu.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual Author Author { get; set; }
    }
}
