using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.Blog.Infrastructure.Configuration.DataAccess;

namespace Personal.Blog.Infrastructure.Domain.Post;

public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Blog.Domain.Post.Post>
{
    public void Configure(EntityTypeBuilder<Blog.Domain.Post.Post> builder)
    {
        builder.ToTable("Posts", BlogContext.DefaultSchema);
        builder.HasKey(p => p.PostId);
        builder.Property<int>("_userId").HasColumnName("UserId");
        builder.Property<string>("_title").HasColumnName("Title");
        builder.Property<string>("_body").HasColumnName("Body");
    }
}