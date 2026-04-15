using BenchmarkDotNet.Running;

namespace ClearHl7.Benchmarks
{
    /// <summary>
    /// Entry point for ClearHl7 performance benchmarks.
    ///
    /// Run in Release mode:
    ///   dotnet run --project benchmarks/ClearHl7.Benchmarks -c Release
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
