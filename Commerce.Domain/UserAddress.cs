using System;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Domain
{
	public class UserAddress
	{
		[Key]
		public int Id { get; set; }

		public double Lat { get; set; }
        public double Lng { get; set; }

        public string Address { get; set; }

		public int UserId { get; set; }



		public User user { get; set; }
    }

}

