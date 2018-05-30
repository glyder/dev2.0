CREATE TABLE [dbo].[tblAttachmentTypes] (
    [AttachmentTypeID]         INT           IDENTITY (1, 1) NOT NULL,
    [Type]                     VARCHAR (100) NOT NULL,
    [AttachmentTypeCategoryID] INT           NOT NULL,
    [EditedBy]                 VARCHAR (150) NULL,
    [FromDate]                 DATETIME      NULL,
    [DownloadRestricted]       BIT           NOT NULL,
    [IsMandatory]              BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([AttachmentTypeID] ASC)
);



