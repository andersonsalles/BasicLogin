using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementations
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string Password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}
