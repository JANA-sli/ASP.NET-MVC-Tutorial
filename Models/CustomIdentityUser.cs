using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MvcMovie.Models
{
    // Add profile data for application users by adding properties to the CustomIdentityUser class
    public class CustomIdentityUser : IdentityUser
    {
        [PersonalData]
        public string CustomField { get; set; }

        public string SecretField { get; set; }
    }
}
