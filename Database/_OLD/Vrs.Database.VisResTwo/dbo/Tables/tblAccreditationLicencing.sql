CREATE TABLE [dbo].[tblAccreditationLicencing] (
    [AccreditationLicencingID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]                     VARCHAR (255) NULL,
    [Description]              VARCHAR (MAX) NULL,
    [EditedBy]                 VARCHAR (150) NULL,
    [FromDate]                 DATETIME      NULL,
    CONSTRAINT [PK_tblAccreditationLicencing] PRIMARY KEY CLUSTERED ([AccreditationLicencingID] ASC)
);







