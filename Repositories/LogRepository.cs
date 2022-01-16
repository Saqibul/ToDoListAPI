using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly ExceptionLogRepository _exceptionLogRepository = new ExceptionLogRepository();
        public void Add(RequestLog lg)
        {
            try
            {
                using (var db = new ToDoListContext())
                {
                    db.RequestLogs.Add(lg);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var ext = new ExceptionLog
                {
                    ExceptionDescription = ex.Message
                };
                _exceptionLogRepository.Add(ext);
            }
        }
    }
}
