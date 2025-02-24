using App08.Model;
using App08.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App08.Service;
public  class RoleService
{
    GenericRepository repository = new GenericRepository();

    public void Add(Role model)
    {
        repository.Add(model);
    }

    public IQueryable<Role> GetAll()
    {
        return repository.Get<Role>();        
    }

    public (List<Role>, int) LoadData(string namTerm, int page, int pageSize)
    {
        var query = repository.Get<Role>();    
        if (!string.IsNullOrWhiteSpace(namTerm))
        {
            query = query
                .Where(x => x.Name.Contains(namTerm));
        }
        var result = query
            .Skip(pageSize * page)
            .Take(pageSize).ToList();

        var total = query.Count();

        return (result, total);
    }
        
}
