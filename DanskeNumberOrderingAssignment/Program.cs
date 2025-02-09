using BenchmarkDotNet.Running;
using DanskeNumberOrderingAssignment.Application;
using DanskeNumberOrderingAssignment.PerformanceChecks;

namespace DanskeNumberOrderingAssignment;
/// <summary>
/// Main entry point for the application.
/// If the application is run with the --benchmark argument, the application will run benchmarks instead of the api.
/// run application with: "dotnet run -- --benchmark"
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Check if the application should run benchmarks (e.g., a specific command-line argument)
        if (args.Contains("--benchmark"))
        {
            // Launch benchmarks
            BenchmarkRunner.Run<AlgorithmBenchmarks>();
        }
        else
        {
            // Run the main application logic
            var app = Startup.InitializeApp(args);
            app.Run();
        }
    }
}