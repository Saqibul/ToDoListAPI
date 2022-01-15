using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }

        
        public virtual string? AssignedTo { get; set; }//Name of the Person
        
        public virtual string? AssignedBy { get; set; }//Name of the Person

    }
}
