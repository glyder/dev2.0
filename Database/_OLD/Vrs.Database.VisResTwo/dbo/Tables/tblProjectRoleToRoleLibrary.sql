CREATE TABLE [dbo].[tblProjectRoleToRoleLibrary] (
    [ProjectRoleToRoleID] INT           NOT NULL,
    [ProjectRoleID]       INT           NOT NULL,
    [RoleLibraryID]       INT           NOT NULL,
    [FromDate]            DATETIME      NOT NULL,
    [EditedBy]            VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProjectRoleToRoleLibrary] PRIMARY KEY CLUSTERED ([ProjectRoleToRoleID] ASC),
    CONSTRAINT [FK_tblProjectRoleToRoleLibrary_tblProjectRoles] FOREIGN KEY ([ProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID]),
    CONSTRAINT [FK_tblProjectRoleToRoleLibrary_tblRoleLibrary] FOREIGN KEY ([RoleLibraryID]) REFERENCES [dbo].[tblRoleLibrary] ([RoleID])
);



