using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("TaskDescription")]
        public string? TasksToDo { get; set; }

        [ForeignKey("TaskId")]
        public int TasksAssignedId { get; set; }
    }
}
