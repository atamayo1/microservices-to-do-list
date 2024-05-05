// TaskController.cs
[ApiController]
[Route("api/tasks")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet("{taskId}")]
    public async Task<IActionResult> GetTaskById(string taskId)
    {
        // Lógica para obtener una tarea por su ID
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetTasksByUserId(string userId)
    {
        // Lógica para obtener las tareas de un usuario
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask(TaskModel model)
    {
        // Lógica para crear una nueva tarea
    }

    [HttpPut("{taskId}")]
    public async Task<IActionResult> UpdateTask(string taskId, TaskModel model)
    {
        // Lógica para actualizar una tarea existente
    }

    [HttpDelete("{taskId}")]
    public async Task<IActionResult> DeleteTask(string taskId)
    {
        // Lógica para eliminar una tarea
    }
}
