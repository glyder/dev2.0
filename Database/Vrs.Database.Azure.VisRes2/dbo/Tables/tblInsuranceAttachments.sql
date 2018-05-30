CREATE TABLE [dbo].[tblInsuranceAttachments] (
    [InsuranceAttachmentID] INT NOT NULL,
    [InsuranceID]           INT NOT NULL,
    [AttachmentID]          INT NOT NULL,
    [AttachmentTypeID]      INT NULL,
    CONSTRAINT [PK_tblInsuranceAttachments] PRIMARY KEY CLUSTERED ([InsuranceAttachmentID] ASC),
    CONSTRAINT [FK_tblInsuranceAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblInsuranceAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblInsuranceAttachments_tblInsurances] FOREIGN KEY ([InsuranceID]) REFERENCES [dbo].[tblInsurances] ([InsuranceID])
);



