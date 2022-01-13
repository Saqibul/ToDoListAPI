using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories
{
    public interface ITaskRepository
    {
        void CreateTask(Task task);
        void UpdateTask(Task task);
        IList<Task> ShowTasksToDo(Person person);
        IList<Task> ShowTasksAssigned(Person person);
        void DeleteTask(Task task);
        Task ShowTaskDetails(string keyword);
        IList<Task> ShowAllTasks();
    }
}
