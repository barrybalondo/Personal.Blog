using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Infrastructure.Database;

namespace Personal.Blog.Infrastructure.Domain.Post;

public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Blog.Domain.Post.Post>
{
    public void Configure(EntityTypeBuilder<Blog.Domain.Post.Post> builder)
    {
        builder.ToTable("Posts", BlogContext.DefaultSchema);
        builder.HasKey(p => p.Id);
        builder.Property(p => p.UserId)
            .HasColumnName("UserId");
        builder.Property(p => p.Title)
            .HasColumnName("Title");
        builder.Property(u => u.Body)
            .HasColumnName("Body");
    }
}