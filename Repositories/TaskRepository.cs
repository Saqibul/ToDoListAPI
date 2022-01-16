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
            try
            {
                using (var db = new ToDoListContext())
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    var taskToDo = new TasksToDo {
                        PersonId = task.assignedTo,
                        TaskId = task.TaskId
                    };
                    var taskAssigned = new TasksAssigned
                    {
                        PersonId = task.assignedBy,
                        TaskId = task.TaskId
                    };
                    db.TasksAssigned.Add(taskAssigned);
                    db.SaveChanges();
                    db.TasksToDos.Add(taskToDo);
                    db.SaveChanges();

                    //var result = db.Persons.SingleOrDefault(t => t.TasksAssignedId => );
                }

            }
            catch (Exception ex) { 
                
            }
            
        }

        public void DeleteTask(int id)
        {
            try {
                using (var db = new ToDoListContext()) {
                    var task = new Task { TaskId = id };
                    db.Entry(task).State = EntityState.Deleted;
                    db.SaveChanges();
                } 
            }
            catch(Exception ex) { 
            
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

        public IList<Task> ShowTasksAssigned(int PersonId)
        {
            string sql = "SELECT DISTINCT [ToDoList].[dbo].[Tasks].TaskDescription,[ToDoList].[dbo].[Tasks].TaskId  FROM [ToDoList].[dbo].[Tasks] INNER JOIN [TasksToDos] ON [ToDoList].[dbo].[Tasks].[assignedBy] = " + PersonId;
            Console.WriteLine(sql);
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Task>(sql).ToList();
            }
        }

        public IList<Task> ShowTasksToDo(int PersonId)
        {
            string sql = "SELECT DISTINCT [ToDoList].[dbo].[Tasks].TaskDescription,[ToDoList].[dbo].[Tasks].TaskId  FROM [ToDoList].[dbo].[Tasks] INNER JOIN [TasksToDos] ON [ToDoList].[dbo].[Tasks].[assignedTo] = " + PersonId;
            Console.WriteLine(sql);
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Task>(sql).ToList();
            }
        }

        public void UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
