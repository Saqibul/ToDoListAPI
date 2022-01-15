using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }  

        //[ForeignKey("Person")]
        //public int PersonId { get; set; }
        public virtual Person? AssignedBy { get; set; }
        public virtual Person? AssignedTo { get; set; }
    }
}
