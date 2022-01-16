using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public interface ILogRepository
    {
        void Add(RequestLog lg);
    }
}
