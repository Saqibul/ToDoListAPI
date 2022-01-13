using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.Models;
using ToDoListAPI.Repositories;
using ToDoListAPI.Services;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoListController: ControllerBase
    {
        private readonly ToDoListService _toDoListService;
        private readonly IConfiguration _config;

        public ToDoListController(IConfiguration config)
        {
            var personRepository = new PersonRepository();
            var taskRepository = new TaskRepository();
            var logRepository = new LogRepository();

            _toDoListService = new ToDoListService(personRepository,taskRepository,logRepository);
            _config = config;
            Console.WriteLine("In the controller file");
        }


        //[HttpGet("persons")]
        //public IEnumerable<Person>? GetAllPersons()
        //{
        //    return _toDoListService.GetAllPersons();
        //}

        //[HttpGet(Name = "GetTasks")]
        //public IEnumerable<Task>? GetAllTasks()
        //{
        //    return _toDoListService.GetAllTasks();
        //}

        [HttpPost("createPersons")]
        public IActionResult CreatePerson(Person person)
        {
            _toDoListService.AddPerson(person);
            return Ok(_toDoListService.GetAllPersons());
        }
        
        //[HttpPost("createTasks")]
        //public IActionResult CreateTask(Task task)
        //{
        //    _toDoListService.Create(task);
        //    return Ok(_toDoListService.GetAll());
        //}

        //[HttpPut]
        //public IActionResult Update(int id, [FromBody] Pizza pizza)
        //{
        //    try
        //    {
        //        _pizzasService.Update(id, pizza);
        //        return Ok(_pizzasService.GetAll());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}


        //[HttpDelete]
        //public IActionResult Delete(int id)
        //{
        //    _pizzasService.Delete(id);
        //    return Ok(_pizzasService.GetAll());
        //}
    }
}
