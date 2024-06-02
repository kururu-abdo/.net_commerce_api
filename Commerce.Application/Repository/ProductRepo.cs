using System;
using System.Diagnostics;
using System.Xml.Linq;
using Commerce.Application.Interface;
using Commerce.Domain;

namespace Commerce.Application.Repository
{
	public class ProductRepo: IProductRepo
	{
		public ProductRepo()
		{
		}

        public IEnumerable<Product> GetAllAsync()
        {
            IEnumerable<Product> product =
                Enumerable.Empty<Product>();
            Product[] products = new Product[]
            {
                new Product {


                Id = 1,
                Name = "Product 1" ,
                Description = "Nice Product" ,

                Price = 5.7M,
                Photo = ""


            },
 new Product
               {


                   Id = 2,
                   Name = "Product 2",
                   Description = "Good Product",

                   Price = 10.8M,
                   Photo = ""


               },
 new Product
               {


                   Id = 3,
                   Name = "Product 3",
                   Description = "Excellant Product",

                   Price = 7.7M,
                   Photo = ""


               },
  new Product
               {


                   Id = 4,
                   Name = "Product 4",
                   Description = "Nice Product",

                   Price = 6.7M,
                   Photo = ""


               }

            };

            
           
        
           
            return products.ToArray();
        }
    }
}

