using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Infrastructure.Configuration.DataAccess;

namespace Personal.Blog.Infrastructure.Domain.User;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<Blog.Domain.User.User>
{
    public void Configure(EntityTypeBuilder<Blog.Domain.User.User> builder)
    {
        builder.ToTable("Users", BlogContext.DefaultSchema);
        builder.HasKey(u => u.Id);
        builder.Property<string>("_firstName").HasColumnName("FirstName");
        builder.Property<string>("_lastName").HasColumnName("LastName");
    }
}