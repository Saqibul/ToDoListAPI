using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ExceptionLogRepository _exceptionLogRepository = new ExceptionLogRepository();
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
                var ext = new ExceptionLog
                {
                    ExceptionDescription = ex.Message
                };
                _exceptionLogRepository.Add(ext);
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

        public IList<Task> ShowTaskDetails(string keyword)
        {
            string sql = "SELECT [ToDoList].[dbo].[Tasks].TaskDescription FROM [ToDoList].[dbo].[Tasks] WHERE [ToDoList].[dbo].[Tasks].TaskDescription LIKE '%" + keyword +"%'";
            Console.Write(sql);
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Task>(sql).ToList();
            }
        }

        public IList<Task> ShowTasksAssigned(int PersonId)
        {
            string sql = "SELECT DISTINCT [ToDoList].[dbo].[Tasks].TaskDescription,[ToDoList].[dbo].[Tasks].TaskId  FROM [ToDoList].[dbo].[Tasks] INNER JOIN [TasksToDos] ON [ToDoList].[dbo].[Tasks].[assignedBy] = " + PersonId;
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Task>(sql).ToList();
            }
        }

        public IList<Task> ShowTasksToDo(int PersonId)
        {
            string sql = "SELECT DISTINCT [ToDoList].[dbo].[Tasks].TaskDescription,[ToDoList].[dbo].[Tasks].TaskId  FROM [ToDoList].[dbo].[Tasks] INNER JOIN [TasksToDos] ON [ToDoList].[dbo].[Tasks].[assignedTo] = " + PersonId;
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Task>(sql).ToList();
            }
        }

        public void UpdateTask(Task task)
        {
            try
            {
                using (var db = new ToDoListContext())
                {
                    var oldTask = db.Tasks.Where(d => d.TaskId == task.TaskId).FirstOrDefault();
                    oldTask.TaskDescription = task.TaskDescription;
                    oldTask.assignedTo = task.assignedTo;
                    oldTask.assignedBy = task.assignedBy;
                    db.SaveChanges();
                    var oldTaskToDo = db.TasksToDos.Where(d => d.TaskId == task.TaskId).FirstOrDefault();
                    oldTaskToDo.PersonId = task.assignedTo;
                    db.SaveChanges();
                    var oldTaskAssigned = db.TasksAssigned.Where(d => d.TaskId == task.TaskId).FirstOrDefault(); 
                    oldTaskAssigned.PersonId = task.assignedBy;
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { 
            
            }
            
        }
    }
}
