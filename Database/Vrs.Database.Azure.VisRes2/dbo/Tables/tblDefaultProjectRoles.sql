CREATE TABLE [dbo].[tblDefaultProjectRoles] (
    [DefaultProjectRoleID] INT           NOT NULL,
    [ProjectRoleID]        INT           NOT NULL,
    [CompanyID]            INT           NOT NULL,
    [FromDate]             DATETIME      NOT NULL,
    [EditedBy]             VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblDefaultProjectRoles] PRIMARY KEY CLUSTERED ([DefaultProjectRoleID] ASC),
    CONSTRAINT [FK_tblDefaultProjectRoles_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblDefaultProjectRoles_tblProjectRoles] FOREIGN KEY ([ProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID])
);

