CREATE TABLE [dbo].[tblRoleToRole] (
    [RoleToRoleID]    INT           NOT NULL,
    [ParentRoleID]    INT           NOT NULL,
    [ContainedRoleID] INT           NOT NULL,
    [FromDate]        DATETIME      NOT NULL,
    [EditedBy]        VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblRoleToRole] PRIMARY KEY CLUSTERED ([RoleToRoleID] ASC),
    CONSTRAINT [FK_tblRoleToRole_tblRoleLibrary] FOREIGN KEY ([ContainedRoleID]) REFERENCES [dbo].[tblRoleLibrary] ([RoleID]),
    CONSTRAINT [FK_tblRoleToRole_tblRoleLibrary1] FOREIGN KEY ([ParentRoleID]) REFERENCES [dbo].[tblRoleLibrary] ([RoleID])
);



