CREATE TABLE [dbo].[tblAreasOfOperation] (
    [AreaOfOperationID] INT           IDENTITY (1, 1) NOT NULL,
    [JurisdictionID]    INT           NULL,
    [AreaCode]          VARCHAR (50)  NULL,
    [ExchangeName]      VARCHAR (50)  NULL,
    [Code]              VARCHAR (50)  NULL,
    [EditedBy]          VARCHAR (150) NULL,
    [FromDate]          DATETIME      NULL,
    CONSTRAINT [PK__tblAreasOfOperation] PRIMARY KEY CLUSTERED ([AreaOfOperationID] ASC),
    CONSTRAINT [FK_tblAreasOfOperation_tblJurisdictions] FOREIGN KEY ([JurisdictionID]) REFERENCES [dbo].[tblJurisdictions] ([JurisdictionID])
);







