using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.Repositories;
using ToDoListAPI.Services;

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
            var toDoListRepository = new PersonRepository();
            _toDoListService = new ToDoListService(toDoListRepository);
            _config = config;
        }


        [HttpGet]
        public IEnumerable<Pizza> GetAll()
        {
            return _pizzasService.GetAll();
        }

        [HttpPost]
        public IActionResult CreateTask(Task task)
        {
            _toDoListService.Create(task);
            return Ok(_toDoListService.GetAll());
        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody] Pizza pizza)
        {
            try
            {
                _pizzasService.Update(id, pizza);
                return Ok(_pizzasService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _pizzasService.Delete(id);
            return Ok(_pizzasService.GetAll());
        }
    }
}
