using System.Data;

namespace Personal.Blog.Application.Configuration.Data;

public interface ISqlConnectionFactory 
{
    IDbConnection GetOpenConnection();
}