CREATE TABLE [dbo].[tblCountries] (
    [CountryID]   INT           IDENTITY (1, 1) NOT NULL,
    [Country]     VARCHAR (255) NOT NULL,
    [EditedBy]    VARCHAR (150) NULL,
    [FromDate]    DATETIME      NULL,
    [CountryCode] VARCHAR (50)  NULL,
    [SortOrder]   INT           NULL,
    CONSTRAINT [PK_tblCountries] PRIMARY KEY CLUSTERED ([CountryID] ASC)
);







