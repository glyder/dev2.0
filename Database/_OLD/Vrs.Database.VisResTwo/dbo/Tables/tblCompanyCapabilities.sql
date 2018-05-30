CREATE TABLE [dbo].[tblCompanyCapabilities] (
    [CompanyCapabilityID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]           INT           NOT NULL,
    [CapabilityID]        INT           NOT NULL,
    [Comments]            VARCHAR (MAX) NULL,
    [EditedBy]            VARCHAR (150) NULL,
    [FromDate]            DATETIME      NULL,
    CONSTRAINT [PK_tblCompanyCapabilities] PRIMARY KEY CLUSTERED ([CompanyCapabilityID] ASC),
    CONSTRAINT [FK_tblCompanyCapabilities_tblCapabilities] FOREIGN KEY ([CapabilityID]) REFERENCES [dbo].[tblCapabilities] ([CapabilityID]),
    CONSTRAINT [FK_tblCompanyCapabilities_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);







