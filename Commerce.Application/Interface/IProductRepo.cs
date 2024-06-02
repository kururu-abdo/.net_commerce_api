using System;
using Commerce.Domain;

namespace Commerce.Application.Interface
{
	public interface IProductRepo
	{
		IEnumerable<Product> GetAllAsync();

	}
}

