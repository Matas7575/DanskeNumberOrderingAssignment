using DanskeNumberOrderingAssignment.Services;

namespace DanskeNumberOrderingAssignment.Application.EndPoints;

public static class SortingEndpoints
{
    public static void MapEndpoints(WebApplication app)
    {
        app.MapPost("/sortArray", async (SortRequest request, ISortingService sortingService, IFileService fileService) =>
        {
            var sortedArray = new int[0];
            
            switch (request.Algorithm)
            {
                case "BubbleSort":
                    sortedArray = sortingService.BubbleSort(request.Array);
                    break;
                case "MergeSort":
                    sortedArray = sortingService.MergeSort(request.Array);
                    break;
                case "QuickSort":
                    sortedArray = sortingService.QuickSort(request.Array);
                    break;
                default:
                    return Results.BadRequest("Invalid algorithm");
            }
            
            fileService.SaveArrayToFile(sortedArray, "result.txt");
            
            return Results.Ok("Array sorted and saved to result.txt");
        }).WithName("SortArray");
    }
}