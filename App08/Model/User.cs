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

    public int RoleId { get; set; }
    //Navigation Property
    public Role Role { get; set; }
}
