namespace Personal.Blog.Domain.Post;

public interface IPostRepository
{
    Task AddAsync(Post post);
}