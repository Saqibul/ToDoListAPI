using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public class ExceptionLogRepository : IExceptionLogRepository
    {
        public void Add(ExceptionLog el)
        {
            using (var db = new ToDoListContext()) { 
                db.ExceptionLogs.Add(el);
                db.SaveChanges();
            }
        }
    }
}
