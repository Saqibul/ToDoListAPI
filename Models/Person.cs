using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [NotMapped]
        public virtual IList<Task> TasksToDo { get; set; }
        [NotMapped]
        public virtual IList<Task> TasksGivenOut { get; set; }

    }
}
