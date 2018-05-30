CREATE TABLE [dbo].[tblContractIntegrations] (
    [ContractIntegrationID] INT           NOT NULL,
    [ContractID]            INT           NOT NULL,
    [IntegratedSystem]      VARCHAR (255) NOT NULL,
    [Key]                   VARCHAR (255) NOT NULL,
    [Value]                 VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_tblContractIntegrations] PRIMARY KEY CLUSTERED ([ContractIntegrationID] ASC),
    CONSTRAINT [FK_tblContractIntegrations_tblContracts] FOREIGN KEY ([ContractID]) REFERENCES [dbo].[tblContracts] ([ContractID])
);

