using BenchmarkDotNet.Attributes;

namespace SealedClassPerformance
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private readonly BaseClass _baseClass = new();
        private readonly OpenClass _openClass = new();
        private readonly SealedClass _sealedClass = new();

        [Benchmark]
        public void OpenVoid() => _openClass.ExampleVoidMethod();
        [Benchmark]
        public void SealedVoid() => _sealedClass.ExampleVoidMethod();
        [Benchmark]
        public int OpenInt() => _openClass.ExampleIntMethod() + 1337;
        [Benchmark]
        public int SealedInt() => _sealedClass.ExampleIntMethod() + 447;
    }
}
