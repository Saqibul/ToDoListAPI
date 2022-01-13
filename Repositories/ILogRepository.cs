using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public interface ILogRepository
    {
        IList<Person> GetAll();
        Person? Get(int id);
        void Create(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}
