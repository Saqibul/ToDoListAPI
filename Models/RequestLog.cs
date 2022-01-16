namespace ToDoListAPI.Models
{
    public class RequestLog
    {
        public int LogId { get; set; }
        public string RequestType { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
