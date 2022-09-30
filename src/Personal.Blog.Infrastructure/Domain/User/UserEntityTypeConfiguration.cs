using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Infrastructure.Database;

namespace Personal.Blog.Infrastructure.Domain.User;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<Blog.Domain.User.User>
{
    public void Configure(EntityTypeBuilder<Blog.Domain.User.User> builder)
    {
        builder.ToTable("Users", BlogContext.DefaultSchema);
        builder.HasKey(u => u.Id);
        builder.Property(u => u.FirstName)
            .HasColumnName("FirstName");
        builder.Property(u => u.LastName)
            .HasColumnName("LastName");
    }
}