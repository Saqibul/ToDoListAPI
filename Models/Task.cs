using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }
        public int assignedTo { get; set; }
        public int assignedBy { get; set; }

    }
}
