CREATE TABLE [dbo].[tblDivisionBranding] (
    [BrandingID]   INT           IDENTITY (1, 1) NOT NULL,
    [BrandingName] VARCHAR (100) NOT NULL,
    [EditedBy]     VARCHAR (150) NULL,
    [FromDate]     DATETIME      NULL,
    CONSTRAINT [PK_tblBranding] PRIMARY KEY CLUSTERED ([BrandingID] ASC)
);







