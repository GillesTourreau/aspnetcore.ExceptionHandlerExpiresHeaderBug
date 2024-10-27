
namespace ExceptionHandlerExpiresHeaderBug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddProblemDetails();
            builder.Services.AddExceptionHandler<CustomExceptionHandler>();

            var app = builder.Build();

            app.UseExceptionHandler();

            app.MapControllers();

            app.Run();
        }
    }
}
