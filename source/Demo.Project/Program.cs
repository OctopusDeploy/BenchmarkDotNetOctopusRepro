using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Demo.Project
{
    public class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<DemoBenchmark>(new DebugBuildConfig());

        }
    }
}