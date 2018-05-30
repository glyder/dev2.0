CREATE TABLE [dbo].[tblRoleToCompetency] (
    [RoleToCompetencyID] INT           NOT NULL,
    [RoleID]             INT           NOT NULL,
    [CompetencyID]       INT           NOT NULL,
    [FromDate]           DATETIME      NOT NULL,
    [EditedBy]           VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblRoleToCompetency] PRIMARY KEY CLUSTERED ([RoleToCompetencyID] ASC),
    CONSTRAINT [FK_tblRoleToCompetency_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblRoleToCompetency_tblRoleLibrary] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[tblRoleLibrary] ([RoleID])
);



