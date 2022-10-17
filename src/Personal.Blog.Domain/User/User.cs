using Personal.Blog.Domain.SeedWork;

namespace Personal.Blog.Domain.User;

public class User : Entity
{
    public int Id { get; }

    private string _firstName;

    private string _lastName;

    private User()
    {
    }

    private User(int id, string firstName, string lastName)
    {
        Id = id;
        _firstName = firstName;
        _lastName = lastName;
    }

    public static User CreateUser(int id, string firstName, string lastName)
    {
        return new User(id, firstName, lastName);
    }
}