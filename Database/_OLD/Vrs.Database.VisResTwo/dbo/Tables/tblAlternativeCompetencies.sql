CREATE TABLE [dbo].[tblAlternativeCompetencies] (
    [AlternativeCompetencyID]   INT           NOT NULL,
    [CompetencyID]              INT           NOT NULL,
    [CanBeReplacedByCompetency] INT           NULL,
    [CanBeReplacedByGroup]      INT           NULL,
    [FromDate]                  DATETIME      NULL,
    [EditedBy]                  VARCHAR (150) NULL,
    CONSTRAINT [PK_tblAlternativeCompetencies] PRIMARY KEY CLUSTERED ([AlternativeCompetencyID] ASC),
    CONSTRAINT [FK_tblAlternativeCompetencies_tblCompetencies] FOREIGN KEY ([CanBeReplacedByCompetency]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblAlternativeCompetencies_tblCompetencies2] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblAlternativeCompetencies_tblComplianceCompetencyGroups] FOREIGN KEY ([CanBeReplacedByGroup]) REFERENCES [dbo].[tblComplianceCompetencyGroups] ([ComplianceCompetencyGroupID])
);







