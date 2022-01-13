using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public interface IPersonRepository
    {
        void Add(Person person);
        IList<Person> ShowAllPersons();
        void UpdatePerson(Person person);
    }
}
