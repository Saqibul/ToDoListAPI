using System;
using ToDoListAPI.Models;
using Task = System.Threading.Tasks.Task;

namespace ToDoListAPI.Middlewares
{
    public class RequestHandler
    {
        private readonly RequestDelegate _next;
        public RequestHandler(RequestDelegate next) { 
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            RequestLog requestLog = new RequestLog();
            Console.WriteLine(context.Request.Method);
            Console.WriteLine("Handling request at" + DateTime.Now.ToString("hh:mm:ss"));
            await _next.Invoke(context);
            Console.WriteLine("After the request was handled at " +  DateTime.Now.ToString("hh:mm:ss"));
        }
    }
}

