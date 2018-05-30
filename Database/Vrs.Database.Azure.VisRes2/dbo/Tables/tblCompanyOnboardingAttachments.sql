CREATE TABLE [dbo].[tblCompanyOnboardingAttachments] (
    [CompanyOnboardingAttachmentID] INT NOT NULL,
    [CompanyOnboardingID]           INT NOT NULL,
    [AttachmentID]                  INT NOT NULL,
    [AttachmentTypeID]              INT NULL,
    CONSTRAINT [PK_tblCompanyOnboardingAttachments] PRIMARY KEY CLUSTERED ([CompanyOnboardingAttachmentID] ASC),
    CONSTRAINT [FK_tblCompanyOnboardingAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblCompanyOnboardingAttachments_tblCompanyOnboarding] FOREIGN KEY ([CompanyOnboardingID]) REFERENCES [dbo].[tblCompanyOnboarding] ([CompanyOnboardingID])
);



