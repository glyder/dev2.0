CREATE TABLE [dbo].[tblCapabilities] (
    [CapabilityID]      INT           IDENTITY (1, 1) NOT NULL,
    [Capability]        VARCHAR (120) NOT NULL,
    [SubCapability]     VARCHAR (120) NULL,
    [CapabilityGroupID] INT           NULL,
    [EditedBy]          VARCHAR (150) NULL,
    [FromDate]          DATETIME      NULL,
    CONSTRAINT [PK_tblCapabilities] PRIMARY KEY CLUSTERED ([CapabilityID] ASC),
    CONSTRAINT [FK_tblCapabilities_tblCapabilityGroups] FOREIGN KEY ([CapabilityGroupID]) REFERENCES [dbo].[tblCapabilityGroups] ([CapabilityGroupID])
);

