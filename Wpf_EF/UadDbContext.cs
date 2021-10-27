using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_EF
{
    internal class UadDbContext : DbContext
    {
        public DbSet<Fixture> Fixtures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=UadDB.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
