using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories
{
    public interface ITaskRepository
    {
        void CreateTask(Task task);
        void UpdateTask(Task task);
        IList<Task> ShowTasksToDo(int id);
        IList<Task> ShowTasksAssigned(int id);
        void DeleteTask(int id);
        Task ShowTaskDetails(string keyword);
        IList<Task> ShowAllTasks();
    }
}
