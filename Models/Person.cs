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

    }
}
