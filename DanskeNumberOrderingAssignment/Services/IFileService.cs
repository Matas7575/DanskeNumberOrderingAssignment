namespace DanskeNumberOrderingAssignment.Services;

public interface IFileService
{
    void SaveArrayToFile(int[] array, string filePath);
    string ReadFileContents(string filePath);
}
