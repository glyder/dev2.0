CREATE TABLE [dbo].[tblContractProjects] (
    [ContractProjectID] INT           IDENTITY (1, 1) NOT NULL,
    [ContractID]        INT           NOT NULL,
    [ProjectID]         INT           NOT NULL,
    [Comment]           VARCHAR (MAX) NULL,
    [EditedBy]          VARCHAR (150) NULL,
    [FromDate]          DATETIME      NULL,
    [IsActive]          BIT           NOT NULL,
    CONSTRAINT [PK_tblContractProjects] PRIMARY KEY CLUSTERED ([ContractProjectID] ASC),
    CONSTRAINT [FK_tblContractProjects_tblContracts] FOREIGN KEY ([ContractID]) REFERENCES [dbo].[tblContracts] ([ContractID]),
    CONSTRAINT [FK_tblContractProjects_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);









