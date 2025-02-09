namespace DanskeNumberOrderingAssignment.Services;

public class FileService : IFileService
{
    public void SaveArrayToFile(int[] array, string filePath)
    {
        File.WriteAllText(filePath, string.Join(" ", array));
    }

    public string ReadFileContents(string filePath)
    {
        return File.Exists(filePath) ? File.ReadAllText(filePath) : null;
    }
}
