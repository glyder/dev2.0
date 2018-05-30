CREATE TABLE [dbo].[tblAttachmentCategoryObject] (
    [AttachmentCategoryObjectID] INT           NOT NULL,
    [AttachmentTypeCategoryID]   INT           NOT NULL,
    [ObjectName]                 VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_tblAttachmentCategoryObject] PRIMARY KEY CLUSTERED ([AttachmentCategoryObjectID] ASC),
    CONSTRAINT [FK_tblAttachmentCategoryObject_tblAttachmentTypeCategory] FOREIGN KEY ([AttachmentTypeCategoryID]) REFERENCES [dbo].[tblAttachmentTypeCategory] ([AttachmentTypeCategoryID])
);

