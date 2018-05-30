CREATE TABLE [dbo].[tblCompanyOnboardingIRStatuses] (
    [CompanyOnboardingIRStatusID] INT           NOT NULL,
    [CompanyOnboardingID]         INT           NOT NULL,
    [IRStatusID]                  INT           NOT NULL,
    [EditedBy]                    VARCHAR (150) NOT NULL,
    [FromDate]                    DATETIME      NOT NULL,
    CONSTRAINT [PK_tblCompanyOnboardingIRStatuses] PRIMARY KEY CLUSTERED ([CompanyOnboardingIRStatusID] ASC),
    CONSTRAINT [FK_tblCompanyOnboardingIRStatuses_tblCompanyOnboarding] FOREIGN KEY ([CompanyOnboardingID]) REFERENCES [dbo].[tblCompanyOnboarding] ([CompanyOnboardingID]),
    CONSTRAINT [FK_tblCompanyOnboardingIRStatuses_tblIRStatuses] FOREIGN KEY ([IRStatusID]) REFERENCES [dbo].[tblIRStatuses] ([IRStatusID])
);



