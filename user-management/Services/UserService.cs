// UserService.cs
public interface IUserService
{
    Task<User> GetUserById(string userId);
    Task<User> GetUserByUsername(string username);
    Task<User> CreateUser(User user);
}

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // Implementa métodos para la gestión de usuarios
}
