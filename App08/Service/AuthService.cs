using App08.Model;
using App08.Repositoy;

namespace App08.Service;
public class AuthService
{
    GenericRepository repository = new GenericRepository();

    public (bool, string) Login(string username, string password)
    {
        var user = repository.Get<User>().FirstOrDefault(x => x.Username == username);
        if (user == null)
        {
            return (false, "user not found");
        }
        if(!BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return (false, "password is incorrect");
        }

        return (true, "");
        //return token - jwt
    }
}
