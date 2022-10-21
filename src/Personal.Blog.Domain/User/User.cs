using Personal.Blog.Domain.SeedWork;

namespace Personal.Blog.Domain.User;

public class User : Entity
{
    public int? UserId { get; }

    private string _firstName;

    private string _lastName;

    private User(int? userId, string firstName, string lastName)
    {
        UserId = userId;
        _firstName = firstName;
        _lastName = lastName;
    }

    public static User CreateUser(string firstName, string lastName)
    {
        return new User(null, firstName, lastName);
    }
}