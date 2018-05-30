CREATE TABLE [dbo].[tblIndividualProjectRoles] (
    [IndividualProjectRoleID] INT           IDENTITY (1, 1) NOT NULL,
    [IndividualID]            INT           NOT NULL,
    [ProjectRoleID]           INT           NOT NULL,
    [Comments]                VARCHAR (MAX) NULL,
    [FromDate]                DATETIME      NULL,
    [EditedBy]                VARCHAR (150) NULL,
    [IsActive]                BIT           NOT NULL,
    CONSTRAINT [PK_tblIndividualProjectRoles] PRIMARY KEY CLUSTERED ([IndividualProjectRoleID] ASC),
    CONSTRAINT [FK_tblIndividualProjectRoles_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblIndividualProjectRoles_tblProjectRoles] FOREIGN KEY ([ProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID])
);



