CREATE TABLE [dbo].[tblUserSessions] (
    [UserID]           INT           NOT NULL,
    [SessionAttribute] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [FK_tblUserSessions_tblUsers] FOREIGN KEY ([UserID]) REFERENCES [dbo].[tblUsers] ([UserID])
);






GO


