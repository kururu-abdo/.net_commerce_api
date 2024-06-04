using System;
using System.Collections;
using Commerce.Domain;

namespace Commerce.Application.Repository
{
	public interface IUserRepo
	{

        Task<User?> GetUserProfile(int id);
        Task<IList> GetUserRoles(string email);
    }
}

