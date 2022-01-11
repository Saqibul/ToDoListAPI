using ToDoListAPI.Models;
using ToDoListAPI.Repositories;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Services
{
    public class ToDoListService
    {
        private readonly IToDoListRepository _personRepository;
        private readonly IToDoListRepository _taskRepository;
        private readonly IToDoListRepository _logRepository;
        public ToDoListService(IToDoListRepository personRepository, IToDoListRepository taskRepository, IToDoListRepository logRepository)
        {
            _personRepository = personRepository;
            _taskRepository = taskRepository;   
            _logRepository = logRepository;
        }

        public IList<Task> GetAllTasks()
        {
            return (IList<Task>)_taskRepository.GetAll();
        }
        
        public IList<Person> GetAllPersons()
        {
            return (IList<Person>)_personRepository.GetAll();
        }
        
        public IList<Log> GetAllLogs()
        {
            return (IList<Log>)_logRepository.GetAll();
        }


        public Task? GetTask(String name)
        {
            IList<Task> tasks = new List<Task>();

            return _.Get(name);
        }

        public void CreateTask(Task task)
        {
            _taskRepository.Create(task);
        }

        public void Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                throw new ArgumentException("id didn't match with pizza id");
            }
            _pizzaRepository.Update(pizza);
            return;
        }

        public void Delete(int id)
        {
            _pizzaRepository.Delete(id);
        }
    }
}
