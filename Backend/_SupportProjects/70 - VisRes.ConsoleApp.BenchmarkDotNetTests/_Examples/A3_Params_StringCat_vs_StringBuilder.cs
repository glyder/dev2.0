using System.Text;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests
{
    [SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 2)]
    public class A3_Params_StringConcatVsStringBuilder
    {
        [Params(1, 2, 3, 4, 5, 10, 15, 20)]
        public int Loops;

        [Benchmark]
        public string StringConcat()
        {
            string result = string.Empty;
            for (int i = 0; i < Loops; ++i)
                result = string.Concat(result, i.ToString());
            return result;
        }

        [Benchmark]
        public string StringBuilder()
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < Loops; ++i)
                sb.Append(i.ToString());
            return sb.ToString();
        }
    }
}
