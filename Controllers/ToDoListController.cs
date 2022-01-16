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


        [HttpGet("Persons")] // Get all Persons
        public IEnumerable<Person>? GetAllPersons()
        {
            return _toDoListService.GetAllPersons();
        }

        [HttpGet("Tasks")] // Get all Tasks
        public IEnumerable<Task>? GetAllTasks()
        {
            return _toDoListService.GetAllTasks();
        }

        [HttpPost("CreatePerson")] //Create Person
        public IActionResult CreatePerson(Person person)
        {
            _toDoListService.AddPerson(person);
            return Ok(_toDoListService.GetAllPersons());
        }

        [HttpPost("CreateTask")] //Create Task
        public IActionResult CreateTask(Task task)
        {
            _toDoListService.CreateTask(task);
            return Ok(_toDoListService.GetAllTasks());
        }

        [HttpDelete("DeleteTask")] //Delete Task using task id
        public IActionResult DeleteTask(int i)
        {
            _toDoListService.DeleteTask(i);
            return Ok(_toDoListService.GetAllTasks());
        }

        [HttpGet("GetTasksToDo")] //Get tasks to done by providing with a Person ID
        public IEnumerable<Task>? GetTasksToDo(int id) {
            return _toDoListService.ShowTasksToDo(id);
            
        }

        [HttpGet("GetTasksAssigned")] //Get tasks to done by providing with a Person ID
        public IEnumerable<Task>? GetTasksAssigned(int id)
        {
            return _toDoListService.ShowTasksAssigned(id);

        }

        [HttpPatch("UpdateTask")] //Update existing task
        public IActionResult UpdateTask(Task task)
        {
            _toDoListService.UpdateTask(task);
            return Ok(_toDoListService.GetAllTasks());
        }

        [HttpGet("GetTaskDetailsByKeyWord")] //Enter keyword and search task table for description that may contain that word
        public IEnumerable<Task> GetTaskByKeyword(string keyword) {
            return _toDoListService.GetTaskByKeyword(keyword);
        }


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
