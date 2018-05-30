CREATE TABLE [dbo].[tblUserProjects] (
    [UserProjectID] INT           IDENTITY (1, 1) NOT NULL,
    [ProjectID]     INT           NOT NULL,
    [UserID]        INT           NOT NULL,
    [EditedBy]      VARCHAR (120) NOT NULL,
    [FromDate]      DATETIME      NOT NULL,
    CONSTRAINT [PK_tblUserProjects] PRIMARY KEY CLUSTERED ([UserProjectID] ASC),
    CONSTRAINT [FK_tblUserProjects_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID]),
    CONSTRAINT [FK_tblUserProjects_tblUsers] FOREIGN KEY ([UserID]) REFERENCES [dbo].[tblUsers] ([UserID])
);





