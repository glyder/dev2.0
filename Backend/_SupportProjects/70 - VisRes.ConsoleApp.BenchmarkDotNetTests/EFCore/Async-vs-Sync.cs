using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using BenchmarkDotNet.Attributes;

using VisRes.Data.EFCore;
using VisRes.Models.EF;
using BenchmarkDotNet.Attributes.Jobs;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests.EFCore
{
    [SimpleJob(launchCount: 1, warmupCount: 2, targetCount: 5)]
    public class EFCore_Async_vs_Sync
    {
        readonly VrsContext _context;

        public EFCore_Async_vs_Sync()
        {
            _context = new VrsContext();
        }

        [Benchmark]
        public IList<tblLOBs> DbContext_Sync() => _context.tblLOBs.AsNoTracking().ToList();

        [Benchmark]
        public async Task<IList<tblLOBs>> DbContext_Async() => await _context.tblLOBs.AsNoTracking().ToListAsync();

        [Benchmark]
        public async Task<IList<tblLOBs>> DbContext_Async_StoredProcedure() => await _context.tblLOBs.FromSql("Lobs_All").ToArrayAsync();


    }

}
