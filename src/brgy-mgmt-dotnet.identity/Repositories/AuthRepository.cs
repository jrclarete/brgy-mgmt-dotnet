using brgy_mgmt_dotnet.application.Contracts.Auth;
using brgy_mgmt_dotnet.application.DTOs.Auth;
using brgy_mgmt_dotnet.identity.Helper;
using brgy_mgmt_dotnet.identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.ObjectPool;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.identity.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;

        public AuthRepository(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _config = config;
        }

        public async Task<AuthResponseDto?> Login(AuthLoginDto request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
                if (result.Succeeded) 
                {
                    return new AuthResponseDto() { Id = user.Id, UserName = user.UserName, Email = user.Email, Token = await GenerateToken(user) };
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<AuthResponseDto?> Register(AuthRegisterDto request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.UserName);
            var existingEmail = await _userManager.FindByEmailAsync(request.Email);

            if (existingUser == null)
            {
                if (existingEmail == null)
                {
                    var user = new AppUser
                    {
                        Email = request.Email,
                        UserName = request.UserName,
                        EmailConfirmed = true
                    };

                    var result = await _userManager.CreateAsync(user, request.Password);

                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Administrator");
                        return new AuthResponseDto() { Id = user.Id, UserName = user.UserName, Email = user.Email, Token = await GenerateToken(user) };
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private async Task<string> GenerateToken(AppUser appUser)
        {
            /*var userClaims = await _userManager.GetClaimsAsync(appUser);
            var roles = await _userManager.GetRolesAsync(appUser);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, roles[i]));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, appUser.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, appUser.Email),
            }
            .Union(userClaims)
            .Union(roleClaims);*/

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, appUser.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, appUser.Email),
            };

            //claims.AddRange(await _userManager.GetClaimsAsync(appUser));
            claims.AddRange(GetClaimsSeperated(await _userManager.GetClaimsAsync(appUser)));
            var roles = await _userManager.GetRolesAsync(appUser);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));

                var identityRole = await _roleManager.FindByNameAsync(role);
                //claims.AddRange(await _roleManager.GetClaimsAsync(identityRole));
                claims.AddRange(GetClaimsSeperated(await _roleManager.GetClaimsAsync(identityRole)));
            }

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_config["JWT:DurationInMinutes"])),
                SigningCredentials = signingCredentials,
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private List<Claim> GetClaimsSeperated(IList<Claim> claims)
        {
            var result = new List<Claim>();
            foreach (var claim in claims)
            {
                result.AddRange(claim.DeserializePermissions().Select(t => new Claim(claim.Type, t.ToString())));
            }
            return result;
        }
    }
}
