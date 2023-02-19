using LambdaSample.Core.Models;

namespace LambdaSample.Core.Services
{
    public interface IUserService
    {
        List<User> GetAll();

        User AddUser(string name);

        User GetUser(Guid id);
    }
}
