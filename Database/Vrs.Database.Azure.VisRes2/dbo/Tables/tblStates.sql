CREATE TABLE [dbo].[tblStates] (
    [StateID]   INT           IDENTITY (1, 1) NOT NULL,
    [State]     VARCHAR (255) NOT NULL,
    [EditedBy]  VARCHAR (150) NULL,
    [FromDate]  DATETIME      NULL,
    [CountryID] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([StateID] ASC),
    CONSTRAINT [FK_tblStates_tblCountries] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[tblCountries] ([CountryID])
);

