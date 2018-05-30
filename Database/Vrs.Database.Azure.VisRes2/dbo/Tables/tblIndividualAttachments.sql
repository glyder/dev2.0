CREATE TABLE [dbo].[tblIndividualAttachments] (
    [IndividualAttachmentID] INT NOT NULL,
    [IndividualID]           INT NOT NULL,
    [AttachmentID]           INT NOT NULL,
    [AttachmentTypeID]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IndividualAttachmentID] ASC),
    CONSTRAINT [FK_tblIndividualAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblIndividualAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblIndividualAttachments_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);



