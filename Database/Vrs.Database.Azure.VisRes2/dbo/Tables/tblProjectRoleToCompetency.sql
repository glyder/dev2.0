CREATE TABLE [dbo].[tblProjectRoleToCompetency] (
    [ProjectRoleToCompetencyID] INT           NOT NULL,
    [ProjectRoleID]             INT           NOT NULL,
    [CompetencyID]              INT           NOT NULL,
    [MinimalEvidenceLevelID]    INT           NULL,
    [FromDate]                  DATETIME      NOT NULL,
    [EditedBy]                  VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProjectRoleToCompetency] PRIMARY KEY CLUSTERED ([ProjectRoleToCompetencyID] ASC),
    CONSTRAINT [FK_tblProjectRoleToCompetency_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblProjectRoleToCompetency_tblEvidenceLevel] FOREIGN KEY ([MinimalEvidenceLevelID]) REFERENCES [dbo].[tblEvidenceLevel] ([EvidenceLevelID]),
    CONSTRAINT [FK_tblProjectRoleToCompetency_tblProjectRoles] FOREIGN KEY ([ProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID])
);

