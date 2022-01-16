using Microsoft.EntityFrameworkCore;

namespace ToDoListAPI.Models
{
    public class ToDoListContext : DbContext
    {
        //public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options) { 

        //}
        public virtual DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<TasksAssigned> TasksAssigned { get; set; }
        public DbSet<TasksToDo> TasksToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True", builder => builder.EnableRetryOnFailure()); ;
            }

        }

    }
}
