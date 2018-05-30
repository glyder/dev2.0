using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Core.Infrastructure.EFCore;
using VisRes.Data.EFCore;
using System;

namespace VisRes.Business.Services
{
    public class BASEServiceFake
    {
        public readonly VrsContext _context;

        public BASEServiceFake()
        {
            _context = GetContextWithData();
            // _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public VrsContext GetContextWithData()
        {
            // http://gunnarpeipman.com/2017/04/aspnet-core-ef-inmemory/
            // https://mirkomaggioni.com/2017/07/01/in-memory-db-context-with-ef-core/
            // http://fiyazhasan.me/faking-with-in-memory-database-in-asp-net-core-2-0/
            // https://garywoodfine.com/entity-framework-core-memory-testing-database/
            // https://stormpath.com/blog/tutorial-entity-framework-core-in-memory-database-asp-net-core
            // http://blog.frankdecaire.com/category/entity-framework/

            //var options = new DbContextOptionsBuilder<VrsContext>()
            //                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
            //                  .Options;
            //var context = new VrsContext(options);

            DbContextOptionsBuilder<VrsContext> builder = new DbContextOptionsBuilder<VrsContext>()
                                                              .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString());
            var context = new VrsContext(builder.Options);
            // _repository = new GamesRepository(_context);

            context.tblLOBs.Add(new tblLOBs { LOBID = 1, LOB = "VIC/ TAS" });
            context.tblLOBs.Add(new tblLOBs { LOBID = 2, LOB = "NSW/ ACT" });
            context.tblLOBs.Add(new tblLOBs { LOBID = 3, LOB = "QLD/ NT" });
            context.tblLOBs.Add(new tblLOBs { LOBID = 4, LOB = "WA" });
            context.tblLOBs.Add(new tblLOBs { LOBID = 5, LOB = "SA" });
            context.tblLOBs.Add(new tblLOBs { LOBID = 6, LOB = "NATIONAL" });
            context.tblLOBs.Add(new tblLOBs { LOBID = 10, LOB = "4 - LOB - NBN" });
            
            context.SaveChanges();

            //var beerCategory = new Category { Id = 1, Name = "Beers" };
            //var wineCategory = new Category { Id = 2, Name = "Wines" };
            //context.Categories.Add(beerCategory);
            //context.Categories.Add(wineCategory);

            //context.Products.Add(new Product { Id = 1, Name = "La Trappe Isid'or", Category = beerCategory });
            //context.Products.Add(new Product { Id = 2, Name = "St. Bernardus Abt 12", Category = beerCategory });
            //context.Products.Add(new Product { Id = 3, Name = "Zundert", Category = beerCategory });
            //context.Products.Add(new Product { Id = 4, Name = "La Trappe Blond", Category = beerCategory });
            //context.Products.Add(new Product { Id = 5, Name = "La Trappe Bock", Category = beerCategory });
            //context.Products.Add(new Product { Id = 6, Name = "St. Bernardus Tripel", Category = beerCategory });
            //context.Products.Add(new Product { Id = 7, Name = "Grottenbier Bruin", Category = beerCategory });
            //context.Products.Add(new Product { Id = 8, Name = "St. Bernardus Pater 6", Category = beerCategory });
            //context.Products.Add(new Product { Id = 9, Name = "La Trappe Quadrupel", Category = beerCategory });
            //context.Products.Add(new Product { Id = 10, Name = "Westvleteren 12", Category = beerCategory });
            //context.Products.Add(new Product { Id = 11, Name = "Leffe Bruin", Category = beerCategory });
            //context.Products.Add(new Product { Id = 12, Name = "Leffe Royale", Category = beerCategory });
            //context.SaveChanges();

            return context;
        }
    }
}
