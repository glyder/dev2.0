using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests
{
    [SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 5)]
    public class A2_DotNetFramework
    {
        //==========================================
        readonly int[] values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //==========================================
        Dictionary<string, string> dict;
        IDictionary<string, string> idict;
        //==========================================

        public A2_DotNetFramework()
        {
            dict = new Dictionary<string, string>();
            idict = (IDictionary<string, string>)dict;
        }

        //==========================================

        [Benchmark]
        [BenchmarkCategory("B", "2")]
        public void Array_Take_LINQ()
        {
            var a = values.Skip(5);
        }

        [Benchmark]
        [BenchmarkCategory("B", "1")]
        public void Array_Slice()
        {
            var span = new Span<int>(values, 0, values.Length);
            var a = span.Slice(5, span.Length - 5);
        }

        //==========================================

        [Benchmark]
        [BenchmarkCategory("B", "1")]
        public Dictionary<string, string> DictionaryEnumeration()
        {
            foreach (var item in dict)
            {
                ;
            }
            return dict;
        }

        [Benchmark]
        [BenchmarkCategory("B", "2")]
        public IDictionary<string, string> IDictionaryEnumeration()
        {
            foreach (var item in idict)
            {
                ;
            }
            return idict;
        }
    }
}
