using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(Task task)
        {
            throw new NotImplementedException();
        }

        public IList<Task> ShowAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task ShowTaskDetails(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<Task> ShowTasksAssigned(Person person)
        {
            throw new NotImplementedException();
        }

        public IList<Task> ShowTasksToDo(Person person)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
