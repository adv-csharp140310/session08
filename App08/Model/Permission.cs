namespace App08.Model;
public class Permission : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }

    public string FormName { get; set; }
    public string ControlName { get; set; }

    //public string Method { get; set; }
    //public string Endpoint { get; set; }

    public ICollection<RolePermission> RolePermissions { get; set; }

}
