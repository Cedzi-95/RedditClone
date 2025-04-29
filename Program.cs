
using Microsoft.EntityFrameworkCore;

namespace Mini_redditProject;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
            "Host=localhost;Port=5432;Database=mini_reddit;Username=postgres;Password=password"
        ));


      var app = builder.Build();

        app.Run();
    }
}
/*

PostController
CommentController

PostService
CommentService

PostRepository
CommentRepository

DbContext

*/