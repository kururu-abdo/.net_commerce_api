using System;
using Commerce.Infrastucture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Commerce.Infrastucture
{
	public  static class DependencyInjection
	{
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,

             IConfiguration configuration

            )
        {
            services.AddDbContext<CommerceDbContext>(
                options =>

                options.  UseMySql(

configuration.GetConnectionString("MySql")


                    

                    ,


                    ServerVersion.AutoDetect(configuration.GetConnectionString("MySql")))
            //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                );


           
            return services;
        }

    }
}

