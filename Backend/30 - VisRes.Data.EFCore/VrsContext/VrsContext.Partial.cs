using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using VisRes.Models.EF;

namespace VisRes.Data.Api.Database
{
    public static class DBGlobals
    {
        public const string SchemaName = "Portal";
    }
}

namespace VisRes.Data.EFCore
{
    // Reverse POCO Generated
    public partial class VrsContext : DbContext
    {
        private static ILoggerFactory LoggerFactory => new LoggerFactory().AddConsole(LogLevel.Trace);

        public IConfiguration Configuration { get; }

        //public VrsContext(DbContextOptions<VrsContext> options) : base(options) { }
        public VrsContext() { }
        public VrsContext(DbContextOptions options) : base(options) { }



        #region "Stored Procedures View Models"
        public virtual DbSet<CompanyExpiredInsurancesViewModel> CompanyExpiredInsurancesViewModel { get; set; }

        #endregion



        //    #region "Maintenance tables"
        //    #endregion
        //    #region "Individual Details"
        //    #endregion
        //    #region "Company Details"
        //    #endregion
        //    #region "Contract"
        //    #endregion
        //    #region "ProjectDetails"
        //    #endregion

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Data Source=VS28MVAPPSQL1-T;Initial Catalog=VisResTwo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;TrustServerCertificate=True");
        //                //    optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));            }
        //            }
        //        }
    }

    //https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db
    #region "Code First - not working integration"

    //public class VrsContext : DbContext
    //{
    //    //public VrsContext(DbContextOptions<VrsContext> options) : base(options) { }
    //    public VrsContext() {  }
    //    public VrsContext(DbContextOptions options) : base(options) { }

    //    #region "Test"
    //    public DbSet<ZTodoItem> ZTodoItems { get; set; }
    //    public DbSet<ZCourse> ZCourses { get; set; }
    //    public DbSet<ZEnrollment> ZEnrollments { get; set; }
    //    public DbSet<ZStudent> ZStudents { get; set; }
    //    #endregion

    //    #region "Identity"
    //    public DbSet<Customer> Customers { get; set; }
    //    #endregion


    //    #region "ALL

    //    public virtual DbSet<TblDivision> TblDivisions { get; set; }

    //    #endregion



    //    //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    //        {
    //    //            if (!optionsBuilder.IsConfigured)
    //    //            {
    //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
    //    //                optionsBuilder.UseSqlServer(@"Data Source=VS28MVAPPSQL1-t;Initial Catalog=VisResTwoDeploy;Integrated Security=True");
    //    //            }
    //    //        }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        #region "EF Generator"

    //        #endregion

    //        #region "GP Extra Models"

    //        modelBuilder.Entity<TblDivision>().ToTable("tblDivision");

    //        modelBuilder.Entity<ZTodoItem>().ToTable("ZTodoItem");
    //        modelBuilder.Entity<ZCourse>().ToTable("ZCourse");
    //        modelBuilder.Entity<ZEnrollment>().ToTable("ZEnrollment");
    //        modelBuilder.Entity<ZStudent>().ToTable("ZStudent");

    //        #endregion

    //        #region "Create SHADOW PROPERTIES"

    //        CreateShadowProperties(modelBuilder);

    //        #endregion

    //    }

    //    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    //{
    //    //    #region "Test"
    //    //    #endregion

    //    //    modelBuilder.Entity<TblDivision>().ToTable("TblDivision");

    //    //}

    //    private void CreateShadowProperties(ModelBuilder modelBuilder)
    //    {
    //        // Create shadow properties
    //        foreach (var entityType in modelBuilder.Model.GetEntityTypes()
    //                                                     .Where(e => typeof(IAuditable).IsAssignableFrom(e.ClrType)))
    //        {
    //            modelBuilder.Entity(entityType.ClrType).Property<DateTime>("_Modified");
    //            modelBuilder.Entity(entityType.ClrType).Property<string>("_ModifiedBy");

    //            modelBuilder.Entity(entityType.ClrType).Property<DateTime>("_Created");
    //            modelBuilder.Entity(entityType.ClrType).Property<string>("_CreatedBy");
    //        }
    //        base.OnModelCreating(modelBuilder);
    //    }

    //    #region "Overrides"

    //    public override int SaveChanges()
    //    {
    //        ApplyAuditInformation();
    //        return base.SaveChanges();
    //    }

    //    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    //    {
    //        ApplyAuditInformation();
    //        return base.SaveChangesAsync(cancellationToken);
    //    }

    //    private void ApplyAuditInformation()
    //    {
    //        var modifiedEntities = ChangeTracker.Entries<IAuditable>()
    //            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
    //        foreach (var entity in modifiedEntities)
    //        {
    //            entity.Property("_Modified").CurrentValue = DateTime.UtcNow;
    //            entity.Property("_ModifiedBy").CurrentValue = "Bloody Paul!";

    //            if (entity.State == EntityState.Added)
    //            {
    //                entity.Property("_Created").CurrentValue = DateTime.UtcNow;
    //                entity.Property("_CreatedBy").CurrentValue = "GP";
    //            }
    //        }
    //    }

    //    #endregion



    //}

    #endregion

}
