using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public class LogRepository : ILogRepository
    {
        public void Add(RequestLog lg)
        {
            using (var db = new ToDoListContext()) { 
                db.RequestLogs.Add(lg);
                db.SaveChanges();
            }
        }
    }
}
