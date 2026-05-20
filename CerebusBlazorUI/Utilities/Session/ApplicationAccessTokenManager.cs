using CerebusBlazorUI.Classes.User;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CerebusBlazorUI.Utilities.Session
{
    public class ApplicationAccessTokenManager
    {
        private readonly IMemoryCache _cache;

        public ApplicationAccessTokenManager(IMemoryCache cache)
        {
            _cache = cache;
        }

        public UserSession GetToken()
        {
            return _cache.Get<UserSession>("currentsession");
        }

        public void SetToken(UserSession session, TimeSpan expiration)
        {
            // Set the cache entry with an absolute expiration time matching the JWT's expiry
            _cache.Set<UserSession>("currentsession", session, expiration);
        }

        public void RemoveToken()
        {
            _cache.Remove("currentsession");
        }

        //public string GenerateAccessToken(User user, string secret)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(secret);
        //    Dictionary<string, object> claims = new Dictionary<string, object>();
        //    claims.Add("userid", user.ID.ToString());
        //    claims.Add("username", user.Username);
        //    claims.Add("role", user.UserRole.Name);
        //    claims.Add("isadmin", user.UserRole.IsAdmin.ToString());
        //    claims.Add("email", user.EmailAddress);

        //    // TODO: Look through here and add below
        //    // https://learn.microsoft.com/en-us/dotnet/api/microsoft.identitymodel.tokens.securitytokendescriptor?view=msal-web-dotnet-latest

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[] { new Claim("id", user.ID.ToString()) }),
        //        Claims = claims,
        //        IssuedAt = DateTime.UtcNow,
        //        Issuer = "DjinnTek",
        //        Expires = DateTime.UtcNow.AddMinutes(15), // Token expiration time
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}

        //public string GenerateRefreshToken()
        //{
        //    var randomNumber = new byte[32];
        //    using var rng = RandomNumberGenerator.Create();
        //    rng.GetBytes(randomNumber);
        //    return Convert.ToBase64String(randomNumber);
        //}

        //public string GenerateAccessTokenFromRefreshToken(string refreshToken, string secret)
        //{
        //    // Implement logic to generate a new access token from the refresh token
        //    // Verify the refresh token and extract necessary information (e.g., user ID)
        //    // Then generate a new access token

        //    // For demonstration purposes, return a new token with an extended expiry
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(secret);

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Expires = DateTime.UtcNow.AddMinutes(15), // Extend expiration time
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}
    }
}
