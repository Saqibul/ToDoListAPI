using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void CreateTask(Task task)
        {
            //using (var db = new ToDoListContext()) {
            //    Console.WriteLine(db.Database.CanConnect());
            //    Console.WriteLine(db.Tasks);
            //    db.Tasks.Add(task);
                
            //    var query = from b in db.Tasks select b;

            //    foreach (var item in query) { 
            //        Console.WriteLine(item);
            //    }

            //    db.SaveChanges();

                
            //}
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
