using AutoMapper;
using Microsoft.Extensions.Configuration;
using SampleKO.Business.Abstract;
using SampleKO.DataAccess.Entities;
using SampleKO.Model;
using SampleKO.Model.Dtos;
using SampleKO.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleKO.Business.Concrete
{
    public class AccessManager : IAccessService
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly IGenericRepository<Customer> _customerRepo;
        public AccessManager(IUnitOfWorks unitOfWorks, IMapper mapper, IConfiguration config)
        {
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
            _config = config;
            _customerRepo = _unitOfWorks.GetGenericRepository<Customer>();
        }
        public ServiceResult Login(LoginUserViewModel loginUserView)
        {
            var user = _customerRepo.GetAll(x => x.Email == loginUserView.EMail && x.Password == loginUserView.Password && !x.IsDelete).Include(x=>x.Role).FirstOrDefault();
            if (user != null)
            {
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Name),
                };

                TokenHanddler handler = new TokenHanddler(_config);
                Token token = handler.CreateAccessToken(loginUserView, authClaims);
                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenExpiryDate = token.Expiration.AddMinutes(20);
                token.Role = user.Role.RoleName;
                _customerRepo.Update(user);
                _unitOfWorks.SaveChanges();
                return Result.Success("İşlem başarılı", token);

            }
            return Result.Fail("Kullanıcı bulunamadı.");
        }
    }
}
