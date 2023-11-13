using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task13_11_efstep.Models;

namespace task13_11_efstep.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-JEKGS1B;database=task_13_11_ef;trusted_connection=true;integrated security=true;encrypt=false;");

        }
        public DbSet<Student> Students { get; set; }
    }
}
