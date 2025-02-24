namespace App08.Model;
public class RolePermission 
{
    public int RoleId { get; set; }
    public int PermissionId { get; set; }

    //Navigation Property
    public Role Role { get; set; }
    public Permission Permission { get; set; }

}
