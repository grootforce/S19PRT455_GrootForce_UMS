using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class UMSContext : IdentityDbContext<ApplicationUser>
    {

        public UMSContext(DbContextOptions<UMSContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Progress> Progress { get; set; }
        public DbSet<Course> Course { get; set; }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        }
    }
