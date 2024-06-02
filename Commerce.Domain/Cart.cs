using System;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Domain
{
	public class Cart
	{

		[Key]
		public int Id { get; set; }

		public DateTime Created { get; set; }

		public int UserId { get; set; }




		public User User { get; set; }
	}
}

