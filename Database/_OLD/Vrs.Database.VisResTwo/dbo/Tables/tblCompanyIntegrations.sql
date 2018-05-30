CREATE TABLE [dbo].[tblCompanyIntegrations] (
    [CompanyIntegrationID] INT           NOT NULL,
    [CompanyID]            INT           NOT NULL,
    [IntegratedSystem]     VARCHAR (255) NOT NULL,
    [Key]                  VARCHAR (255) NOT NULL,
    [Value]                VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_tblCompanyIntegrations] PRIMARY KEY CLUSTERED ([CompanyIntegrationID] ASC),
    CONSTRAINT [FK_tblCompanyIntegrations_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);

