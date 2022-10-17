using System.Reflection;
using Personal.Blog.Application.User.GetUserWithPosts;

namespace Personal.Blog.Infrastructure.Configuration.Processing;

internal static class Assemblies
{
    public static readonly Assembly Application = typeof(GetUserWithPostsQuery).GetTypeInfo().Assembly;
}