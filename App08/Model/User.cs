using App08.Service;
using App08.Utils;
using System.ComponentModel.DataAnnotations;

namespace App08.Model;
public class User : BaseEntity
{
    [MaxLength(100)]
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }    
    public bool IsActive { get; set; }

    [UIControl(typeof(ComboBox), typeof(RoleDataProvider))]
    public int RoleId { get; set; }
    //Navigation Property
    [NoUI]
    public Role Role { get; set; }
}


public class RoleDataProvider : IDataProvider
{
    public IEnumerable<object> GetData()
    {
        var service = new RoleService();
        return service.GetAll().Select(u => new ComboBoxItem
        {
            Value = u.Id,
            Display = u.Name
        }).ToList();
    }
}