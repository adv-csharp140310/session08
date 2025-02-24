using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App08.Model;
public class Role: BaseEntity
{    
    public string Name { get; set; }

    //Navigation Property
    public ICollection<User> Users { get; set; }
    public ICollection<RolePermission> RolePermissions { get; set; }
}
