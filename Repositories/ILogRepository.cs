using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public interface IToDoListRepository
    {
        IList<Person> GetAll();
        Person? Get(int id);
        void Create(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}
