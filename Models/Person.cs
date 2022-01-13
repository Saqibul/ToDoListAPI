namespace ToDoListAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        public IList<Task>? TasksToDo { get; set; }
        public IList<Task>? TasksGivenOut { get; set; }
    }
}
