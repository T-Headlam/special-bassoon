using System;
using Login.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Login.Api.Data
{
	public class DataContext : DbContext 
	{
        private readonly IConfiguration _configuration;

		public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) :base(options)
		{
            _configuration = configuration;
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:localhost;Database=testdb;User Id=sa;Password=bigStrongPwd1;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<User> Users { get; set; }
    }
}

