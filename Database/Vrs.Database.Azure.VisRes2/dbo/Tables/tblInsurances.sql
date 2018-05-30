CREATE TABLE [dbo].[tblInsurances] (
    [InsuranceID]          INT           IDENTITY (1, 1) NOT NULL,
    [InsuranceTypeID]      INT           NOT NULL,
    [PolicyNumber]         VARCHAR (50)  NULL,
    [ExpiryDate]           DATETIME      NULL,
    [AmountCover]          VARCHAR (50)  NULL,
    [ProviderName]         VARCHAR (50)  NULL,
    [DocAttahmentID]       INT           NULL,
    [EditedBy]             VARCHAR (150) NULL,
    [FromDate]             DATETIME      NULL,
    [InsuranceSubStatusID] INT           NULL,
    [CompanyID]            INT           NOT NULL,
    CONSTRAINT [PK_tblInsurances] PRIMARY KEY CLUSTERED ([InsuranceID] ASC),
    CONSTRAINT [FK_tblInsurances_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblInsurances_tblInsuranceSubStatuses] FOREIGN KEY ([InsuranceSubStatusID]) REFERENCES [dbo].[tblInsuranceSubStatuses] ([InsuranceSubStatusID]),
    CONSTRAINT [FK_tblInsurances_tblInsuranceTypes] FOREIGN KEY ([InsuranceTypeID]) REFERENCES [dbo].[tblInsuranceTypes] ([InsuranceTypeID])
);




GO
CREATE NONCLUSTERED INDEX [tblInsurances_ExpiryDate_IX]
    ON [dbo].[tblInsurances]([ExpiryDate] ASC)
    INCLUDE([InsuranceTypeID], [CompanyID]);

