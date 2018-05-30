CREATE TABLE [dbo].[tblSuspensions] (
    [SuspensionID]           INT           NOT NULL,
    [Name]                   VARCHAR (50)  NULL,
    [SuspensionTypeID]       INT           NOT NULL,
    [SuspensionReasonID]     INT           NULL,
    [SuspensionStartDate]    DATETIME      NOT NULL,
    [SuspensionEndDate]      DATETIME      NULL,
    [SuspendedProjectID]     INT           NULL,
    [SuspendedProjectRoleID] INT           NULL,
    [SuspendedLOBID]         INT           NULL,
    [SuspendedDivisionID]    INT           NULL,
    [FromDate]               DATETIME      NULL,
    [EditedBy]               VARCHAR (150) NULL,
    [SuspendedCapabilityID]  INT           NULL,
    [SuspensionStatusID]     INT           NOT NULL,
    CONSTRAINT [PK_tblSuspensions] PRIMARY KEY CLUSTERED ([SuspensionID] ASC),
    CONSTRAINT [FK_tblSuspensions_tblCapabilities] FOREIGN KEY ([SuspendedCapabilityID]) REFERENCES [dbo].[tblCapabilities] ([CapabilityID]),
    CONSTRAINT [FK_tblSuspensions_tblDivisions] FOREIGN KEY ([SuspendedDivisionID]) REFERENCES [dbo].[tblDivisions] ([DivisionID]),
    CONSTRAINT [FK_tblSuspensions_tblLOBs] FOREIGN KEY ([SuspendedLOBID]) REFERENCES [dbo].[tblLOBs] ([LOBID]),
    CONSTRAINT [FK_tblSuspensions_tblProjectRoles] FOREIGN KEY ([SuspendedProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID]),
    CONSTRAINT [FK_tblSuspensions_tblProjects] FOREIGN KEY ([SuspendedProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID]),
    CONSTRAINT [FK_tblSuspensions_tblSuspensionReasons] FOREIGN KEY ([SuspensionReasonID]) REFERENCES [dbo].[tblSuspensionReasons] ([SuspensionReasonID]),
    CONSTRAINT [FK_tblSuspensions_tblSuspensionStatuses] FOREIGN KEY ([SuspensionStatusID]) REFERENCES [dbo].[tblSuspensionStatuses] ([SuspensionStatusID]),
    CONSTRAINT [FK_tblSuspensions_tblSuspensionTypes] FOREIGN KEY ([SuspensionTypeID]) REFERENCES [dbo].[tblSuspensionTypes] ([SuspensionTypeID])
);











