CREATE TABLE [dbo].[tblRoleLibrary] (
    [RoleID]      INT           NOT NULL,
    [Name]        VARCHAR (127) NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [FromDate]    DATETIME      NULL,
    [EditedBy]    VARCHAR (150) NULL,
    CONSTRAINT [PK_tblRoleLibrary] PRIMARY KEY CLUSTERED ([RoleID] ASC)
);

