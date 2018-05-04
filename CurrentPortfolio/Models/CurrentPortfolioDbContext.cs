using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CurrentPortfolio.Models;

namespace CurrentPortfolio.Models
{
    public class UncivilizedDbContext : IdentityDbContext<User>
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<User> Users { get; set; }

        public CurrentPortfolioDbContext(DbContextOptions options) : base(options)
        {
        }

        public CurrentPortfolioDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=currentportfolio;uid=root;pwd=root;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Uncivilized.Models.GameEvent> GameEvent { get; set; }
    }
}
