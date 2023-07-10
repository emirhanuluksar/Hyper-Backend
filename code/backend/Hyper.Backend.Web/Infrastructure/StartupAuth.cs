using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI.Infrastructure;

public static class StartupAuth {
    public static void AddStartupAuthentication(this WebApplicationBuilder builder) {
    }
    public static void AddStartupAuthorization(this WebApplicationBuilder builder) {
    }
}
