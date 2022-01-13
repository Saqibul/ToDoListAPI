namespace ToDoListAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }  


        public Person? AssignedBy { get; set; }
        public Person? AssignedTo { get; set; }
    }
}
