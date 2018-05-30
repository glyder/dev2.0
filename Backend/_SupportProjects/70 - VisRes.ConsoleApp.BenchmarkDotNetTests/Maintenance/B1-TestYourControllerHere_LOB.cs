using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisRes.Business.Services;
using VisRes.Data.EFCore;
using VisRes.Data.Repositories;
using VisRes.Models.EF;
using VisRes.Service.Api.Controllers.Maintenance;

namespace VisRes.ConsoleApp.BenchmarkDotNetTests.Maintenance
{
    /// <summary>
    /// Copy this as a template and rename it.
    /// </summary>

    [SimpleJob(launchCount: 1, warmupCount: 2, targetCount: 5)]
    public class B1_TestYourControllerHere_LOB
    {
        readonly VrsContext _context;
        readonly LobsController _controllerLobs;
        readonly ILOBsService _lobsService;
        readonly ILOBsRepository _lobsRepository;

        public B1_TestYourControllerHere_LOB()
        {
            _context = new VrsContext();
            _controllerLobs = new LobsController(_lobsService);
            _lobsRepository = new LOBsRepository(_context);
            _lobsService = new LOBsService(_lobsRepository);
        }

        [Benchmark]
        public async Task<IActionResult> Controller_GetById() =>  await _controllerLobs.GetById(8);

        [Benchmark]
        public async Task<IEnumerable<tblLOBs>> Controller_All() => await _controllerLobs.All();
    }

}
