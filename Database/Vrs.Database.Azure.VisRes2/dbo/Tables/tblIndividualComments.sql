CREATE TABLE [dbo].[tblIndividualComments] (
    [IndividualCommentID] INT           IDENTITY (1, 1) NOT NULL,
    [IndividualID]        INT           NOT NULL,
    [CommentNo]           INT           NULL,
    [Comment]             VARCHAR (MAX) NULL,
    [AttachmentID]        INT           NULL,
    [FromDate]            DATETIME      NOT NULL,
    [EditedBy]            VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblIndividualComments] PRIMARY KEY CLUSTERED ([IndividualCommentID] ASC),
    CONSTRAINT [FK_tblIndividualComments_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);

