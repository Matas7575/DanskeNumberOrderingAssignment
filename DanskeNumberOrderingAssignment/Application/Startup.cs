using DanskeNumberOrderingAssignment.Application.EndPoints;
using DanskeNumberOrderingAssignment.Services;

namespace DanskeNumberOrderingAssignment.Application;
/// <summary>
/// A class that initializes the application.
/// </summary>
public static class Startup
{
    public static WebApplication InitializeApp(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services
        builder.Services.AddOpenApi();  // OpenAPI
        builder.Services.AddSingleton<ISortingService, SortingService>(); // DI for SortingService
        builder.Services.AddSingleton<IFileService, FileService>(); // DI for FileService

        var app = builder.Build();

        // Configure middlewares
        if (app.Environment.IsDevelopment())
            app.MapOpenApi();

        app.UseHttpsRedirection();

        // Map endpoints
        SortingEndpoints.MapEndpoints(app);
        FileEndpoints.MapEndpoints(app);

        return app;
    }
}
