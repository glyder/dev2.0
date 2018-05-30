CREATE TABLE [dbo].[tblProjectAttachments] (
    [ProjectAttachmentID] INT NOT NULL,
    [ProjectID]           INT NOT NULL,
    [AttachmentID]        INT NOT NULL,
    [AttachmentTypeID]    INT NULL,
    CONSTRAINT [PK_tblProjectAttachments] PRIMARY KEY CLUSTERED ([ProjectAttachmentID] ASC),
    CONSTRAINT [FK_tblProjectAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblProjectAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblProjectAttachments_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);



