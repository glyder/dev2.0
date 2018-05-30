CREATE TABLE [dbo].[tblAttachments] (
    [AttachmentID]     INT           NOT NULL,
    [Description]      VARCHAR (MAX) NULL,
    [Location]         VARCHAR (MAX) NOT NULL,
    [ContentType]      VARCHAR (255) NULL,
    [FromDate]         DATETIME      NOT NULL,
    [EditedBy]         VARCHAR (150) NOT NULL,
    [Name]             VARCHAR (250) NULL,
    [OriginalFileName] VARCHAR (250) NULL,
    [IsDeleted]        BIT           DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tblAttachments] PRIMARY KEY CLUSTERED ([AttachmentID] ASC)
);





