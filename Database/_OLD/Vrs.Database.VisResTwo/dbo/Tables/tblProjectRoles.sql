CREATE TABLE [dbo].[tblProjectRoles] (
    [ProjectRoleID] INT           NOT NULL,
    [Name]          VARCHAR (50)  NULL,
    [Description]   VARCHAR (MAX) NULL,
    [ProjectID]     INT           NOT NULL,
    [FromDate]      DATETIME      NOT NULL,
    [EditedBy]      VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProjectRoles] PRIMARY KEY CLUSTERED ([ProjectRoleID] ASC),
    CONSTRAINT [FK_tblProjectRoles_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);





