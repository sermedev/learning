namespace webapi.Services
{
    public class TaskService: ITaskService
    {
        TasksContext _context;

        public TaskService(TasksContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Task> Get()
        {
            return _context.Tasks;
        }

        public async Task Save(Models.Task task)
        {
            _context.Add(task);

            await _context.SaveChangesAsync();
        }

        public async Task Update(Guid id, Models.Task task)
        {
            Models.Task currentTask = _context.Tasks.Find(id);

            if (currentTask != null)
            {
                currentTask.Title = task.Title;
                currentTask.Description = task.Description;
                currentTask.Category = task.Category;
                currentTask.Summary = task.Summary;
                currentTask.Priority = task.Priority;

                await _context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task Delete(Guid id, Models.Task task)
        {
            Models.Task currentTask = _context.Tasks.Find(id);

            if (currentTask != null)
            {
                _context.Remove(currentTask);
                await _context.SaveChangesAsync();
            }
        }
    }

    public interface ITaskService
    {
        IEnumerable<Models.Task> Get();
        Task Save(Models.Task category);
        Task Update(Guid id, Models.Task category);
        Task Delete(Guid id, Models.Task category);
    }
}
