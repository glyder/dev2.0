CREATE TABLE [dbo].[tblAttachmentTypeCategory] (
    [AttachmentTypeCategoryID] INT           IDENTITY (1, 1) NOT NULL,
    [Category]                 VARCHAR (100) NOT NULL,
    [EditedBy]                 VARCHAR (150) NULL,
    [FromDate]                 DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([AttachmentTypeCategoryID] ASC)
);

