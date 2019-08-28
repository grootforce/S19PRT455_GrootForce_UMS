using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class UMSContext : DbContext
    {

        public UMSContext(DbContextOptions<UMSContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set }

    }
}
