using System;
using Commerce.Domain;

namespace Commerce.Application.Repository
{
	public interface IAuthRepo
	{

        Task<User?> Login(LoginModel model);

        Task<bool> CheckPasswordAsync(User user, string password);

        Task<User?> Register(LoginModel model);


        Task<User?> IsUserAvailable(string userName);

        Task<string?> GetUserRole(string userName);


    }
}

