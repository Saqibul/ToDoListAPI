using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(Person person)
        {
            //using (ToDoListContext db = new ToDoListContext())
            //{
            //    Console.WriteLine(person);
            //    db.Persons.Add(person);
            //    db.SaveChanges();
            //}
        }

        public IList<Person> ShowAllPersons()
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }

}
