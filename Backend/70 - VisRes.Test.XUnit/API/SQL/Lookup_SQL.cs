using System;
using System.Threading.Tasks;
using VisRes.Data.EFCore;
using VisRes.Models.EF;
using Xunit;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using VisRes.Service.Api.Controllers.Maintenance;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VisRes.Business.Services;
using System.Linq;
using VisRes.Data.Repositories;

namespace API.SQL
{
    public class Lookup_SQL : IDisposable
    {
        private const string LOBS_NAME = "0 - Closed Projects";
        private const int LOBS_ID = 8;
        private const int LOBS_TOTALCOUNT = 22;

        private const string DIVISION_NAME = "Visionstream";
        private const int DIVISION_ID = 1;
        private const int DIVISIONS_TOTALCOUNT = 5;

        private VrsContext _vrsContext;
        readonly ILOBsService _lobsService;
        readonly ILOBsRepository _lobsRepository;

        public IConfiguration Configuration { get; }

        public Lookup_SQL()
        {
            InitContext();
            _lobsRepository = new LOBsRepository(_vrsContext);
            _lobsService = new LOBsService(_lobsRepository);
        }

        public void InitContext()
        {
            _vrsContext = new VrsContext();
            //VrsDbInitializer.Initialize(_vrsContext, null);
        }

        #region "Division"

        [Fact]
        public async Task DivisionsController_GetById_1()
        {
            //Arrange
            string expectedTitle = DIVISION_NAME;
            int ID = DIVISION_ID;

            var controller = new DivisionsController(_vrsContext);

            // Act
            IActionResult actionResult = await controller.GetById(ID);

            // Assert
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;
            Assert.NotNull(result);

            var _Division = result.Value as tblDivisions;
            Assert.Equal(expectedTitle, _Division.Name);
        }

        [Fact]
        public async Task DivisionsController_TotalCount()
        {
            //Arrange
            var controller = new DivisionsController(_vrsContext);

            int expectedCount = DIVISIONS_TOTALCOUNT;

            // Act
            var _list = await controller.All();

            // Assert
            Assert.Equal(_list.Count, expectedCount);
        }

        #endregion

        #region "tblLOBS"

        [Fact]
        public async Task LobsController_AreYouWorking()
        {
            //Arrange
            var controller = new LobsController(_lobsService);

            // Act
            var actionResult = await controller.All();

            // Assert
            Assert.NotNull(actionResult);
        }


        [Fact]
        public async Task LobsController_TotalCount()
        {
            //Arrange
            var controller = new LobsController(_lobsService);

            int expectedCount = LOBS_TOTALCOUNT;

            // Act
            var _listLobs = await controller.All();

            // Assert
            Assert.Equal(_listLobs.Count(), expectedCount);
        }

        //[Fact]
        //public async Task LobsController_GetById_8()
        //{
        //    //Arrange
        //    var controller = new LobsController(_lobsService);

        //    string expectedTitle = LOBS_NAME;
        //    int ID = LOBS_ID;

        //    // Act
        //    IActionResult actionResult = controller.GetById(ID);

        //    // Assert
        //    Assert.NotNull(actionResult);

        //    OkObjectResult result = actionResult as OkObjectResult;
        //    Assert.NotNull(result);

        //    var _Lob = result.Value as tblLOBs;
        //    Assert.Equal(expectedTitle, _Lob.Lob);
        //}

        [Fact]
        public async Task LobsController_GetById_28()
        {
            //Arrange
            string expectedTitle = "Visionstream NZ";
            int ID = 28;

            var controller = new LobsController(_lobsService);

            // Act
            IActionResult actionResult =  await controller.GetById(ID);

            // Assert
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;
            Assert.NotNull(result);

            var _Lob = result.Value as tblLOBs;
            Assert.Equal(expectedTitle, _Lob.LOB);
        }

        #endregion

        public void Dispose()
        {
        }
    }
}
