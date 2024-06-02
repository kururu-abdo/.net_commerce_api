using System;
using Commerce.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Infrastucture.Data
{
	public class CommerceAuthDbContext  : IdentityDbContext<User>
	{
        public CommerceAuthDbContext(DbContextOptions<CommerceAuthDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

