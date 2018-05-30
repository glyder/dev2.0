CREATE TABLE [dbo].[tblCompanyInsurances] (
    [CompanyInsuranceID] INT           NOT NULL,
    [CompanyID]          INT           NOT NULL,
    [InsuranceID]        INT           NOT NULL,
    [FromDate]           DATETIME      NULL,
    [EditedBy]           VARCHAR (150) NULL,
    CONSTRAINT [PK_tblCompanyInsurances] PRIMARY KEY CLUSTERED ([CompanyInsuranceID] ASC),
    CONSTRAINT [FK_tblCompanyInsurances_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);





