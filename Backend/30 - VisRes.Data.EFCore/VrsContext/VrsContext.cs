using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;

namespace VisRes.Data.EFCore
{
    public partial class VrsContext : DbContext
    {
        public virtual DbSet<tblAccreditationLicencing> tblAccreditationLicencing { get; set; }
        public virtual DbSet<tblAddresses> tblAddresses { get; set; }
        public virtual DbSet<tblAddressTypes> tblAddressTypes { get; set; }
        public virtual DbSet<tblAlternativeCompetencies> tblAlternativeCompetencies { get; set; }
        public virtual DbSet<tblAreasOfOperation> tblAreasOfOperation { get; set; }
        public virtual DbSet<tblAttachmentCategoryObject> tblAttachmentCategoryObject { get; set; }
        public virtual DbSet<tblAttachments> tblAttachments { get; set; }
        public virtual DbSet<tblAttachmentTypeCategory> tblAttachmentTypeCategory { get; set; }
        public virtual DbSet<tblAttachmentTypes> tblAttachmentTypes { get; set; }
        public virtual DbSet<tblCapabilities> tblCapabilities { get; set; }
        public virtual DbSet<tblCapabilityGroups> tblCapabilityGroups { get; set; }
        public virtual DbSet<tblCompanies> tblCompanies { get; set; }
        public virtual DbSet<tblCompanyAccreditationAttachments> tblCompanyAccreditationAttachments { get; set; }
        public virtual DbSet<tblCompanyAccreditationNotifications> tblCompanyAccreditationNotifications { get; set; }
        public virtual DbSet<tblCompanyAccreditations> tblCompanyAccreditations { get; set; }
        public virtual DbSet<tblCompanyAddresses> tblCompanyAddresses { get; set; }
        public virtual DbSet<tblCompanyAreasOfOperation> tblCompanyAreasOfOperation { get; set; }
        public virtual DbSet<tblCompanyAttachments> tblCompanyAttachments { get; set; }
        public virtual DbSet<tblCompanyCapabilities> tblCompanyCapabilities { get; set; }
        public virtual DbSet<tblCompanyComments> tblCompanyComments { get; set; }
        public virtual DbSet<tblCompanyDueDiligence> tblCompanyDueDiligence { get; set; }
        public virtual DbSet<tblCompanyIndividuals> tblCompanyIndividuals { get; set; }
        public virtual DbSet<tblCompanyInsurances> tblCompanyInsurances { get; set; }
        public virtual DbSet<tblCompanyIntegrations> tblCompanyIntegrations { get; set; }
        public virtual DbSet<tblCompanyOnboarding> tblCompanyOnboarding { get; set; }
        public virtual DbSet<tblCompanyOnboardingAttachments> tblCompanyOnboardingAttachments { get; set; }
        public virtual DbSet<tblCompanyOnboardingIRStatuses> tblCompanyOnboardingIRStatuses { get; set; }
        public virtual DbSet<tblCompanyOnboardingOperStatuses> tblCompanyOnboardingOperStatuses { get; set; }
        public virtual DbSet<tblCompanyOnboardingSHEQStatuses> tblCompanyOnboardingSHEQStatuses { get; set; }
        public virtual DbSet<tblCompanyOnboardingStatuses> tblCompanyOnboardingStatuses { get; set; }
        public virtual DbSet<tblCompanyPlants> tblCompanyPlants { get; set; }
        public virtual DbSet<tblCompanySubContractors> tblCompanySubContractors { get; set; }
        public virtual DbSet<tblCompanySubStatuses> tblCompanySubStatuses { get; set; }
        public virtual DbSet<tblCompanySuspensions> tblCompanySuspensions { get; set; }
        public virtual DbSet<tblCompanyTypes> tblCompanyTypes { get; set; }
        public virtual DbSet<tblCompetencies> tblCompetencies { get; set; }
        public virtual DbSet<tblCompetencyIntegrations> tblCompetencyIntegrations { get; set; }
        public virtual DbSet<tblCompetencyNotifications> tblCompetencyNotifications { get; set; }
        public virtual DbSet<tblCompetencyScores> tblCompetencyScores { get; set; }
        public virtual DbSet<tblCompetencyToJurisdiction> tblCompetencyToJurisdiction { get; set; }
        public virtual DbSet<tblCompetencyToRCGroup> tblCompetencyToRCGroup { get; set; }
        public virtual DbSet<tblCompetencyTypes> tblCompetencyTypes { get; set; }
        public virtual DbSet<tblComplianceCompetencyGroupList> tblComplianceCompetencyGroupList { get; set; }
        public virtual DbSet<tblComplianceCompetencyGroups> tblComplianceCompetencyGroups { get; set; }
        public virtual DbSet<tblContractAttachments> tblContractAttachments { get; set; }
        public virtual DbSet<tblContractIntegrations> tblContractIntegrations { get; set; }
        public virtual DbSet<tblContractProjects> tblContractProjects { get; set; }
        public virtual DbSet<tblContracts> tblContracts { get; set; }
        public virtual DbSet<tblContractStatuses> tblContractStatuses { get; set; }
        public virtual DbSet<tblContractSubStatuses> tblContractSubStatuses { get; set; }
        public virtual DbSet<tblContractTypes> tblContractTypes { get; set; }
        public virtual DbSet<tblCountries> tblCountries { get; set; }
        public virtual DbSet<tblDefaultProjectRoles> tblDefaultProjectRoles { get; set; }
        public virtual DbSet<tblDivisionBranding> tblDivisionBranding { get; set; }
        public virtual DbSet<tblDivisions> tblDivisions { get; set; }
        public virtual DbSet<tblEOI> tblEOI { get; set; }
        public virtual DbSet<tblEventLogs> tblEventLogs { get; set; }
        public virtual DbSet<tblEvidenceLevel> tblEvidenceLevel { get; set; }
        public virtual DbSet<tblIndividualAddresses> tblIndividualAddresses { get; set; }
        public virtual DbSet<tblIndividualAttachments> tblIndividualAttachments { get; set; }
        public virtual DbSet<tblIndividualComments> tblIndividualComments { get; set; }
        public virtual DbSet<tblIndividualCompetencies> tblIndividualCompetencies { get; set; }
        public virtual DbSet<tblIndividualCompetencyAttachments> tblIndividualCompetencyAttachments { get; set; }
        public virtual DbSet<tblIndividualCompetencySubStatuses> tblIndividualCompetencySubStatuses { get; set; }
        public virtual DbSet<tblIndividualIDCards> tblIndividualIDCards { get; set; }
        public virtual DbSet<tblIndividualIndividual> tblIndividualIndividual { get; set; }
        public virtual DbSet<tblIndividualIndividualRelations> tblIndividualIndividualRelations { get; set; }
        public virtual DbSet<tblIndividualProjectRoles> tblIndividualProjectRoles { get; set; }
        public virtual DbSet<tblIndividualProjects> tblIndividualProjects { get; set; }
        public virtual DbSet<tblIndividualProjectStatuses> tblIndividualProjectStatuses { get; set; }
        public virtual DbSet<tblIndividualRelationshipTypes> tblIndividualRelationshipTypes { get; set; }
        public virtual DbSet<tblIndividuals> tblIndividuals { get; set; }
        public virtual DbSet<tblIndividualStatuses> tblIndividualStatuses { get; set; }
        public virtual DbSet<tblIndividualSubStatuses> tblIndividualSubStatuses { get; set; }
        public virtual DbSet<tblIndividualSuspensions> tblIndividualSuspensions { get; set; }
        public virtual DbSet<tblIndividualTypes> tblIndividualTypes { get; set; }
        public virtual DbSet<tblInsuranceAttachments> tblInsuranceAttachments { get; set; }
        public virtual DbSet<tblInsuranceNotifications> tblInsuranceNotifications { get; set; }
        public virtual DbSet<tblInsurances> tblInsurances { get; set; }
        public virtual DbSet<tblInsuranceSubStatuses> tblInsuranceSubStatuses { get; set; }
        public virtual DbSet<tblInsuranceTypes> tblInsuranceTypes { get; set; }
        public virtual DbSet<tblIRStatuses> tblIRStatuses { get; set; }
        public virtual DbSet<tblJurisdictions> tblJurisdictions { get; set; }
        public virtual DbSet<tblLOBs> tblLOBs { get; set; }
        public virtual DbSet<tblNotificationCategories> tblNotificationCategories { get; set; }
        public virtual DbSet<tblNotificationListIndividuals> tblNotificationListIndividuals { get; set; }
        public virtual DbSet<tblNotificationLists> tblNotificationLists { get; set; }
        public virtual DbSet<tblNotifications> tblNotifications { get; set; }
        public virtual DbSet<tblNotificationTypes> tblNotificationTypes { get; set; }
        public virtual DbSet<tblOperStatuses> tblOperStatuses { get; set; }
        public virtual DbSet<tblPlantAttachments> tblPlantAttachments { get; set; }
        public virtual DbSet<tblPlantComments> tblPlantComments { get; set; }
        public virtual DbSet<tblPlantInsurances> tblPlantInsurances { get; set; }
        public virtual DbSet<tblPlants> tblPlants { get; set; }
        public virtual DbSet<tblPlantSuspensions> tblPlantSuspensions { get; set; }
        public virtual DbSet<tblPlantTypes> tblPlantTypes { get; set; }
        public virtual DbSet<tblProjectAddresses> tblProjectAddresses { get; set; }
        public virtual DbSet<tblProjectAttachments> tblProjectAttachments { get; set; }
        public virtual DbSet<tblProjectCodes> tblProjectCodes { get; set; }
        public virtual DbSet<tblProjectIntegrations> tblProjectIntegrations { get; set; }
        public virtual DbSet<tblProjectJurisdictions> tblProjectJurisdictions { get; set; }
        public virtual DbSet<tblProjectNotifications> tblProjectNotifications { get; set; }
        public virtual DbSet<tblProjectRoles> tblProjectRoles { get; set; }
        public virtual DbSet<tblProjectRoleScores> tblProjectRoleScores { get; set; }
        public virtual DbSet<tblProjectRoleToCompetency> tblProjectRoleToCompetency { get; set; }
        public virtual DbSet<tblProjectRoleToRoleLibrary> tblProjectRoleToRoleLibrary { get; set; }
        public virtual DbSet<tblProjects> tblProjects { get; set; }
        public virtual DbSet<tblProjectStatuses> tblProjectStatuses { get; set; }
        public virtual DbSet<tblProjectSubStatuses> tblProjectSubStatuses { get; set; }
        public virtual DbSet<tblProviderSuspensions> tblProviderSuspensions { get; set; }
        public virtual DbSet<tblRCGHierarchies> tblRCGHierarchies { get; set; }
        public virtual DbSet<tblRCGroups> tblRCGroups { get; set; }
        public virtual DbSet<tblRoleLibrary> tblRoleLibrary { get; set; }
        public virtual DbSet<tblRoleToCompetency> tblRoleToCompetency { get; set; }
        public virtual DbSet<tblRoleToGroup> tblRoleToGroup { get; set; }
        public virtual DbSet<tblRoleToRole> tblRoleToRole { get; set; }
        public virtual DbSet<tblScoreTypes> tblScoreTypes { get; set; }
        public virtual DbSet<tblSHEQStatuses> tblSHEQStatuses { get; set; }
        public virtual DbSet<tblStates> tblStates { get; set; }
        public virtual DbSet<tblSuspensionNotes> tblSuspensionNotes { get; set; }
        public virtual DbSet<tblSuspensionReasons> tblSuspensionReasons { get; set; }
        public virtual DbSet<tblSuspensions> tblSuspensions { get; set; }
        public virtual DbSet<tblSuspensionStatuses> tblSuspensionStatuses { get; set; }
        public virtual DbSet<tblSuspensionTypes> tblSuspensionTypes { get; set; }
        public virtual DbSet<tblTrainingFields> tblTrainingFields { get; set; }
        public virtual DbSet<tblUserLevels> tblUserLevels { get; set; }
        public virtual DbSet<tblUserMatrix> tblUserMatrix { get; set; }
        public virtual DbSet<tblUserProjects> tblUserProjects { get; set; }
        public virtual DbSet<tblUsers> tblUsers { get; set; }
        public virtual DbSet<tblUserSessions> tblUserSessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=TST-VM-VRSQL1;Initial Catalog=VisRes2;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAccreditationLicencing>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tblAddresses>(entity =>
            {
                entity.Property(e => e.AddressID).ValueGeneratedNever();

                entity.Property(e => e.AddressLine1).IsUnicode(false);

                entity.Property(e => e.AddressLine2).IsUnicode(false);

                entity.Property(e => e.AddressLine3).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.PostCode).IsUnicode(false);

                entity.Property(e => e.Suburb).IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.tblAddresses)
                    .HasForeignKey(d => d.CountryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAddresses_tblCountry");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.tblAddresses)
                    .HasForeignKey(d => d.StateID)
                    .HasConstraintName("FK_tblAddresses_tblStates");
            });

            modelBuilder.Entity<tblAddressTypes>(entity =>
            {
                entity.Property(e => e.AddressTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblAlternativeCompetencies>(entity =>
            {
                entity.Property(e => e.AlternativeCompetencyID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.CanBeReplacedByCompetencyNavigation)
                    .WithMany(p => p.tblAlternativeCompetenciesCanBeReplacedByCompetencyNavigation)
                    .HasForeignKey(d => d.CanBeReplacedByCompetency)
                    .HasConstraintName("FK_tblAlternativeCompetencies_tblCompetencies");

                entity.HasOne(d => d.CanBeReplacedByGroupNavigation)
                    .WithMany(p => p.tblAlternativeCompetencies)
                    .HasForeignKey(d => d.CanBeReplacedByGroup)
                    .HasConstraintName("FK_tblAlternativeCompetencies_tblComplianceCompetencyGroups");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblAlternativeCompetenciesCompetency)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAlternativeCompetencies_tblCompetencies2");
            });

            modelBuilder.Entity<tblAreasOfOperation>(entity =>
            {
                entity.Property(e => e.AreaCode).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.ExchangeName).IsUnicode(false);

                entity.HasOne(d => d.Jurisdiction)
                    .WithMany(p => p.tblAreasOfOperation)
                    .HasForeignKey(d => d.JurisdictionID)
                    .HasConstraintName("FK_tblAreasOfOperation_tblJurisdictions");
            });

            modelBuilder.Entity<tblAttachmentCategoryObject>(entity =>
            {
                entity.Property(e => e.AttachmentCategoryObjectID).ValueGeneratedNever();

                entity.Property(e => e.ObjectName).IsUnicode(false);

                entity.HasOne(d => d.AttachmentTypeCategory)
                    .WithMany(p => p.tblAttachmentCategoryObject)
                    .HasForeignKey(d => d.AttachmentTypeCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachmentCategoryObject_tblAttachmentTypeCategory");
            });

            modelBuilder.Entity<tblAttachments>(entity =>
            {
                entity.Property(e => e.AttachmentID).ValueGeneratedNever();

                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OriginalFileName).IsUnicode(false);
            });

            modelBuilder.Entity<tblAttachmentTypeCategory>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tblAttachmentTypes>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblCapabilities>(entity =>
            {
                entity.Property(e => e.Capability).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.SubCapability).IsUnicode(false);

                entity.HasOne(d => d.CapabilityGroup)
                    .WithMany(p => p.tblCapabilities)
                    .HasForeignKey(d => d.CapabilityGroupID)
                    .HasConstraintName("FK_tblCapabilities_tblCapabilityGroups");
            });

            modelBuilder.Entity<tblCapabilityGroups>(entity =>
            {
                entity.Property(e => e.CapabilityGroup).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tblCompanies>(entity =>
            {
                entity.Property(e => e.ABN).IsUnicode(false);

                entity.Property(e => e.ACN).IsUnicode(false);

                entity.Property(e => e.ADDRESS_LINE3).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.CustomerNumber).IsUnicode(false);

                entity.Property(e => e.EMailAddress).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.FacsimileNumber).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.OPERATING_UNIT).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.RTONumber).IsUnicode(false);

                entity.Property(e => e.SEGMENT1).IsUnicode(false);

                entity.Property(e => e.TradingName).IsUnicode(false);

                entity.Property(e => e.VENDOR_SITE_CODE).IsUnicode(false);

                entity.HasOne(d => d.AccountsPayableContact)
                    .WithMany(p => p.tblCompaniesAccountsPayableContact)
                    .HasForeignKey(d => d.AccountsPayableContactID)
                    .HasConstraintName("FK_tblCompanies_AccountPayableContact");

                entity.HasOne(d => d.AccountsReceivableContact)
                    .WithMany(p => p.tblCompaniesAccountsReceivableContact)
                    .HasForeignKey(d => d.AccountsReceivableContactID)
                    .HasConstraintName("FK_tblCompanies_AccountReceivableContact");

                entity.HasOne(d => d.CompanySubStatus)
                    .WithMany(p => p.tblCompanies)
                    .HasForeignKey(d => d.CompanySubStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanies_tblCompanySubStatuses");

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.tblCompanies)
                    .HasForeignKey(d => d.CompanyTypeID)
                    .HasConstraintName("FK_tblCompanies_tblCompanyType");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.tblCompanies)
                    .HasForeignKey(d => d.CountryID)
                    .HasConstraintName("FK_tblCompanies_tblCountries");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.tblCompanies)
                    .HasForeignKey(d => d.DivisionID)
                    .HasConstraintName("FK_tblCompanies_tblDivisions");

                entity.HasOne(d => d.MainContact)
                    .WithMany(p => p.tblCompaniesMainContact)
                    .HasForeignKey(d => d.MainContactID)
                    .HasConstraintName("FK_tblCompanies_MainContact");
            });

            modelBuilder.Entity<tblCompanyAccreditationAttachments>(entity =>
            {
                entity.Property(e => e.CompanyAccreditationAttachmentID).ValueGeneratedNever();

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblCompanyAccreditationAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAccreditationAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblCompanyAccreditationAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblCompanyAccreditationAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.CompanyAccreditation)
                    .WithMany(p => p.tblCompanyAccreditationAttachments)
                    .HasForeignKey(d => d.CompanyAccreditationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAccreditationAttachments_tblCompanyAccreditations");
            });

            modelBuilder.Entity<tblCompanyAccreditationNotifications>(entity =>
            {
                entity.Property(e => e.CompanyAccreditationNotificationID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.CompanyAccreditation)
                    .WithMany(p => p.tblCompanyAccreditationNotifications)
                    .HasForeignKey(d => d.CompanyAccreditationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAccreditationNotifications_tblCompanyAccreditations");

                entity.HasOne(d => d.CompanyAccreditationNotification)
                    .WithOne(p => p.tblCompanyAccreditationNotifications)
                    .HasForeignKey<tblCompanyAccreditationNotifications>(d => d.CompanyAccreditationNotificationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAccreditationNotifications_tblNotifications");
            });

            modelBuilder.Entity<tblCompanyAccreditations>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.LicenceNumber).IsUnicode(false);

                entity.HasOne(d => d.AccreditationLicencing)
                    .WithMany(p => p.tblCompanyAccreditations)
                    .HasForeignKey(d => d.AccreditationLicencingID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAccreditations_tblAccreditationLicencing");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyAccreditations)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAccreditations_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyAddresses>(entity =>
            {
                entity.Property(e => e.CompanyAddressID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.tblCompanyAddresses)
                    .HasForeignKey(d => d.AddressID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAddresses_tblAddresses");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.tblCompanyAddresses)
                    .HasForeignKey(d => d.AddressTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAddresses_tblAddressTypes");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyAddresses)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAddresses_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyAreasOfOperation>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.AreaOfOperation)
                    .WithMany(p => p.tblCompanyAreasOfOperation)
                    .HasForeignKey(d => d.AreaOfOperationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAreasOfOperation_tblAreasOfOperation");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyAreasOfOperation)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAreasOfOperation_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyAttachments>(entity =>
            {
                entity.Property(e => e.CompanyAttachmentID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblCompanyAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblCompanyAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyAttachments)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyAttachments_tblCompanies");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblCompanyAttachments)
                    .HasForeignKey(d => d.ProjectID)
                    .HasConstraintName("FK_tblCompanyAttachments_tblProjects");
            });

            modelBuilder.Entity<tblCompanyCapabilities>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Capability)
                    .WithMany(p => p.tblCompanyCapabilities)
                    .HasForeignKey(d => d.CapabilityID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyCapabilities_tblCapabilities");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyCapabilities)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyCapabilities_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyComments>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyComments)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyComments_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyDueDiligence>(entity =>
            {
                entity.Property(e => e.Answers).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyDueDiligence)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyDueDiligence_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyIndividuals>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyIndividuals)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyIndividuals_tblCompanies");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblCompanyIndividuals)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyIndividuals_tblIndividuals");
            });

            modelBuilder.Entity<tblCompanyInsurances>(entity =>
            {
                entity.Property(e => e.CompanyInsuranceID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyInsurances)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyInsurances_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyIntegrations>(entity =>
            {
                entity.Property(e => e.CompanyIntegrationID).ValueGeneratedNever();

                entity.Property(e => e.IntegratedSystem).IsUnicode(false);

                entity.Property(e => e.Key).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyIntegrations)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyIntegrations_tblCompanies");
            });

            modelBuilder.Entity<tblCompanyOnboarding>(entity =>
            {
                entity.Property(e => e.CompanyOnboardingID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyOnboarding)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboarding_tblCompanies");

                entity.HasOne(d => d.CompanyOnboardingStatus)
                    .WithMany(p => p.tblCompanyOnboarding)
                    .HasForeignKey(d => d.CompanyOnboardingStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboarding_tblCompanyOnboardingStatuses");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.tblCompanyOnboarding)
                    .HasForeignKey(d => d.ContractID)
                    .HasConstraintName("FK_tblCompanyOnboarding_tblContracts");

                entity.HasOne(d => d.EOI)
                    .WithMany(p => p.tblCompanyOnboarding)
                    .HasForeignKey(d => d.EOIID)
                    .HasConstraintName("FK_tblCompanyOnboarding_tblEOI");
            });

            modelBuilder.Entity<tblCompanyOnboardingAttachments>(entity =>
            {
                entity.Property(e => e.CompanyOnboardingAttachmentID).ValueGeneratedNever();

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblCompanyOnboardingAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblCompanyOnboardingAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.CompanyOnboarding)
                    .WithMany(p => p.tblCompanyOnboardingAttachments)
                    .HasForeignKey(d => d.CompanyOnboardingID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingAttachments_tblCompanyOnboarding");
            });

            modelBuilder.Entity<tblCompanyOnboardingIRStatuses>(entity =>
            {
                entity.Property(e => e.CompanyOnboardingIRStatusID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.CompanyOnboarding)
                    .WithMany(p => p.tblCompanyOnboardingIRStatuses)
                    .HasForeignKey(d => d.CompanyOnboardingID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingIRStatuses_tblCompanyOnboarding");

                entity.HasOne(d => d.IRStatus)
                    .WithMany(p => p.tblCompanyOnboardingIRStatuses)
                    .HasForeignKey(d => d.IRStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingIRStatuses_tblIRStatuses");
            });

            modelBuilder.Entity<tblCompanyOnboardingOperStatuses>(entity =>
            {
                entity.Property(e => e.CompanyOnboardingOperStatusID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.CompanyOnboarding)
                    .WithMany(p => p.tblCompanyOnboardingOperStatuses)
                    .HasForeignKey(d => d.CompanyOnboardingID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingOperStatuses_tblCompanyOnboarding");

                entity.HasOne(d => d.OperStatus)
                    .WithMany(p => p.tblCompanyOnboardingOperStatuses)
                    .HasForeignKey(d => d.OperStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingOperStatuses_tblOperStatuses");
            });

            modelBuilder.Entity<tblCompanyOnboardingSHEQStatuses>(entity =>
            {
                entity.Property(e => e.CompanyOnboardingSHEQStatusID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.CompanyOnboarding)
                    .WithMany(p => p.tblCompanyOnboardingSHEQStatuses)
                    .HasForeignKey(d => d.CompanyOnboardingID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingSHEQStatuses_tblCompanyOnboarding");

                entity.HasOne(d => d.SHEQStatus)
                    .WithMany(p => p.tblCompanyOnboardingSHEQStatuses)
                    .HasForeignKey(d => d.SHEQStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyOnboardingSHEQStatuses_tblSHEQStatuses");
            });

            modelBuilder.Entity<tblCompanyOnboardingStatuses>(entity =>
            {
                entity.Property(e => e.CompanyOnboardingStatusID).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblCompanyPlants>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanyPlants)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyPlants_tblCompanies");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.tblCompanyPlants)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyPlants_tblPlants");
            });

            modelBuilder.Entity<tblCompanySubContractors>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanySubContractorsCompany)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanySubContractors_tblCompanies");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.tblCompanySubContractors)
                    .HasForeignKey(d => d.ContractID)
                    .HasConstraintName("FK_tblCompanySubContractors_tblContracts");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblCompanySubContractors)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanySubContractors_tblProjects");

                entity.HasOne(d => d.SubContractor)
                    .WithMany(p => p.tblCompanySubContractorsSubContractor)
                    .HasForeignKey(d => d.SubContractorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanySubContractors_tblCompanies1");
            });

            modelBuilder.Entity<tblCompanySubStatuses>(entity =>
            {
                entity.Property(e => e.CompanySubStatusID).ValueGeneratedNever();

                entity.Property(e => e.SubStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblCompanySuspensions>(entity =>
            {
                entity.Property(e => e.CompanySuspensionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblCompanySuspensions)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanySuspensions_tblCompanies");

                entity.HasOne(d => d.Suspension)
                    .WithMany(p => p.tblCompanySuspensions)
                    .HasForeignKey(d => d.SuspensionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanySuspensions_tblSuspensions");
            });

            modelBuilder.Entity<tblCompanyTypes>(entity =>
            {
                entity.Property(e => e.CompanyTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblCompetencies>(entity =>
            {
                entity.Property(e => e.CompetencyID).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.CompetencyType)
                    .WithMany(p => p.tblCompetencies)
                    .HasForeignKey(d => d.CompetencyTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencies_tblCompetencyTypes");

                entity.HasOne(d => d.ParentCompetency)
                    .WithMany(p => p.InverseParentCompetency)
                    .HasForeignKey(d => d.ParentCompetencyID)
                    .HasConstraintName("FK_tblCompetencies_tblCompetencies");
            });

            modelBuilder.Entity<tblCompetencyIntegrations>(entity =>
            {
                entity.Property(e => e.CompetencyIntegrationID).ValueGeneratedNever();

                entity.Property(e => e.IntegratedSystem).IsUnicode(false);

                entity.Property(e => e.Key).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblCompetencyIntegrations)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyIntegrations_tblCompetencies");
            });

            modelBuilder.Entity<tblCompetencyNotifications>(entity =>
            {
                entity.Property(e => e.CompetencyNotificationID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblCompetencyNotifications)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyNotifications_tblCompetencies");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.tblCompetencyNotifications)
                    .HasForeignKey(d => d.NotificationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyNotifications_tblNotifications");
            });

            modelBuilder.Entity<tblCompetencyScores>(entity =>
            {
                entity.Property(e => e.CompetencyScoreID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblCompetencyScores)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyScores_tblCompetencies");

                entity.HasOne(d => d.ScoreType)
                    .WithMany(p => p.tblCompetencyScores)
                    .HasForeignKey(d => d.ScoreTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyScores_tblScoreTypes");
            });

            modelBuilder.Entity<tblCompetencyToJurisdiction>(entity =>
            {
                entity.Property(e => e.CompetencyToJurisdictionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblCompetencyToJurisdiction)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyToJurisdiction_tblCompetencies");

                entity.HasOne(d => d.Jurisdiction)
                    .WithMany(p => p.tblCompetencyToJurisdiction)
                    .HasForeignKey(d => d.JurisdictionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyToJurisdiction_tblJurisdictions");
            });

            modelBuilder.Entity<tblCompetencyToRCGroup>(entity =>
            {
                entity.Property(e => e.CompetencyToRCGroupID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblCompetencyToRCGroup)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyToRCGroup_tblCompetencies");

                entity.HasOne(d => d.RCGroup)
                    .WithMany(p => p.tblCompetencyToRCGroup)
                    .HasForeignKey(d => d.RCGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompetencyToRCGroup_tblRCGroups");
            });

            modelBuilder.Entity<tblCompetencyTypes>(entity =>
            {
                entity.Property(e => e.CompetencyTypeID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblComplianceCompetencyGroupList>(entity =>
            {
                entity.Property(e => e.ComplianceCompetencyGroupListID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tblComplianceCompetencyGroups>(entity =>
            {
                entity.Property(e => e.ComplianceCompetencyGroupID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tblContractAttachments>(entity =>
            {
                entity.Property(e => e.ContractAttachmentID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblContractAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblContractAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.tblContractAttachments)
                    .HasForeignKey(d => d.ContractID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblContractAttachments_tblContracts");
            });

            modelBuilder.Entity<tblContractIntegrations>(entity =>
            {
                entity.Property(e => e.ContractIntegrationID).ValueGeneratedNever();

                entity.Property(e => e.IntegratedSystem).IsUnicode(false);

                entity.Property(e => e.Key).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.tblContractIntegrations)
                    .HasForeignKey(d => d.ContractID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblContractIntegrations_tblContracts");
            });

            modelBuilder.Entity<tblContractProjects>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.tblContractProjects)
                    .HasForeignKey(d => d.ContractID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblContractProjects_tblContracts");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblContractProjects)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblContractProjects_tblProjects");
            });

            modelBuilder.Entity<tblContracts>(entity =>
            {
                entity.Property(e => e.ContractName).IsUnicode(false);

                entity.Property(e => e.ContractNo).IsUnicode(false);

                entity.Property(e => e.ContractValue).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.PaymentTerm).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblContracts)
                    .HasForeignKey(d => d.CompanyID)
                    .HasConstraintName("FK_tblContracts_tblCompanies");

                entity.HasOne(d => d.ContractStatus)
                    .WithMany(p => p.tblContracts)
                    .HasForeignKey(d => d.ContractStatusID)
                    .HasConstraintName("FK_tblContracts_tblContractStatuses");

                entity.HasOne(d => d.ContractSubStatus)
                    .WithMany(p => p.tblContracts)
                    .HasForeignKey(d => d.ContractSubStatusID)
                    .HasConstraintName("FK_tblContracts_tblContractSubStatuses");

                entity.HasOne(d => d.ContractType)
                    .WithMany(p => p.tblContracts)
                    .HasForeignKey(d => d.ContractTypeID)
                    .HasConstraintName("FK_tblContracts_tblContractTypes");

                entity.HasOne(d => d.ParentContract)
                    .WithMany(p => p.InverseParentContract)
                    .HasForeignKey(d => d.ParentContractID)
                    .HasConstraintName("FK_tblContracts_tblContracts");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.tblContracts)
                    .HasForeignKey(d => d.PrincipalID)
                    .HasConstraintName("FK_tblContracts_tblIndividuals");
            });

            modelBuilder.Entity<tblContractStatuses>(entity =>
            {
                entity.Property(e => e.ContractStatusID).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblContractSubStatuses>(entity =>
            {
                entity.Property(e => e.ContractSubStatusID).ValueGeneratedNever();

                entity.Property(e => e.SubStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblContractTypes>(entity =>
            {
                entity.Property(e => e.ContractTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblCountries>(entity =>
            {
                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CountryCode).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tblDefaultProjectRoles>(entity =>
            {
                entity.Property(e => e.DefaultProjectRoleID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblDefaultProjectRoles)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDefaultProjectRoles_tblCompanies");

                entity.HasOne(d => d.ProjectRole)
                    .WithMany(p => p.tblDefaultProjectRoles)
                    .HasForeignKey(d => d.ProjectRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDefaultProjectRoles_tblProjectRoles");
            });

            modelBuilder.Entity<tblDivisionBranding>(entity =>
            {
                entity.Property(e => e.BrandingName).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tblDivisions>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tblEOI>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblEOI)
                    .HasForeignKey(d => d.ProjectID)
                    .HasConstraintName("FK_tblEOI_tblProjects");
            });

            modelBuilder.Entity<tblEventLogs>(entity =>
            {
                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.FieldGroup).IsUnicode(false);

                entity.Property(e => e.FieldName).IsUnicode(false);

                entity.Property(e => e.NewValue).IsUnicode(false);

                entity.Property(e => e.OldValue).IsUnicode(false);

                entity.Property(e => e.PageName).IsUnicode(false);
            });

            modelBuilder.Entity<tblEvidenceLevel>(entity =>
            {
                entity.Property(e => e.EvidenceLevelID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.LevelName).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividualAddresses>(entity =>
            {
                entity.Property(e => e.IndividualAddressID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.tblIndividualAddresses)
                    .HasForeignKey(d => d.AddressID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualAddresses_tblAddresses");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.tblIndividualAddresses)
                    .HasForeignKey(d => d.AddressTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualAddresses_tblAddressTypes");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualAddresses)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualAddresses_tblIndividuals");
            });

            modelBuilder.Entity<tblIndividualAttachments>(entity =>
            {
                entity.Property(e => e.IndividualAttachmentID).ValueGeneratedNever();

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblIndividualAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblIndividualAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualAttachments)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualAttachments_tblIndividuals");
            });

            modelBuilder.Entity<tblIndividualComments>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualComments)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualComments_tblIndividuals");
            });

            modelBuilder.Entity<tblIndividualCompetencies>(entity =>
            {
                entity.Property(e => e.IndividualCompetencyID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.EvidenceNumber).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblIndividualCompetencies)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualCompetencies_tblCompetencies");

                entity.HasOne(d => d.EvidenceLevel)
                    .WithMany(p => p.tblIndividualCompetencies)
                    .HasForeignKey(d => d.EvidenceLevelID)
                    .HasConstraintName("FK_tblIndividualCompetencies_tblEvidenceLevel");

                entity.HasOne(d => d.IndividualCompetency)
                    .WithOne(p => p.InverseIndividualCompetency)
                    .HasForeignKey<tblIndividualCompetencies>(d => d.IndividualCompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualCompetencies_tblIndividualCompetencies");

                entity.HasOne(d => d.IndividualCompetencySubStatus)
                    .WithMany(p => p.tblIndividualCompetencies)
                    .HasForeignKey(d => d.IndividualCompetencySubStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualCompetencies_tblIndividualCompetencySubStatuses");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualCompetencies)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualCompetencies_tblIndividuals");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.tblIndividualCompetencies)
                    .HasForeignKey(d => d.ProviderID)
                    .HasConstraintName("FK_tblIndividualCompetencies_tblCompanies");
            });

            modelBuilder.Entity<tblIndividualCompetencyAttachments>(entity =>
            {
                entity.Property(e => e.IndividualCompetencyAttachmentID).ValueGeneratedNever();

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblIndividualCompetencyAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualCompetencyAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblIndividualCompetencyAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblIndividualCompetencyAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.IndividualCompetency)
                    .WithMany(p => p.tblIndividualCompetencyAttachments)
                    .HasForeignKey(d => d.IndividualCompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualCompetencyAttachments_tblIndividualCompetencies");
            });

            modelBuilder.Entity<tblIndividualCompetencySubStatuses>(entity =>
            {
                entity.Property(e => e.IndividualCompetencySubStatusID).ValueGeneratedNever();

                entity.Property(e => e.SubStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividualIDCards>(entity =>
            {
                entity.Property(e => e.UserName).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblIndividualIDCards)
                    .HasForeignKey(d => d.CompanyID)
                    .HasConstraintName("FK_tblIndividualIDCards_tblCompanies");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualIDCards)
                    .HasForeignKey(d => d.IndividualID)
                    .HasConstraintName("FK_tblIndividualIDCards_tblIndividuals");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblIndividualIDCards)
                    .HasForeignKey(d => d.ProjectID)
                    .HasConstraintName("FK_tblIndividualIDCards_tblProjects");
            });

            modelBuilder.Entity<tblIndividualIndividual>(entity =>
            {
                entity.Property(e => e.IndividualIndividualID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.MainIndividual)
                    .WithMany(p => p.tblIndividualIndividualMainIndividual)
                    .HasForeignKey(d => d.MainIndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualIndividual_tblIndividuals");

                entity.HasOne(d => d.RelatedIndividual)
                    .WithMany(p => p.tblIndividualIndividualRelatedIndividual)
                    .HasForeignKey(d => d.RelatedIndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualIndividual_tblIndividuals1");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.tblIndividualIndividual)
                    .HasForeignKey(d => d.RelationshipID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualIndividual_tblIndividualIndividualRelations");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.tblIndividualIndividual)
                    .HasForeignKey(d => d.RelationshipTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualIndividual_tblIndividualRelationshipTypes");
            });

            modelBuilder.Entity<tblIndividualIndividualRelations>(entity =>
            {
                entity.Property(e => e.IndividualIndividualRelationID).ValueGeneratedNever();

                entity.Property(e => e.Relation).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividualProjectRoles>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualProjectRoles)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualProjectRoles_tblIndividuals");

                entity.HasOne(d => d.ProjectRole)
                    .WithMany(p => p.tblIndividualProjectRoles)
                    .HasForeignKey(d => d.ProjectRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualProjectRoles_tblProjectRoles");
            });

            modelBuilder.Entity<tblIndividualProjects>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblIndividualProjects)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualProjects_tblCompanies");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualProjects)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualProjects_tblIndividuals");

                entity.HasOne(d => d.IndividualProjectStatus)
                    .WithMany(p => p.tblIndividualProjects)
                    .HasForeignKey(d => d.IndividualProjectStatusID)
                    .HasConstraintName("FK_tblIndividualProjects_tblIndividualProjectStatuses");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblIndividualProjects)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualProjects_tblProjects");
            });

            modelBuilder.Entity<tblIndividualProjectStatuses>(entity =>
            {
                entity.Property(e => e.IndividualProjectStatusID).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividualRelationshipTypes>(entity =>
            {
                entity.Property(e => e.IndividualRelationshipTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividuals>(entity =>
            {
                entity.Property(e => e.IndividualID).ValueGeneratedOnAdd();

                entity.Property(e => e.EMailAddress).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.OtherName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.PreferredName).IsUnicode(false);

                entity.Property(e => e.VentiaEmployeeID).IsUnicode(false);

                entity.HasOne(d => d.Individual)
                    .WithOne(p => p.InverseIndividual)
                    .HasForeignKey<tblIndividuals>(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividuals_tblIndividuals");

                entity.HasOne(d => d.IndividualStatus)
                    .WithMany(p => p.tblIndividuals)
                    .HasForeignKey(d => d.IndividualStatusID)
                    .HasConstraintName("FK_tblIndividuals_tblIndividualStatuses");

                entity.HasOne(d => d.IndividualSubStatus)
                    .WithMany(p => p.tblIndividuals)
                    .HasForeignKey(d => d.IndividualSubStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividuals_tblIndividualSubStatuses");

                entity.HasOne(d => d.IndividualType)
                    .WithMany(p => p.tblIndividuals)
                    .HasForeignKey(d => d.IndividualTypeID)
                    .HasConstraintName("FK_tblIndividuals_tblIndividualTypes");
            });

            modelBuilder.Entity<tblIndividualStatuses>(entity =>
            {
                entity.Property(e => e.IndividualStatusID).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividualSubStatuses>(entity =>
            {
                entity.Property(e => e.IndividualSubStatusID).ValueGeneratedNever();

                entity.Property(e => e.SubStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblIndividualSuspensions>(entity =>
            {
                entity.Property(e => e.IndividualSuspensionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblIndividualSuspensions)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualSuspensions_tblIndividuals");

                entity.HasOne(d => d.Suspension)
                    .WithMany(p => p.tblIndividualSuspensions)
                    .HasForeignKey(d => d.SuspensionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIndividualSuspensions_tblSuspensions");
            });

            modelBuilder.Entity<tblIndividualTypes>(entity =>
            {
                entity.Property(e => e.IndividualTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblInsuranceAttachments>(entity =>
            {
                entity.Property(e => e.InsuranceAttachmentID).ValueGeneratedNever();

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblInsuranceAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInsuranceAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblInsuranceAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblInsuranceAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.tblInsuranceAttachments)
                    .HasForeignKey(d => d.InsuranceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInsuranceAttachments_tblInsurances");
            });

            modelBuilder.Entity<tblInsuranceNotifications>(entity =>
            {
                entity.Property(e => e.InsuranceNotificationID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.tblInsuranceNotifications)
                    .HasForeignKey(d => d.InsuranceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInsuranceNotifications_tblInsurances");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.tblInsuranceNotifications)
                    .HasForeignKey(d => d.NotificationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInsuranceNotifications_tblNotifications");
            });

            modelBuilder.Entity<tblInsurances>(entity =>
            {
                entity.Property(e => e.AmountCover).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.PolicyNumber).IsUnicode(false);

                entity.Property(e => e.ProviderName).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblInsurances)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInsurances_tblCompanies");

                entity.HasOne(d => d.InsuranceSubStatus)
                    .WithMany(p => p.tblInsurances)
                    .HasForeignKey(d => d.InsuranceSubStatusID)
                    .HasConstraintName("FK_tblInsurances_tblInsuranceSubStatuses");

                entity.HasOne(d => d.InsuranceType)
                    .WithMany(p => p.tblInsurances)
                    .HasForeignKey(d => d.InsuranceTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInsurances_tblInsuranceTypes");
            });

            modelBuilder.Entity<tblInsuranceSubStatuses>(entity =>
            {
                entity.Property(e => e.InsuranceSubStatusID).ValueGeneratedNever();

                entity.Property(e => e.SubStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblInsuranceTypes>(entity =>
            {
                entity.Property(e => e.InsuranceTypeID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblIRStatuses>(entity =>
            {
                entity.Property(e => e.IRStatusID).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblJurisdictions>(entity =>
            {
                entity.Property(e => e.JurisdictionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.ParentJurisdiction)
                    .WithMany(p => p.InverseParentJurisdiction)
                    .HasForeignKey(d => d.ParentJurisdictionID)
                    .HasConstraintName("FK_tblJurisdictions_tblJurisdictions");
            });

            modelBuilder.Entity<tblLOBs>(entity =>
            {
                entity.Property(e => e.LOBID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.LOB).IsUnicode(false);

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.tblLOBs)
                    .HasForeignKey(d => d.DivisionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLOBs_tblDivisions");
            });

            modelBuilder.Entity<tblNotificationCategories>(entity =>
            {
                entity.Property(e => e.NotificationCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<tblNotificationListIndividuals>(entity =>
            {
                entity.Property(e => e.NotificationListIndividualID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblNotificationListIndividuals)
                    .HasForeignKey(d => d.IndividualID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblNotificationListIndividuals_tblIndividuals");
            });

            modelBuilder.Entity<tblNotificationLists>(entity =>
            {
                entity.Property(e => e.NotificationListID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tblNotifications>(entity =>
            {
                entity.Property(e => e.NotificationID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.tblNotifications)
                    .HasForeignKey(d => d.IndividualID)
                    .HasConstraintName("FK_tblNotifications_tblIndividuals");

                entity.HasOne(d => d.NotificationList)
                    .WithMany(p => p.tblNotifications)
                    .HasForeignKey(d => d.NotificationListID)
                    .HasConstraintName("FK_tblNotifications_tblNotificationLists");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.tblNotifications)
                    .HasForeignKey(d => d.NotificationTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblNotifications_tblNotificationTypes");
            });

            modelBuilder.Entity<tblNotificationTypes>(entity =>
            {
                entity.Property(e => e.NotificationTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.NotificationCategory)
                    .WithMany(p => p.tblNotificationTypes)
                    .HasForeignKey(d => d.NotificationCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblNotificationTypes_tblNotificationCategories");
            });

            modelBuilder.Entity<tblOperStatuses>(entity =>
            {
                entity.Property(e => e.OperStatusID).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblPlantAttachments>(entity =>
            {
                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblPlantAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblPlantAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblPlantAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.tblPlantAttachments)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantAttachments_tblPlants");
            });

            modelBuilder.Entity<tblPlantComments>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.tblPlantComments)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantComments_tblPlants");
            });

            modelBuilder.Entity<tblPlantInsurances>(entity =>
            {
                entity.Property(e => e.PlantInsuranceID).ValueGeneratedNever();

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.tblPlantInsurances)
                    .HasForeignKey(d => d.InsuranceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantInsurances_tblInsurances");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.tblPlantInsurances)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantInsurances_tblPlants");
            });

            modelBuilder.Entity<tblPlants>(entity =>
            {
                entity.Property(e => e.BaseLocation).IsUnicode(false);

                entity.Property(e => e.CurrentLocation).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.PlantDescription).IsUnicode(false);

                entity.Property(e => e.PlantMake).IsUnicode(false);

                entity.Property(e => e.PlantModel).IsUnicode(false);

                entity.Property(e => e.PlantName).IsUnicode(false);

                entity.Property(e => e.RegistrationNumber).IsUnicode(false);

                entity.Property(e => e.VIN).IsUnicode(false);

                entity.Property(e => e.YearOfManufacture).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblPlants)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlants_tblCompanies");

                entity.HasOne(d => d.PlantType)
                    .WithMany(p => p.tblPlants)
                    .HasForeignKey(d => d.PlantTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlants_tblPlantTypes");
            });

            modelBuilder.Entity<tblPlantSuspensions>(entity =>
            {
                entity.Property(e => e.PlantSuspensionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.tblPlantSuspensions)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantSuspensions_tblPlants");

                entity.HasOne(d => d.Suspension)
                    .WithMany(p => p.tblPlantSuspensions)
                    .HasForeignKey(d => d.SuspensionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlantSuspensions_tblSuspensions");
            });

            modelBuilder.Entity<tblPlantTypes>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.TypeDescription).IsUnicode(false);
            });

            modelBuilder.Entity<tblProjectAddresses>(entity =>
            {
                entity.Property(e => e.ProjectAddressID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.tblProjectAddresses)
                    .HasForeignKey(d => d.AddressID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectAddresses_tblAddresses");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.tblProjectAddresses)
                    .HasForeignKey(d => d.AddressTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectAddresses_tblAddressTypes");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblProjectAddresses)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectAddresses_tblProjects");
            });

            modelBuilder.Entity<tblProjectAttachments>(entity =>
            {
                entity.Property(e => e.ProjectAttachmentID).ValueGeneratedNever();

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.tblProjectAttachments)
                    .HasForeignKey(d => d.AttachmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectAttachments_tblAttachments");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblProjectAttachments)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblProjectAttachments_tblAttachmentTypes");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblProjectAttachments)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectAttachments_tblProjects");
            });

            modelBuilder.Entity<tblProjectCodes>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.ProjectCode).IsUnicode(false);
            });

            modelBuilder.Entity<tblProjectIntegrations>(entity =>
            {
                entity.Property(e => e.ProjectIntegrationID).ValueGeneratedNever();

                entity.Property(e => e.IntegratedSystem).IsUnicode(false);

                entity.Property(e => e.Key).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblProjectIntegrations)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectIntegrations_tblProjects");
            });

            modelBuilder.Entity<tblProjectJurisdictions>(entity =>
            {
                entity.Property(e => e.ProjectJurisdictionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Jurisdiction)
                    .WithMany(p => p.tblProjectJurisdictions)
                    .HasForeignKey(d => d.JurisdictionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectJurisdictions_tblJurisdictions");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblProjectJurisdictions)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectJurisdictions_tblProjects");
            });

            modelBuilder.Entity<tblProjectNotifications>(entity =>
            {
                entity.Property(e => e.ProjectNotificationID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.tblProjectNotifications)
                    .HasForeignKey(d => d.NotificationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectNotifications_tblNotifications");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblProjectNotifications)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectNotifications_tblProjects");
            });

            modelBuilder.Entity<tblProjectRoles>(entity =>
            {
                entity.Property(e => e.ProjectRoleID).ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblProjectRoles)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoles_tblProjects");
            });

            modelBuilder.Entity<tblProjectRoleScores>(entity =>
            {
                entity.Property(e => e.ProjectRoleScoresID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.ProjectRole)
                    .WithMany(p => p.tblProjectRoleScores)
                    .HasForeignKey(d => d.ProjectRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoleScores_tblProjectRoles");

                entity.HasOne(d => d.ScoreType)
                    .WithMany(p => p.tblProjectRoleScores)
                    .HasForeignKey(d => d.ScoreTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoleScores_tblScoreTypes");
            });

            modelBuilder.Entity<tblProjectRoleToCompetency>(entity =>
            {
                entity.Property(e => e.ProjectRoleToCompetencyID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblProjectRoleToCompetency)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoleToCompetency_tblCompetencies");

                entity.HasOne(d => d.MinimalEvidenceLevel)
                    .WithMany(p => p.tblProjectRoleToCompetency)
                    .HasForeignKey(d => d.MinimalEvidenceLevelID)
                    .HasConstraintName("FK_tblProjectRoleToCompetency_tblEvidenceLevel");

                entity.HasOne(d => d.ProjectRole)
                    .WithMany(p => p.tblProjectRoleToCompetency)
                    .HasForeignKey(d => d.ProjectRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoleToCompetency_tblProjectRoles");
            });

            modelBuilder.Entity<tblProjectRoleToRoleLibrary>(entity =>
            {
                entity.Property(e => e.ProjectRoleToRoleID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.ProjectRole)
                    .WithMany(p => p.tblProjectRoleToRoleLibrary)
                    .HasForeignKey(d => d.ProjectRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoleToRoleLibrary_tblProjectRoles");

                entity.HasOne(d => d.RoleLibrary)
                    .WithMany(p => p.tblProjectRoleToRoleLibrary)
                    .HasForeignKey(d => d.RoleLibraryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProjectRoleToRoleLibrary_tblRoleLibrary");
            });

            modelBuilder.Entity<tblProjects>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.FacsimileNumber).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.OrganisationCode).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.ProjectManager).IsUnicode(false);

                entity.Property(e => e.ProjectManagerNumber).IsUnicode(false);

                entity.Property(e => e.ProjectName).IsUnicode(false);

                entity.Property(e => e.ProjectNumber).IsUnicode(false);

                entity.Property(e => e.ProjectStatus).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);

                entity.HasOne(d => d.LOB)
                    .WithMany(p => p.tblProjects)
                    .HasForeignKey(d => d.LOBID)
                    .HasConstraintName("FK_tblProjects_tblLOBs");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.tblProjects)
                    .HasForeignKey(d => d.ManagerID)
                    .HasConstraintName("FK_tblProjects_tblIndividuals");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.tblProjects)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("FK_tblProjects_tblCompanies");

                entity.HasOne(d => d.ProjectCode)
                    .WithMany(p => p.tblProjects)
                    .HasForeignKey(d => d.ProjectCodeID)
                    .HasConstraintName("FK_tblProjects_tblProjectCodes");

                entity.HasOne(d => d.ProjectSubStatus)
                    .WithMany(p => p.tblProjects)
                    .HasForeignKey(d => d.ProjectSubStatusID)
                    .HasConstraintName("FK_tblProjects_tblProjectSubStatuses");
            });

            modelBuilder.Entity<tblProjectStatuses>(entity =>
            {
                entity.Property(e => e.ProjectStatusID).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblProjectSubStatuses>(entity =>
            {
                entity.Property(e => e.ProjectSubStatusID).ValueGeneratedNever();

                entity.Property(e => e.SubStatus).IsUnicode(false);
            });

            modelBuilder.Entity<tblProviderSuspensions>(entity =>
            {
                entity.Property(e => e.ProviderSuspensionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.tblProviderSuspensions)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProviderSuspensions_tblCompanies");

                entity.HasOne(d => d.Suspension)
                    .WithMany(p => p.tblProviderSuspensions)
                    .HasForeignKey(d => d.SuspensionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProviderSuspensions_tblSuspensions");
            });

            modelBuilder.Entity<tblRCGHierarchies>(entity =>
            {
                entity.Property(e => e.RCGHierarchyID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.ChildRCGNavigation)
                    .WithMany(p => p.tblRCGHierarchiesChildRCGNavigation)
                    .HasForeignKey(d => d.ChildRCG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRCGHierarchies_tblRCGroups1");

                entity.HasOne(d => d.ParentRCGNavigation)
                    .WithMany(p => p.tblRCGHierarchiesParentRCGNavigation)
                    .HasForeignKey(d => d.ParentRCG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRCGHierarchies_tblRCGroups");
            });

            modelBuilder.Entity<tblRCGroups>(entity =>
            {
                entity.Property(e => e.RCGroupID).ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tblRoleLibrary>(entity =>
            {
                entity.Property(e => e.RoleID).ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tblRoleToCompetency>(entity =>
            {
                entity.Property(e => e.RoleToCompetencyID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.tblRoleToCompetency)
                    .HasForeignKey(d => d.CompetencyID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRoleToCompetency_tblCompetencies");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.tblRoleToCompetency)
                    .HasForeignKey(d => d.RoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRoleToCompetency_tblRoleLibrary");
            });

            modelBuilder.Entity<tblRoleToGroup>(entity =>
            {
                entity.Property(e => e.RoleToRCGroupID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.RCGroup)
                    .WithMany(p => p.tblRoleToGroup)
                    .HasForeignKey(d => d.RCGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRoleToGroup_tblRCGroups");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.tblRoleToGroup)
                    .HasForeignKey(d => d.RoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRoleToGroup_tblRoleLibrary");
            });

            modelBuilder.Entity<tblRoleToRole>(entity =>
            {
                entity.Property(e => e.RoleToRoleID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.ContainedRole)
                    .WithMany(p => p.tblRoleToRoleContainedRole)
                    .HasForeignKey(d => d.ContainedRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRoleToRole_tblRoleLibrary");

                entity.HasOne(d => d.ParentRole)
                    .WithMany(p => p.tblRoleToRoleParentRole)
                    .HasForeignKey(d => d.ParentRoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRoleToRole_tblRoleLibrary1");
            });

            modelBuilder.Entity<tblScoreTypes>(entity =>
            {
                entity.Property(e => e.ScoreTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblSHEQStatuses>(entity =>
            {
                entity.Property(e => e.SHEQStatusID).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblStates>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.tblStates)
                    .HasForeignKey(d => d.CountryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblStates_tblCountries");
            });

            modelBuilder.Entity<tblSuspensionNotes>(entity =>
            {
                entity.Property(e => e.SuspensionNoteID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.tblSuspensionNotes)
                    .HasForeignKey(d => d.AttachmentTypeID)
                    .HasConstraintName("FK_tblSuspensionNotes_tblAttachmentTypes");

                entity.HasOne(d => d.Suspension)
                    .WithMany(p => p.tblSuspensionNotes)
                    .HasForeignKey(d => d.SuspensionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSuspensionNotes_tblSuspensions");
            });

            modelBuilder.Entity<tblSuspensionReasons>(entity =>
            {
                entity.Property(e => e.SuspensionReasonID).ValueGeneratedNever();

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<tblSuspensions>(entity =>
            {
                entity.Property(e => e.SuspensionID).ValueGeneratedNever();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.SuspendedCapability)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspendedCapabilityID)
                    .HasConstraintName("FK_tblSuspensions_tblCapabilities");

                entity.HasOne(d => d.SuspendedDivision)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspendedDivisionID)
                    .HasConstraintName("FK_tblSuspensions_tblDivisions");

                entity.HasOne(d => d.SuspendedLOB)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspendedLOBID)
                    .HasConstraintName("FK_tblSuspensions_tblLOBs");

                entity.HasOne(d => d.SuspendedProject)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspendedProjectID)
                    .HasConstraintName("FK_tblSuspensions_tblProjects");

                entity.HasOne(d => d.SuspendedProjectRole)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspendedProjectRoleID)
                    .HasConstraintName("FK_tblSuspensions_tblProjectRoles");

                entity.HasOne(d => d.SuspensionReason)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspensionReasonID)
                    .HasConstraintName("FK_tblSuspensions_tblSuspensionReasons");

                entity.HasOne(d => d.SuspensionStatus)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspensionStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSuspensions_tblSuspensionStatuses");

                entity.HasOne(d => d.SuspensionType)
                    .WithMany(p => p.tblSuspensions)
                    .HasForeignKey(d => d.SuspensionTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSuspensions_tblSuspensionTypes");
            });

            modelBuilder.Entity<tblSuspensionStatuses>(entity =>
            {
                entity.Property(e => e.SuspensionStatusID).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblSuspensionTypes>(entity =>
            {
                entity.Property(e => e.SuspensionTypeID).ValueGeneratedNever();

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<tblTrainingFields>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.TrainingField).IsUnicode(false);
            });

            modelBuilder.Entity<tblUserLevels>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.UserLevel).IsUnicode(false);
            });

            modelBuilder.Entity<tblUserMatrix>(entity =>
            {
                entity.Property(e => e.UserMatrixID).ValueGeneratedOnAdd();

                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Function).IsUnicode(false);
            });

            modelBuilder.Entity<tblUserProjects>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.tblUserProjects)
                    .HasForeignKey(d => d.ProjectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUserProjects_tblProjects");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.tblUserProjects)
                    .HasForeignKey(d => d.UserID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUserProjects_tblUsers");
            });

            modelBuilder.Entity<tblUsers>(entity =>
            {
                entity.Property(e => e.EditedBy).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.HasOne(d => d.UserLevel)
                    .WithMany(p => p.tblUsers)
                    .HasForeignKey(d => d.UserLevelID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsers_tblUserLevels");
            });

            modelBuilder.Entity<tblUserSessions>(entity =>
            {
                entity.Property(e => e.SessionAttribute).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.tblUserSessions)
                    .HasForeignKey(d => d.UserID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUserSessions_tblUsers");
            });
        }
    }
}

