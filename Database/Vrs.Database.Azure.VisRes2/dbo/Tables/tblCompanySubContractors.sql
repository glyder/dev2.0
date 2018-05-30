CREATE TABLE [dbo].[tblCompanySubContractors] (
    [CompanySubContractorID] INT           IDENTITY (1, 1) NOT NULL,
    [SubContractorID]        INT           NOT NULL,
    [CompanyID]              INT           NOT NULL,
    [Comments]               VARCHAR (MAX) NULL,
    [EditedBy]               VARCHAR (150) NULL,
    [FromDate]               DATETIME      NULL,
    [ContractID]             INT           NULL,
    [ProjectID]              INT           NOT NULL,
    CONSTRAINT [PK_tblCompanySubContractors] PRIMARY KEY CLUSTERED ([CompanySubContractorID] ASC),
    CONSTRAINT [FK_tblCompanySubContractors_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanySubContractors_tblCompanies1] FOREIGN KEY ([SubContractorID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanySubContractors_tblContracts] FOREIGN KEY ([ContractID]) REFERENCES [dbo].[tblContracts] ([ContractID]),
    CONSTRAINT [FK_tblCompanySubContractors_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);

