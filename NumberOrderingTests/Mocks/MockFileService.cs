using DanskeNumberOrderingAssignment.Services;

namespace NumberOrderingTests.Mocks;
/// <summary>
/// A class that mocks the FileService class.
/// </summary>
public class MockFileService: IFileService
{
    private string _filePath;
    private string _fileContents;
    
    public void SaveArrayToFile(int[] array, string filePath)
    {
        _fileContents = string.Join(" ", array);
    }

    public string ReadFileContents(string filePath)
    {
        return _fileContents;
    }
}