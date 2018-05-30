CREATE TABLE [dbo].[tblContractStatuses] (
    [ContractStatusID] INT          NOT NULL,
    [Status]           VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblContractStatuses] PRIMARY KEY CLUSTERED ([ContractStatusID] ASC)
);

