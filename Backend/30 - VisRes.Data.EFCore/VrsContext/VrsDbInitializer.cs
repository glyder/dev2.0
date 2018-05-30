using System;
using System.Linq;
using Microsoft.Extensions.Logging;

using VisRes.Models;
using VisRes.Core.Infrastructure.Diagnostics;

namespace VisRes.Data.EFCore
{
    public static class VrsDbInitializer
    {
        public static void Initialize(VrsContext context, ILogger logger)
        {
            //NEVER!
            //if (DropDatabase)
            //{
            //    using (new DisposableStopwatch(t => Console.WriteLine("Ensure Deleted {0} elapsed\n", t.ToString("ss\\.FFFF")), "Ensure Deleted"))
            //    {
            //        context.Database.EnsureDeleted();
            //    }
            //}

            //Database tables have to be there!
            using (new DisposableStopwatch(t => Console.WriteLine("Ensure Created {0} elapsed\n", t.ToString("ss\\.FFFF")), "Ensure Created"))
            {
                context.Database.EnsureCreated();
            }

            //using (new DisposableStopwatch(t => Console.WriteLine("Seeding {0} elapsed\n\n", t.ToString("ss\\.FFFF")), "Seeding"))
            //{
            //    if (context.tblLOBs.Any())
            //    {
            //        return;   // DB has been seeded
            //    }
            //    VrsSeed(context);
            //}
        }

        public static void VrsSeed(VrsContext context)
        {
            Console.WriteLine("Seeding N/A to VisResTwo");

            //var regions = new Region[] {
            //    new Region{Name="1.1 - Fixed Networks",Active=true},
            //    new Region{Name="1.2 - Resources & Services",Active=true} };
            //foreach (Region r in regions) { context.Regions.Add(r); }
            //context.SaveChanges();
        }
    }
}
