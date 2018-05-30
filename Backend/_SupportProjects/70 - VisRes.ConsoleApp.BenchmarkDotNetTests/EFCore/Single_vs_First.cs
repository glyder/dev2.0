using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Engines;
using Microsoft.EntityFrameworkCore;
using VisRes.Data.EFCore;
using VisRes.Models.EF;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests.EFCore
{
    [SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 3)]
    //[SimpleJob(RunStrategy.ColdStart, targetCount: 5)]
    public class EFCore_Single_vs_First
    {
        readonly VrsContext _context;

        public EFCore_Single_vs_First()
        {
            _context = new VrsContext();
        }

        [Benchmark]
        public async Task<tblLOBs> SingleOfDefaultAsync() => await _context.tblLOBs.AsNoTracking().SingleOrDefaultAsync(m => m.LOBID == 8);

        [Benchmark]
        public async Task<tblLOBs> SingleOfDefaultAsync_Tracking() => await _context.tblLOBs.SingleOrDefaultAsync(m => m.LOBID == 9);

        [Benchmark]
        public async Task<tblLOBs> FirstAsync() => await _context.tblLOBs.FirstAsync(m => m.LOBID == 10);

    }
}
