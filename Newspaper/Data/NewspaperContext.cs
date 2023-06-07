using Microsoft.EntityFrameworkCore;
using Newspaper;
using Newspaper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Data
{
    public class NewspaperContext : DbContext
    {
        public DbSet<Reporter> Reporters { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=password123;Database=Newspaper").UseSnakeCaseNamingConvention();
        }
    }
}
