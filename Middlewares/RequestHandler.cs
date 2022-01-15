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
            context.Items["customMessage"] = "Hello from middlewar 1";
            Console.WriteLine("Handling request");
            await _next.Invoke(context);
        }
    }
}

