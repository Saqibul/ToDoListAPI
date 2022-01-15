using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories

{
    public class ToDoListContext : DbContext
    {
        //public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options) { 

        //}
        public virtual DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True", builder => builder.EnableRetryOnFailure()); ;
            }
            
        }

    }
}
