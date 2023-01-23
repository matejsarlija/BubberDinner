using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        throw new NotImplementedException();
    }
}