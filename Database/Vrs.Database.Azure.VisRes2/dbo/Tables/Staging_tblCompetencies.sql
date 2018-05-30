CREATE TABLE [dbo].[Staging_tblCompetencies] (
    [CompetencyID]       INT           IDENTITY (1, 1) NOT NULL,
    [Code]               VARCHAR (50)  NULL,
    [Name]               VARCHAR (255) NOT NULL,
    [Description]        VARCHAR (MAX) NULL,
    [CompetencyTypeID]   INT           NOT NULL,
    [ParentCompetencyID] INT           NULL,
    [FromDate]           DATETIME      NULL,
    [EditedBy]           VARCHAR (150) NULL,
    [LegacyCompetencyID] INT           NULL
);

