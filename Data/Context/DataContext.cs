using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

namespace Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<MainInfo> MainInfos => Set<MainInfo>();
        public DbSet<User> User => Set<User>();
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
       
        
        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=quotes.db");
        }

    }
}
