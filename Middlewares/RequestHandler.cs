using System;
using ToDoListAPI.Models;
using ToDoListAPI.Repositories;
using Task = System.Threading.Tasks.Task;

namespace ToDoListAPI.Middlewares
{
    public class RequestHandler
    {
        private readonly RequestDelegate _next;
        private readonly LogRepository _logRepository;
        public RequestHandler(RequestDelegate next) { 
            _next = next;
            _logRepository = new LogRepository();
        }

        public async Task Invoke(HttpContext context)
        {           
            Console.WriteLine(context.Request.Method);
            string requestType = context.Request.Method;
            Console.WriteLine("Handling request at" + DateTime.Now.ToString("hh:mm:ss"));
            DateTime created = DateTime.Now;
            await _next.Invoke(context);
            Console.WriteLine("After the request was handled at " +  DateTime.Now.ToString("hh:mm:ss"));
            DateTime end = DateTime.Now;
            RequestLog requestLog = new RequestLog { 
                RequestType = requestType,
                CreateTime = created,
                EndTime = end,
            };
            _logRepository.Add(requestLog);
        }
    }
}

