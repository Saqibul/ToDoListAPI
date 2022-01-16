using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public interface IExceptionLogRepository
    {
        void Add(ExceptionLog el);
    }
}
