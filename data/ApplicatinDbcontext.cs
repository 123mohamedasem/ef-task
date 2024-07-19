using Microsoft.EntityFrameworkCore;
using studentsystem3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem3.data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<student> studnts { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<resources> resourcess { get; set; }
        public DbSet<homework> homeworks { get; set; }
        public DbSet<studentcorse> studentcourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=studentDB;Integrated Security=True;TrustServerCertificate=True");
        }


    }
}
