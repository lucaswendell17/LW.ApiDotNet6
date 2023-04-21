
using LW.ApiDotNet6.Domain.Entities;
using LW.ApiDotNet6.Domain.Repositories;
using LW.ApiDotNet6.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LW.ApiDotNet6.Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
    {
        return await _db.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
    }
}
