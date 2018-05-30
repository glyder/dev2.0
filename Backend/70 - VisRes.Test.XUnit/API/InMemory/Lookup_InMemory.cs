using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisRes.Business.Services;
using VisRes.Data.EFCore;
using VisRes.Data.Repositories;
using VisRes.Models.EF;
using VisRes.Service.Api.Controllers.Maintenance;
using Xunit;

namespace API.InMemory
{
    public class Lookup_InMemory : IDisposable
    {
        private VrsContext _vrsContext;
        private ILOBsService _lobsService;
        readonly ILOBsRepository _lobsRepository;

        public Lookup_InMemory()
        {
            _vrsContext = new VrsContext();
            _lobsRepository = new LOBsRepository(_vrsContext);
            _lobsService = new LOBsService(_lobsRepository);
        }

        private static VrsContext GetDBContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<VrsContext>()
                                .UseInMemoryDatabase(databaseName: dbName)
                                .Options;

            var context = new VrsContext(options);

            var lobs = Enumerable.Range(1, 10)
                .Select(i => new tblLOBs { LOBID = i, LOB = $"Lob{i}" });
            context.tblLOBs.AddRange(lobs);

            int changed = context.SaveChanges();

            return context;
        }

        [Fact]
        public async Task Lobs_DBContext_GetById_2()
        {
            using (_vrsContext = GetDBContext("By_Context_Get_2"))
            {
                // Arrange
                string expectedTitle = "Lob2";
                int ID = 2;

                // Act
                var result = await _vrsContext.tblLOBs.SingleOrDefaultAsync(m => m.LOBID == ID);

                // Assert
                Assert.Equal(expectedTitle, result.LOB);
            }
        }

        //[Fact]
        //public void LobsController_GetById_2()
        //{

        //    using (_vrsContext = GetDBContext("By_Controller_Get_2"))
        //    {
        //        //Arrange
        //        string expectedTitle = "Lob2";
        //        var controller = new LobsController(_lobsService);

        //        // Act
        //        IActionResult actionResult = controller.GetById(2);

        //        // Assert
        //        Assert.NotNull(actionResult);

        //        OkObjectResult result = actionResult as OkObjectResult;
        //        Assert.NotNull(result);

        //        var _Lob = result.Value as tblLOBs;
        //        Assert.Equal(expectedTitle, _Lob.Lob);
        //    }
        //}

        public void Dispose()
        {

        }
    }
}
