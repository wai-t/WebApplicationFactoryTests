using Server.Services;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        // Needed for Swagger UI
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Here we register the MyService class and specify that HttpClient will have a base address initialized to "https://bbc.co.uk/"
        builder.Services.AddHttpClient<IMyServiceInterface, MyService>(client =>
        {
            client.BaseAddress = new Uri("https://bbc.co.uk/");
        });

        WebApplication app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();

    }

}

