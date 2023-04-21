

using LW.ApiDotNet6.Application.DTOs;

namespace LW.ApiDotNet6.Application.Services.Interfaces;

public interface IUserService
{
    Task<ResultService<dynamic>> GenerateTokenAsync(UserDTO userDTO);
}
