using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using Microsoft.EntityFrameworkCore;
using VisRes.Business.Services;
using VisRes.Data.EFCore;
using VisRes.Data.Repositories;
using VisRes.Models.EF;
using VisRes.Service.Api.Controllers.Maintenance;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests.EFCore
{
    [SimpleJob(launchCount: 1, warmupCount: 2, targetCount: 5)]
    public class EFCore_Context_vs_Controller
    {
        readonly VrsContext _context;
        readonly LobsController _controllerLobs;
        readonly ILOBsService _lobsService;
        readonly ILOBsRepository _lobsRepository;

        public EFCore_Context_vs_Controller()
        {
            _context = new VrsContext();

            _controllerLobs = new LobsController(_lobsService);
            _lobsService = new LOBsService(_lobsRepository);
        }

        [Benchmark]
        public IList<tblLOBs> ByContext_Direct() => _context.tblLOBs.AsNoTracking().ToList();

        //[Benchmark]
        //public async Task<IList<tblLOBs>> ByController_WebAPI_All() => await _controllerLobs.All();
    }

}
