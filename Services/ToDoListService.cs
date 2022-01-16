using ToDoListAPI.Models;
using ToDoListAPI.Repositories;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Services
{
    public class ToDoListService
    {
        private readonly PersonRepository _personRepository;
        private readonly TaskRepository _taskRepository;
        private readonly LogRepository _logRepository;
        public ToDoListService(PersonRepository personRepository, TaskRepository taskRepository, LogRepository logRepository)
        {
            _personRepository = personRepository;
            _taskRepository = taskRepository;   
            _logRepository = logRepository;
        }

        public IList<Task>? GetAllTasks()
        {
            return (IList<Task>)_taskRepository.ShowAllTasks();
        }
        
        public IList<Person> GetAllPersons()
        {
            return (IList<Person>)_personRepository.ShowAllPersons();
        }

        //public IList<Log> GetAllLogs()
        //{
        //    return (IList<Log>)_logRepository.GetAll();
        //}

        public void AssignToSelf() { 
            
        }
        public Task? GetTask(String name)
        {         
            return _taskRepository.ShowTaskDetails(name);
        }
        
        public void UpdateTask(Task task)
        {
            _taskRepository.UpdateTask(task);
        }

        public void CreateTask(Task task)
        {
            _taskRepository.CreateTask(task);
        }

        public IList<Task>? ShowTasksToDo(int id) 
        { 
            return _taskRepository.ShowTasksToDo(id);
        }

        public IList<Task>? ShowTasksAssigned(int id)
        { 
            return _taskRepository.ShowTasksAssigned(id);
        }
        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public void AddPerson(Person person) 
        {
            Console.WriteLine("In the Service File");
            _personRepository.Add(person);
        }
        public void UpdatePerson(Person person) 
        { 
            _personRepository.UpdatePerson(person);
        }
    }
}
