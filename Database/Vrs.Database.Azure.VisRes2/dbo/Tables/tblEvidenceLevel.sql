CREATE TABLE [dbo].[tblEvidenceLevel] (
    [EvidenceLevelID] INT           NOT NULL,
    [LevelName]       VARCHAR (50)  NOT NULL,
    [LevelScore]      INT           NULL,
    [FromDate]        DATETIME      NOT NULL,
    [EditedBy]        VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblEvidenceLevel] PRIMARY KEY CLUSTERED ([EvidenceLevelID] ASC)
);

