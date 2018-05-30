CREATE TABLE [dbo].[tblCapabilityGroups] (
    [CapabilityGroupID] INT           IDENTITY (1, 1) NOT NULL,
    [CapabilityGroup]   VARCHAR (120) NOT NULL,
    [EditedBy]          VARCHAR (150) NULL,
    [FromDate]          DATETIME      NULL,
    CONSTRAINT [PK_tblCapabilityGroups] PRIMARY KEY CLUSTERED ([CapabilityGroupID] ASC)
);







