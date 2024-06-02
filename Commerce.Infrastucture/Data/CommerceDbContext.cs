using System;
using Commerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Infrastucture.Data
{
	public class CommerceDbContext:DbContext
	{



		public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }


        public CommerceDbContext(DbContextOptions<CommerceDbContext> options):base(options)
		{
		}
	}
}

