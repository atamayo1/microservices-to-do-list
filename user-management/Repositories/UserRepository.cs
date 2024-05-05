// UserRepository.cs
public interface IUserRepository
{
    Task<User> GetUserById(string userId);
    Task<User> GetUserByUsername(string username);
    Task<User> CreateUser(User user);
}

public class UserRepository : IUserRepository
{
    private readonly DbContext _dbContext;

    public UserRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Implementa métodos para acceder a los datos de usuario
}
