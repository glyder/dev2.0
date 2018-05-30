CREATE TABLE [dbo].[tblCompetencyIntegrations] (
    [CompetencyIntegrationID] INT           NOT NULL,
    [CompetencyID]            INT           NOT NULL,
    [IntegratedSystem]        VARCHAR (255) NOT NULL,
    [Key]                     VARCHAR (255) NOT NULL,
    [Value]                   VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_tblCompetencyIntegrations] PRIMARY KEY CLUSTERED ([CompetencyIntegrationID] ASC),
    CONSTRAINT [FK_tblCompetencyIntegrations_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID])
);

