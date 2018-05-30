CREATE TABLE [dbo].[tblCompanyOnboardingSHEQStatuses] (
    [CompanyOnboardingSHEQStatusID] INT           NOT NULL,
    [CompanyOnboardingID]           INT           NOT NULL,
    [SHEQStatusID]                  INT           NOT NULL,
    [EditedBy]                      VARCHAR (150) NOT NULL,
    [FromDate]                      DATETIME      NOT NULL,
    CONSTRAINT [PK_tblCompanyOnboardingSHEQStatuses] PRIMARY KEY CLUSTERED ([CompanyOnboardingSHEQStatusID] ASC),
    CONSTRAINT [FK_tblCompanyOnboardingSHEQStatuses_tblCompanyOnboarding] FOREIGN KEY ([CompanyOnboardingID]) REFERENCES [dbo].[tblCompanyOnboarding] ([CompanyOnboardingID]),
    CONSTRAINT [FK_tblCompanyOnboardingSHEQStatuses_tblSHEQStatuses] FOREIGN KEY ([SHEQStatusID]) REFERENCES [dbo].[tblSHEQStatuses] ([SHEQStatusID])
);

