using Dapper;
using System.Data.SqlClient;
using ToDoListAPI.Models;

namespace ToDoListAPI.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(Person person)
        {
            using (ToDoListContext db = new ToDoListContext())
            {
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        public IList<Person> ShowAllPersons()
        {
            string sql = "SELECT * FROM[ToDoList].[dbo].[Persons]";
            using (var connection = new SqlConnection("Data Source=DESKTOP-07HBP7K;Initial Catalog=ToDoList;Integrated Security=True"))
            {
                return connection.Query<Person>(sql).ToList();
            }

        }

        public void UpdatePerson(Person person)
        {
            using (ToDoListContext db = new ToDoListContext())
            {
                //Console.WriteLine(person);
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }
    }

}
