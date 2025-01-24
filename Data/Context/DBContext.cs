using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }

        private readonly string computerName = Environment.MachineName;
        private readonly string databaseName = "DatabaseName";

        public DBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={computerName}; Database={databaseName}; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
