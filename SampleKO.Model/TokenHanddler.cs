﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SampleKO.Model.Dtos;
using SampleKO.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.Model
{
    public class TokenHanddler
    {
        private readonly IConfiguration _config;
        public TokenHanddler(IConfiguration config)
        {
            _config = config;
        }
        public Token CreateAccessToken(LoginUserViewModel user, List<Claim> claims)
        {
            var token = new Token();
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:SecurityKey"]));
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            token.Expiration = DateTime.Now.AddMinutes(15);
            JwtSecurityToken securityToken = new JwtSecurityToken(
                issuer: _config["Token:Issuer"],
                audience: _config["Token:Audience"],
                expires: token.Expiration,
                notBefore: DateTime.Now,
                signingCredentials: signingCredentials,
                claims: claims
           );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            //Token üretiliyor
            token.AccessToken = tokenHandler.WriteToken(securityToken);
            token.RefreshToken = CreatRefreshToken();
            return token;

        }
        public string CreatRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
