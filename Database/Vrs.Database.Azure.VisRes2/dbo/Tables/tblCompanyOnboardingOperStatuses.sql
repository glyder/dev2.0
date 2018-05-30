CREATE TABLE [dbo].[tblCompanyOnboardingOperStatuses] (
    [CompanyOnboardingOperStatusID] INT           NOT NULL,
    [CompanyOnboardingID]           INT           NOT NULL,
    [OperStatusID]                  INT           NOT NULL,
    [EditedBy]                      VARCHAR (150) NOT NULL,
    [FromDate]                      DATETIME      NOT NULL,
    CONSTRAINT [PK_tblCompanyOnboardingOperStatuses] PRIMARY KEY CLUSTERED ([CompanyOnboardingOperStatusID] ASC),
    CONSTRAINT [FK_tblCompanyOnboardingOperStatuses_tblCompanyOnboarding] FOREIGN KEY ([CompanyOnboardingID]) REFERENCES [dbo].[tblCompanyOnboarding] ([CompanyOnboardingID]),
    CONSTRAINT [FK_tblCompanyOnboardingOperStatuses_tblOperStatuses] FOREIGN KEY ([OperStatusID]) REFERENCES [dbo].[tblOperStatuses] ([OperStatusID])
);

