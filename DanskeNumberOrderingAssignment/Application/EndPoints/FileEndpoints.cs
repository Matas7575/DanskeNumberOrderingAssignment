using DanskeNumberOrderingAssignment.Services;

namespace DanskeNumberOrderingAssignment.Application.EndPoints;

public static class FileEndpoints
{
    public static void MapEndpoints(WebApplication app)
    {
        app.MapGet("/latest", (IFileService fileService) =>
        {
            var fileContents = fileService.ReadFileContents("result.txt");
            
            return Results.Ok(fileContents);
            
        }).WithName("GetLatestResults");
    }
}
