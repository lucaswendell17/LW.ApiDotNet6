

using LW.ApiDotNet6.Domain.Entities;

namespace LW.ApiDotNet6.Domain.Authentication;

public interface ITokenGenerator
{
    dynamic Generator(User user);
}
