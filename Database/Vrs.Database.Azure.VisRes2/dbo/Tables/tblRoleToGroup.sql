CREATE TABLE [dbo].[tblRoleToGroup] (
    [RoleToRCGroupID] INT           NOT NULL,
    [RoleID]          INT           NOT NULL,
    [RCGroupID]       INT           NOT NULL,
    [FromDate]        DATETIME      NOT NULL,
    [EditedBy]        VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblRoleToGroup] PRIMARY KEY CLUSTERED ([RoleToRCGroupID] ASC),
    CONSTRAINT [FK_tblRoleToGroup_tblRCGroups] FOREIGN KEY ([RCGroupID]) REFERENCES [dbo].[tblRCGroups] ([RCGroupID]),
    CONSTRAINT [FK_tblRoleToGroup_tblRoleLibrary] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[tblRoleLibrary] ([RoleID])
);

