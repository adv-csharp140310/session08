using App08.Model;
using App08.Repositoy;
using Microsoft.EntityFrameworkCore;

namespace App08.Service;
public class PermissionService
{
    GenericRepository repository;
    public PermissionService()
    {
        repository = new GenericRepository();
    }

    public void AddPermission(int roleId, List<string> checkedButtons)
    {
        var permissions = repository.Get<Permission>().AsNoTracking().ToList();
        repository.Get<RolePermission>()
            .Where(x => x.RoleId == roleId)
            .ExecuteDelete();


        foreach (var checkedButton in checkedButtons)
        {
            var parts = checkedButton.Split('|');
            var formName = parts[0];
            var btnName = parts[1];
            var btnText = parts[2];

            var permission = permissions.FirstOrDefault(x =>
                x.FormName == formName &&
                x.Name == btnName
            );
            if (permission == null) {
                permission = new Permission {  
                    FormName = formName, 
                    Name = btnName,
                    ControlName = btnName,
                    Title = btnText,

                };
                repository.Add(permission);
                repository.Add(new RolePermission
                {
                    RoleId = roleId,
                    Permission = permission
                });
            }
            else
            {
                repository.Add(new RolePermission
                {
                    RoleId = roleId,
                    PermissionId = permission.Id
                });
            }

            
        }
    }


    public List<string> GetRolePermissions(int roleId)
    {
        var result = new List<string>();
        var rolePermissions  = repository.Get<RolePermission>()
            .Include(x => x.Permission)
            .Where(x => x.RoleId == roleId)
            .AsNoTracking()
            .ToList();
            ;
        foreach (var rolePermission in rolePermissions)
        {
            var p = rolePermission.Permission;
            var key = $"{p.FormName}|{p.Name}|{p.Title}";
            result.Add(key);
        }
        return result;
    }
}
