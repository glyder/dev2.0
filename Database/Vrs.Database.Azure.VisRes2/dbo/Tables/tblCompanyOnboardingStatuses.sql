CREATE TABLE [dbo].[tblCompanyOnboardingStatuses] (
    [CompanyOnboardingStatusID] INT          NOT NULL,
    [Status]                    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblCompanyOnboardingStatuses] PRIMARY KEY CLUSTERED ([CompanyOnboardingStatusID] ASC)
);

