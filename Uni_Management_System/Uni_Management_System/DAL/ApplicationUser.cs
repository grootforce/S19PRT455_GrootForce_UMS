using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class ApplicationUser : IdentityUser
    {
        public string StudentID { get; set; }
    }
}
