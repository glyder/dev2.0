CREATE TABLE [dbo].[tblCompetencyToRCGroup] (
    [CompetencyToRCGroupID] INT           NOT NULL,
    [CompetencyID]          INT           NOT NULL,
    [RCGroupID]             INT           NOT NULL,
    [FromDate]              DATETIME      NOT NULL,
    [EditedBy]              VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompetencyToRCGroup] PRIMARY KEY CLUSTERED ([CompetencyToRCGroupID] ASC),
    CONSTRAINT [FK_tblCompetencyToRCGroup_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblCompetencyToRCGroup_tblRCGroups] FOREIGN KEY ([RCGroupID]) REFERENCES [dbo].[tblRCGroups] ([RCGroupID])
);

