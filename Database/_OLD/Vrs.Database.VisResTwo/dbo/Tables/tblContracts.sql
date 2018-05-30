CREATE TABLE [dbo].[tblContracts] (
    [ContractID]                INT           IDENTITY (1, 1) NOT NULL,
    [ContractNo]                VARCHAR (120) NULL,
    [ParentContractID]          INT           NULL,
    [ContractName]              VARCHAR (255) NULL,
    [ContractTypeID]            INT           NULL,
    [ContractExecutionDate]     DATETIME      NULL,
    [ContractValue]             VARCHAR (50)  NULL,
    [ContractStartDate]         DATETIME      NULL,
    [ContractEndDate]           DATETIME      NULL,
    [PrincipalID]               INT           NULL,
    [CompanyID]                 INT           NULL,
    [FromDate]                  DATETIME      NULL,
    [EditedBy]                  VARCHAR (150) NULL,
    [OriginalDocumentFiledDate] DATETIME      NULL,
    [DestructionDate]           DATETIME      NULL,
    [EntityID]                  INT           NULL,
    [PaymentTerm]               VARCHAR (255) NULL,
    [IsContractNumber]          BIT           NULL,
    [ReleaseAndWaivers]         BIT           NULL,
    [CompanyOnBoardingID]       INT           NULL,
    [ContractStatusID]          INT           NULL,
    [DestructionYear]           INT           NULL,
    [DefectsLiabilityPeriod]    DATETIME      NULL,
    [ContractSubStatusID]       INT           NULL,
    CONSTRAINT [PK_tblContract] PRIMARY KEY CLUSTERED ([ContractID] ASC),
    CONSTRAINT [FK_tblContracts_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblContracts_tblContracts] FOREIGN KEY ([ParentContractID]) REFERENCES [dbo].[tblContracts] ([ContractID]),
    CONSTRAINT [FK_tblContracts_tblContractStatuses] FOREIGN KEY ([ContractStatusID]) REFERENCES [dbo].[tblContractStatuses] ([ContractStatusID]),
    CONSTRAINT [FK_tblContracts_tblContractSubStatuses] FOREIGN KEY ([ContractSubStatusID]) REFERENCES [dbo].[tblContractSubStatuses] ([ContractSubStatusID]),
    CONSTRAINT [FK_tblContracts_tblContractTypes] FOREIGN KEY ([ContractTypeID]) REFERENCES [dbo].[tblContractTypes] ([ContractTypeID]),
    CONSTRAINT [FK_tblContracts_tblIndividuals] FOREIGN KEY ([PrincipalID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);









