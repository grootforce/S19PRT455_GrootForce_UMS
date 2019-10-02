using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class UMSContext : IdentityDbContext
    {

        public UMSContext(DbContextOptions<UMSContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Progress> Progress { get; set; }

    }
}
