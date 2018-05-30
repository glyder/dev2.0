using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests
{
    //[SimpleJob(RunStrategy.ColdStart, targetCount: 5)]
    //[MinColumn, MaxColumn, MeanColumn, MedianColumn]
    //[ClrJob, CoreJob]
    [SimpleJob(launchCount: 1, warmupCount: 3, targetCount: 5)]
    public class A1_Crypto_And_StringBuilder
    {
        //==========================================
        private const int N = 10000;
        private readonly byte[] data;

        private readonly SHA256 sha256 = SHA256.Create();
        private readonly MD5 md5 = MD5.Create();
        //==========================================

        public A1_Crypto_And_StringBuilder()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        //==========================================

        [Benchmark]
        [BenchmarkCategory("A", "1")]
        public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        [BenchmarkCategory("A", "2")]
        public byte[] Md5() => md5.ComputeHash(data);

        //==========================================
    }
}
