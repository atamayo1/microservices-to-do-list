// TaskService.cs
public interface ITaskService
{
    Task<Task> GetTaskById(string taskId);
    Task<IEnumerable<Task>> GetTasksByUserId(string userId);
    Task<Task> CreateTask(Task task);
    Task<Task> UpdateTask(Task task);
    Task DeleteTask(string taskId);
}

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    // Implementa métodos para la gestión de tareas
}
