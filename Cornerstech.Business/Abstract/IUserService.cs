using Cornerstech.EntityLayer.Entities;
using System.Security.Claims;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        bool CheckPasswordByName(string username, string password);
        User GetByName(string username);
        string GetUserRole(string username);
        int? GetUserId(ClaimsPrincipal user);
        int? GetUserIdByPartnerId(int partnerId);

    }
}
