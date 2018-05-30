CREATE TABLE [dbo].[tblIndividualIDCardAttachments] (
    [IndividualIDCardAttachmentID] INT           NOT NULL,
    [IndividualIDCardID]           INT           NOT NULL,
    [AttachmentID]                 INT           NOT NULL,
    [AttachmentTypeID]             INT           NULL,
    [FromDate]                     DATETIME      NOT NULL,
    [EditedBy]                     VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblIndividualIDCardAttachments] PRIMARY KEY CLUSTERED ([IndividualIDCardAttachmentID] ASC),
    CONSTRAINT [FK_tblIndividualIDCardAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblIndividualIDCardAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblIndividualIDCardAttachments_tblIndividualIDCards] FOREIGN KEY ([IndividualIDCardID]) REFERENCES [dbo].[tblIndividualIDCards] ([IndividalIDCardID])
);

