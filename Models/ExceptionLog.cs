using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class ExceptionLog
    {
        [Key]
        public int ExceptionId { get; set; }
        public string ExceptionDescription { get; set; }

    }
}
