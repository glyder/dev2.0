CREATE TABLE [dbo].[tblIndividualSuspensions] (
    [IndividualSuspensionID] INT           NOT NULL,
    [SuspensionID]           INT           NOT NULL,
    [IndividualID]           INT           NOT NULL,
    [FromDate]               DATETIME      NULL,
    [EditedBy]               VARCHAR (150) NULL,
    CONSTRAINT [PK_tblIndividualSuspensions] PRIMARY KEY CLUSTERED ([IndividualSuspensionID] ASC),
    CONSTRAINT [FK_tblIndividualSuspensions_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblIndividualSuspensions_tblSuspensions] FOREIGN KEY ([SuspensionID]) REFERENCES [dbo].[tblSuspensions] ([SuspensionID])
);







