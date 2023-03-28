using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Data.Entites;

namespace WebApi.Bussiness.Services
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);

        Task<User> GetUserInfor(Guid id);

    }
}
