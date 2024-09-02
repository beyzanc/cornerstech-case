using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        bool CheckPasswordByName(string username, string password);
        User GetByName(string username);
        string GetUserRole(string username); 

    }
}
