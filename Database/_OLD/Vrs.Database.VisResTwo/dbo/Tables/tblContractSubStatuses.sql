CREATE TABLE [dbo].[tblContractSubStatuses] (
    [ContractSubStatusID] INT          NOT NULL,
    [SubStatus]           VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblContractSubStatuses] PRIMARY KEY CLUSTERED ([ContractSubStatusID] ASC)
);

