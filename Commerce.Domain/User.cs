﻿using System;
using Microsoft.AspNetCore.Identity;

namespace Commerce.Domain
{
	public class User  : IdentityUser
	{

		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string UserAvatarId { get; set; }


		public ICollection<UserAddress> Addresses {get; set;}

public UserAvatar UserAvatar { get; set; }

}


    
}

