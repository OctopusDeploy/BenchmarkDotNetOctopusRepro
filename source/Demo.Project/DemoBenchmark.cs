using System.Threading;
using BenchmarkDotNet.Attributes;

namespace Demo.Project
{
    public class DemoBenchmark
    {
        [Benchmark]
        public void DemoBenchmarkMethod()
        {
            for (var index = 0; index < 10; index++) Thread.Sleep(500);
        }
    }
}