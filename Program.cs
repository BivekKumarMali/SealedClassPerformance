using BenchmarkDotNet.Running;

namespace SealedClassPerformance
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}
