using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using NUnit.Framework;

namespace Demo.Project
{
    [TestFixture]
    public class DemoClass
    {
        public class DemoBenchmark
        {
            [Benchmark]
            public void DemoBenchmarkMethod()
            {
                for (var index = 0; index < 10; index++) Thread.Sleep(500);
            }
        }

        [Test]
        public void DemoExecute()
        {
            BenchmarkRunner.Run<DemoBenchmark>(new DebugBuildConfig());
        }
    }
}