CREATE TABLE [dbo].[tblJurisdictions] (
    [JurisdictionID]       INT           NOT NULL,
    [Name]                 VARCHAR (120) NOT NULL,
    [ParentJurisdictionID] INT           NULL,
    [FromDate]             DATETIME      NULL,
    [EditedBy]             VARCHAR (150) NULL,
    CONSTRAINT [PK_tblJurisdictions] PRIMARY KEY CLUSTERED ([JurisdictionID] ASC),
    CONSTRAINT [FK_tblJurisdictions_tblJurisdictions] FOREIGN KEY ([ParentJurisdictionID]) REFERENCES [dbo].[tblJurisdictions] ([JurisdictionID])
);







