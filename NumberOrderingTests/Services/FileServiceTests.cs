using DanskeNumberOrderingAssignment.Services;

namespace NumberOrderingTests.Services;
/// <summary>
/// This class contains tests for the FileService class.
/// </summary>
[TestFixture]
public class FileServiceTests
{
    private FileService _fileService;
    
    [SetUp]
    public void Setup()
    {
        _fileService = new FileService();
    }
    
    [Test]
    public void ReadFile_ShouldSaveAndReadFiles()
    {
        // Arrange
        string path = "test.txt";
        int[] array = { 5, 2, 8, 1, 3 };
        string result = "5 2 8 1 3";
        
        // Act
        _fileService.SaveArrayToFile(array, path);
        string fileContents = _fileService.ReadFileContents(path);
        
        // Assert
        Assert.That(fileContents == result);
        
        // Cleanup
        File.Delete(path);
    }
}