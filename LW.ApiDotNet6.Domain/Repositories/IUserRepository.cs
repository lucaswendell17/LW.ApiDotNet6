
using LW.ApiDotNet6.Domain.Entities;

namespace LW.ApiDotNet6.Domain.Repositories;

public interface IUserRepository
{
    Task<User> GetUserByEmailAndPasswordAsync(string email, string password);
}
