// TaskRepository.cs
public interface ITaskRepository
{
    Task<Task> GetTaskById(string taskId);
    Task<IEnumerable<Task>> GetTasksByUserId(string userId);
    Task<Task> CreateTask(Task task);
    Task<Task> UpdateTask(Task task);
    Task DeleteTask(string taskId);
}

public class TaskRepository : ITaskRepository
{
    private readonly DbContext _dbContext;

    public TaskRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Implementa métodos para acceder a los datos de las tareas
}
