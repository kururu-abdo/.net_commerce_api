using System;
namespace Commerce.Domain
{
	public class UserAvatar
	{
		public int Id { get; set; }

		public string imagePath { get; set; }


		public int UserId { get; set; }


	
		public User user { get; set; }
	}
}

