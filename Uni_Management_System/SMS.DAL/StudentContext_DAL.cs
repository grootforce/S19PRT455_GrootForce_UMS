using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.DAL
{
    public class StudentContext_DAL : DbContext
    {

        public StudentContext_DAL(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Tests> Test { get; set; }

    }
}
