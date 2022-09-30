using Personal.Blog.Domain.SeedWork;

namespace Personal.Blog.Domain.User;

public class User : Entity
{
    public int Id { get; }
    
    public string FirstName { get; }
    
    public string LastName { get; }

    public User()
    {
        // EF Core requirement
    }

    public User(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}