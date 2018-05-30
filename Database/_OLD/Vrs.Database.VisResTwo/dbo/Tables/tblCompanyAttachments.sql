CREATE TABLE [dbo].[tblCompanyAttachments] (
    [CompanyAttachmentID] INT           NOT NULL,
    [CompanyID]           INT           NOT NULL,
    [AttachmentID]        INT           NOT NULL,
    [AttachmentTypeID]    INT           NOT NULL,
    [FromDate]            DATETIME      NOT NULL,
    [EditedBy]            VARCHAR (150) NOT NULL,
    [ProjectID]           INT           NULL,
    CONSTRAINT [PK_tblCompanyAttachments] PRIMARY KEY CLUSTERED ([CompanyAttachmentID] ASC),
    CONSTRAINT [FK_tblCompanyAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblCompanyAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblCompanyAttachments_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanyAttachments_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);







