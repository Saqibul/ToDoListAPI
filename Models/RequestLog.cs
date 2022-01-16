using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class RequestLog
    {
        [Key]
        public int LogId { get; set; }
        public string RequestType { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
