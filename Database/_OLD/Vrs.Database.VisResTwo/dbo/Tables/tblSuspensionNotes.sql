CREATE TABLE [dbo].[tblSuspensionNotes] (
    [SuspensionNoteID] INT           NOT NULL,
    [SuspensionID]     INT           NOT NULL,
    [NoteNo]           INT           NULL,
    [Note]             VARCHAR (MAX) NULL,
    [AttachmentID]     INT           NULL,
    [FromDate]         DATETIME      NOT NULL,
    [EditedBy]         VARCHAR (150) NOT NULL,
    [AttachmentTypeID] INT           NULL,
    CONSTRAINT [PK_tblSuspensionNotes] PRIMARY KEY CLUSTERED ([SuspensionNoteID] ASC),
    CONSTRAINT [FK_tblSuspensionNotes_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblSuspensionNotes_tblSuspensions] FOREIGN KEY ([SuspensionID]) REFERENCES [dbo].[tblSuspensions] ([SuspensionID])
);





