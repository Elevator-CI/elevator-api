﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories.Database.Models;

namespace Repositories.Database
{
    public sealed class DatabaseContext : DbContext
    {
        private readonly string connectionString;

        public DatabaseContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Postgres");
        }

        public DatabaseContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<BuildConfig> BuildConfigs { get; set; }
        public DbSet<BuildStep> BuildSteps { get; set; }
        public DbSet<Build> Builds { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
