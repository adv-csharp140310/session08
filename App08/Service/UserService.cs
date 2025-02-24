using App08.Model;
using App08.Repositoy;

namespace App08.Service;
public  class UserService
{
    GenericRepository repository;

    public UserService()
    {
        repository = new GenericRepository();
    }

    public void Add(User model)
    {
        //Validation
        if (string.IsNullOrWhiteSpace(model.Password) || model.Password.Length < 6)
        {
           //throw new ArgumentException("");
        }

        //Business Logic

        //Database
        model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

        repository.Add(model);                
        //var b = new Blog();
        //repository.Add(b);

    }

    //1- List<User>
    //2- Iqueryable<User>
    public (List<User>, int) LoadData(bool? isActive, string namTerm, int page, int pageSize)
    {
        var query = repository.Get<User>();
        if (isActive.HasValue)
        {
            query = query.Where(x => x.IsActive == isActive);
        }
        if (!string.IsNullOrWhiteSpace(namTerm))
        {
            query = query
                .Where(x => x.FirstName.Contains(namTerm) || x.LastName.Contains(namTerm));
        }

        var result = query
            .Skip(pageSize * page)
            .Take(pageSize).ToList();

        var total = query.Count();

        return (result, total);
    }
}
