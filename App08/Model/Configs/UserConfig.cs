using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App08.Model.Configs;
internal class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x=>x.Username)            
            .IsRequired();

        builder.HasIndex(x => x.Username).IsUnique();
    }
}
