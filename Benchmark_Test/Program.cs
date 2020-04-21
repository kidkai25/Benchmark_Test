using BenchmarkDotNet.Running;
using System;

namespace Benchmark_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}
