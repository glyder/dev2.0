CREATE TABLE [dbo].[tblCompanyAccreditationAttachments] (
    [CompanyAccreditationAttachmentID] INT NOT NULL,
    [CompanyAccreditationID]           INT NOT NULL,
    [AttachmentID]                     INT NOT NULL,
    [AttachmentTypeID]                 INT NULL,
    CONSTRAINT [PK_tblCompanyAccreditationAttachments] PRIMARY KEY CLUSTERED ([CompanyAccreditationAttachmentID] ASC),
    CONSTRAINT [FK_tblCompanyAccreditationAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblCompanyAccreditationAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblCompanyAccreditationAttachments_tblCompanyAccreditations] FOREIGN KEY ([CompanyAccreditationID]) REFERENCES [dbo].[tblCompanyAccreditations] ([CompanyAccreditationID])
);

