using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vrs.Core.Infrastructure.EFCore;
using Vrs.Data.EFCore;
using Vrs.Models;
using Vrs.Models.EF;

namespace Vrs.Service.Api.Controllers.Domain
{
    [Produces("application/json")]
    [Route("api/storedprocedure")]
    public class StoredProceduresController : Controller
    {
        private readonly VrsContext _context;

        public StoredProceduresController(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        [Route("CompanyExpiredInsurances")]
        [HttpGet]
        public async Task<IEnumerable<CompanyExpiredInsurancesViewModel>> CompanyExpiredInsurances_DBSet()
        {
            return await _context.CompanyExpiredInsurancesViewModel
                                 .FromSql("sp_Dashboard_CompanyExpiredInsurances")
                                 .ToArrayAsync();
        }

        [Route("CompanyExpiredInsurancesEFExtensions")]
        [HttpGet]
        public IEnumerable<CompanyExpiredInsurancesViewModel> CompanyExpiredInsurances_EFExtensions()
        {
            IEnumerable<CompanyExpiredInsurancesViewModel> results = null;

            _context.LoadStoredProc("dbo.sp_Dashboard_CompanyExpiredInsurances")
                     // .WithSqlParam("fooId", 1)
                    .ExecuteStoredProc((handler) =>
                    {
                        results = handler.ReadToList<CompanyExpiredInsurancesViewModel>();
                        // do something with your results.
                    });

            return results;
        }


        // FromSQL examples
        // https://visualstudiomagazine.com/articles/2018/04/01/leveraging-raw-sql.aspx
        // https://www.learnentityframeworkcore.com/dbset
        // https://www.learnentityframeworkcore.com/raw-sql
        // https://www.learnentityframeworkcore.com/dbcontext
        public void Test()
        {
            // var books = context.Books.FromSql("SELECT BookId, Title FROM Books").ToList();
            var custs1 = _context.tblCompanies
                                .FromSql("Select * from Customers Where Status = 1")
                                .Where(c => c.LastUpdateDate < DateTime.Now)
                                .ToList();

            var custs2 = _context.tblCompanies
                            .FromSql("Select * from Customers")
                            .Include(c => c.tblCompanyInsurances)
                            .ToList();

            var custs3 = _context.tblCompanies
                            .FromSql("Select * from CustomersWithOrdersOver(10000)")
                            .Include(c => c.tblContracts)
                            .ToList();

            int cLimit;
            cLimit = 10000;
            var custs4 = _context.tblCompanies
                        .FromSql($"Select * from Customers Where CreditLimit = {cLimit}")
                        .ToList();

            var custs5 = _context.tblCompanies
                                .FromSql("Select * from Customers Where CreditLimit = {0}", cLimit)
                                .ToList();

            System.Data.Common.DbParameter cLimit2 = new System.Data.SqlClient.SqlParameter("limit", 110);
            var custs6 = _context.tblCompanies
                        .FromSql("Select * from Customers Where CreditLimit = @limit", cLimit2)
                        .ToList();

            // ================================
            var books1 = _context.tblCompanies
                                .FromSql("EXEC GetAllBooks")
                                .ToList();

            var authorId = new System.Data.SqlClient.SqlParameter("@AuthorId", 1);
            var books2 = _context.tblCompanies
                                .FromSql("EXEC GetBooksByAuthor @AuthorId", authorId)
                                .ToList();

            var books = _context.tblCompanies
                                .FromSql("SELECT * FROM Books")
                                .Select(b => new {
                                    BookId = b.CompanyID,
                                    Title = b.CompanyName
                                }).ToList();

            var commandText = "INSERT Categories (CategoryName) VALUES (@CategoryName)";
            var name = new System.Data.SqlClient.SqlParameter("@CategoryName", "Test");
            _context.Database.ExecuteSqlCommand(commandText, name);

            var name1 = new System.Data.SqlClient.SqlParameter("@CategoryName", "Test");
            _context.Database.ExecuteSqlCommand("EXEC AddCategory @CategoryName", name);
        }
    }

}
