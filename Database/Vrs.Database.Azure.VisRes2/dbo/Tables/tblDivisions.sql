CREATE TABLE [dbo].[tblDivisions] (
    [DivisionID]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (100) NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [BrandingID]  INT           NULL,
    [FromDate]    DATETIME      NULL,
    [EditedBy]    VARCHAR (150) NULL,
    CONSTRAINT [PK_tblDivision] PRIMARY KEY CLUSTERED ([DivisionID] ASC)
);

