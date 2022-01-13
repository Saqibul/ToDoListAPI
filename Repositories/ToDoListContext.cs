using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repositories

{
    public class ToDoListContext : DbContext
    {
        public DbSet<Person>? Persons { get; set; }
        public DbSet<Task>? Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
        }

    }
}
