using App08.Utils;

namespace App08.Model;
public class BaseEntity
{
    [NoUI]
    public int Id { get; set; }

    //
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
