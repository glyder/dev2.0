CREATE TABLE [dbo].[tblCompetencyToJurisdiction] (
    [CompetencyToJurisdictionID] INT           NOT NULL,
    [CompetencyID]               INT           NOT NULL,
    [JurisdictionID]             INT           NOT NULL,
    [FromDate]                   DATETIME      NOT NULL,
    [EditedBy]                   VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompetencyToJurisdiction] PRIMARY KEY CLUSTERED ([CompetencyToJurisdictionID] ASC),
    CONSTRAINT [FK_tblCompetencyToJurisdiction_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblCompetencyToJurisdiction_tblJurisdictions] FOREIGN KEY ([JurisdictionID]) REFERENCES [dbo].[tblJurisdictions] ([JurisdictionID])
);



