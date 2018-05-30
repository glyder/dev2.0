CREATE TABLE [dbo].[tblProjectJurisdictions] (
    [ProjectJurisdictionID] INT           NOT NULL,
    [ProjectID]             INT           NOT NULL,
    [JurisdictionID]        INT           NOT NULL,
    [FromDate]              DATETIME      NOT NULL,
    [EditedBy]              VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProjectJurisdictions] PRIMARY KEY CLUSTERED ([ProjectJurisdictionID] ASC),
    CONSTRAINT [FK_tblProjectJurisdictions_tblJurisdictions] FOREIGN KEY ([JurisdictionID]) REFERENCES [dbo].[tblJurisdictions] ([JurisdictionID]),
    CONSTRAINT [FK_tblProjectJurisdictions_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);

