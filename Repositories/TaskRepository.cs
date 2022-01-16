using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void CreateTask(Task task)
        {
            using (var db = new ToDoListContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
        }

        public void DeleteTask(int id)
        {
            using (var db = new ToDoListContext()) {
                var task = new Task { TaskId = id };
                db.Entry(task).State = EntityState.Deleted;
                db.SaveChanges();

            }
        }

        public IList<Task> ShowAllTasks()
        {
            string sql = "SELECT * FROM[ToDoList].[dbo].[Tasks]";
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Task>(sql).ToList();
            }
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
