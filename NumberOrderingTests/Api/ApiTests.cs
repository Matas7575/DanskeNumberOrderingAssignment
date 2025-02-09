using System.Net;
using System.Text;
using System.Text.Json;
using DanskeNumberOrderingAssignment;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using NumberOrderingTests.Mocks;

namespace NumberOrderingTests.Api;
/// <summary>
/// This class contains tests for the API.
/// This is just testing if the API is responsive and returns the expected status codes.
/// </summary>
[TestFixture]
public class ApiTests
{
    private HttpClient _client;
    private MockSortingService _sortingServiceMock;
    private MockFileService _fileService;

    [SetUp]
    public void Setup()
    {
        // Mock the SortingService
        _sortingServiceMock = new MockSortingService();
        _fileService = new MockFileService();

        // Configure WebApplicationFactory with the mocked service
        var factory = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddSingleton(_sortingServiceMock); // Use the mocked service
                    services.AddSingleton(_fileService); // Use the mocked service
                });
            });

        _client = factory.CreateClient();
    }
    
    [TearDown]
    public void TearDown()
    {
        _client.Dispose();
    }

    [Test]
    public async Task GetLatest_ShouldReturnStatusCodeOk()
    {
        // Act
        var response = await _client.GetAsync("/latest");
        
        // Assert
        Assert.That(HttpStatusCode.OK == response.StatusCode);
    }

    [Test]
    public async Task SortArray_BubbleSort_ShouldReturnStatusCodeOk()
    {
        // Arrange
        var request = new
        {
            Array = new[] { 5, 1, 3, 2, 4 },
            Algorithm = "BubbleSort"
        };
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
    
        // Act
        var response = await _client.PostAsync("/sortArray", content);
        
        // Assert
        Assert.That(HttpStatusCode.OK == response.StatusCode);
    }
    
    [Test]
    public async Task SortArray_MergeSort_ShouldReturnStatusCodeOk()
    {
        // Arrange
        var request = new
        {
            Array = new[] { 5, 1, 3, 2, 4 },
            Algorithm = "MergeSort"
        };
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
    
        // Act
        var response = await _client.PostAsync("/sortArray", content);
        
        // Assert
        Assert.That(HttpStatusCode.OK == response.StatusCode);
    }
    
    [Test]
    public async Task SortArray_QuickSort_ShouldReturnStatusCodeOk()
    {
        // Arrange
        var request = new
        {
            Array = new[] { 5, 1, 3, 2, 4 },
            Algorithm = "QuickSort"
        };
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
    
        // Act
        var response = await _client.PostAsync("/sortArray", content);
        
        // Assert
        Assert.That(HttpStatusCode.OK == response.StatusCode);
    }
    
    [Test]
    public async Task SortArray_InvalidAlgorithm_ShouldReturnStatusCodeBadRequest()
    {
        // Arrange
        var request = new
        {
            Array = new[] { 5, 1, 3, 2, 4 },
            Algorithm = "InvalidAlgorithm"
        };
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
    
        // Act
        var response = await _client.PostAsync("/sortArray", content);
        
        // Assert
        Assert.That(HttpStatusCode.BadRequest == response.StatusCode);
    }
}
