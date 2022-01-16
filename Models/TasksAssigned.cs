using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{

    public class TasksAssigned
    {
        public int Id { get; set; }
        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        [ForeignKey("TaskId")]
        public int TaskId { get; set; }
    }
}
