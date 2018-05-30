CREATE TABLE [dbo].[tblUserLevels] (
    [UserLevelID] INT           IDENTITY (1, 1) NOT NULL,
    [UserLevel]   VARCHAR (50)  NOT NULL,
    [EditedBy]    VARCHAR (120) NOT NULL,
    [FromDate]    DATETIME      NOT NULL,
    CONSTRAINT [PK_tblUserLevels] PRIMARY KEY CLUSTERED ([UserLevelID] ASC)
);

