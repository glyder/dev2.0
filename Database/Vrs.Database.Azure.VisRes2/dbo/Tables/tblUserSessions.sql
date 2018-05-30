CREATE TABLE [dbo].[tblUserSessions] (
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [UserID]           INT           NOT NULL,
    [SessionAttribute] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [FK_tblUserSessions_tblUsers] FOREIGN KEY ([UserID]) REFERENCES [dbo].[tblUsers] ([UserID]), 
    CONSTRAINT [PK_tblUserSessions] PRIMARY KEY ([ID])
);




GO


