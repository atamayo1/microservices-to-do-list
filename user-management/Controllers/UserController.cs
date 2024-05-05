// UserController.cs
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetUserById(string userId)
    {
        // Lógica para obtener un usuario por su ID
    }

    [HttpGet("username/{username}")]
    public async Task<IActionResult> GetUserByUsername(string username)
    {
        // Lógica para obtener un usuario por su nombre de usuario
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(UserModel model)
    {
        // Lógica para crear un nuevo usuario
    }
}
