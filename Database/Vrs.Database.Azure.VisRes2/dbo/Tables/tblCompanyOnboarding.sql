CREATE TABLE [dbo].[tblCompanyOnboarding] (
    [CompanyOnboardingID]       INT           NOT NULL,
    [CompanyID]                 INT           NOT NULL,
    [EOIID]                     INT           NULL,
    [CompanyOnboardingStatusID] INT           NOT NULL,
    [ContractID]                INT           NULL,
    [FromDate]                  DATETIME      NOT NULL,
    [EditedBy]                  VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompanyOnboarding] PRIMARY KEY CLUSTERED ([CompanyOnboardingID] ASC),
    CONSTRAINT [FK_tblCompanyOnboarding_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanyOnboarding_tblCompanyOnboardingStatuses] FOREIGN KEY ([CompanyOnboardingStatusID]) REFERENCES [dbo].[tblCompanyOnboardingStatuses] ([CompanyOnboardingStatusID]),
    CONSTRAINT [FK_tblCompanyOnboarding_tblContracts] FOREIGN KEY ([ContractID]) REFERENCES [dbo].[tblContracts] ([ContractID]),
    CONSTRAINT [FK_tblCompanyOnboarding_tblEOI] FOREIGN KEY ([EOIID]) REFERENCES [dbo].[tblEOI] ([EOIID])
);

