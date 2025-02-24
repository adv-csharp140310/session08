using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App08.Model.Configs;
internal class RoleConfig : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        var d = new DateTime(2025, 2, 24);
        builder.HasData(
           new Role { Id = 1, Name = "admin", CreatedAt = d, UpdatedAt = d },
           new Role { Id = 2, Name = "user", CreatedAt = d, UpdatedAt = d },
           new Role { Id = 3, Name = "guest", CreatedAt = d, UpdatedAt = d }
       );
    }
}
