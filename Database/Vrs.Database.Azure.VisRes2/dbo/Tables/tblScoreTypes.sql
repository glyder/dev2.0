CREATE TABLE [dbo].[tblScoreTypes] (
    [ScoreTypeID] INT           NOT NULL,
    [Type]        VARCHAR (127) NOT NULL,
    CONSTRAINT [PK_tblScoreTypes] PRIMARY KEY CLUSTERED ([ScoreTypeID] ASC)
);

