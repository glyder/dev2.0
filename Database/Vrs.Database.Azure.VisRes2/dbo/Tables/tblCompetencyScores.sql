CREATE TABLE [dbo].[tblCompetencyScores] (
    [CompetencyScoreID] INT           NOT NULL,
    [CompetencyID]      INT           NOT NULL,
    [Score]             INT           NOT NULL,
    [ScoreTypeID]       INT           NOT NULL,
    [FromDate]          DATETIME      NULL,
    [EditedBy]          VARCHAR (150) NULL,
    CONSTRAINT [PK_tblCompetencyScores] PRIMARY KEY CLUSTERED ([CompetencyScoreID] ASC),
    CONSTRAINT [FK_tblCompetencyScores_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblCompetencyScores_tblScoreTypes] FOREIGN KEY ([ScoreTypeID]) REFERENCES [dbo].[tblScoreTypes] ([ScoreTypeID])
);

