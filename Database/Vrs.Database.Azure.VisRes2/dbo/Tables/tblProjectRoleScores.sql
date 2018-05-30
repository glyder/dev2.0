CREATE TABLE [dbo].[tblProjectRoleScores] (
    [ProjectRoleScoresID] INT           NOT NULL,
    [ProjectRoleID]       INT           NOT NULL,
    [ScoreTypeID]         INT           NOT NULL,
    [ScoresRequired]      INT           NOT NULL,
    [FromDate]            DATETIME      NOT NULL,
    [EditedBy]            VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProjectRoleScores] PRIMARY KEY CLUSTERED ([ProjectRoleScoresID] ASC),
    CONSTRAINT [FK_tblProjectRoleScores_tblProjectRoles] FOREIGN KEY ([ProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID]),
    CONSTRAINT [FK_tblProjectRoleScores_tblScoreTypes] FOREIGN KEY ([ScoreTypeID]) REFERENCES [dbo].[tblScoreTypes] ([ScoreTypeID])
);

