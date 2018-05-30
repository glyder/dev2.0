using System;
using System.Linq;

using System.Reflection;
using BenchmarkDotNet.Running;
using VisRes.ConsoleApp.BenchmarkDotNetTests.EFCore;
using VisRes.Data.EFCore;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Benchmarks");
            Console.WriteLine("===============\n");

            BenchmarkSwitcher.FromAssembly(typeof(EFCore_Context_vs_Controller).GetTypeInfo().Assembly).Run(args);

            //var summary = BenchmarkRunner.Run(typeof(Vrs.ConsoleApp.EFBenchmarks));
            
            Console.ReadLine();
        }

        public static void RunLobs(VrsContext context)
        {
            var lobs = context.tblLOBs.OrderBy(x => x.LOB);

            foreach (var lob in lobs)
            {
                Console.WriteLine($"{lob.LOBID} {lob.LOB}");
            }

            var lobs2 = context.tblLOBs.OrderBy(x => x.LOB);

            foreach (var lob in lobs2)
            {
                Console.WriteLine($"{lob.LOBID} {lob.LOB}");
            }
        }
    }
}
