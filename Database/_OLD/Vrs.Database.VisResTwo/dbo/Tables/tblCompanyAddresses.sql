CREATE TABLE [dbo].[tblCompanyAddresses] (
    [CompanyAddressID] INT           NOT NULL,
    [CompanyID]        INT           NOT NULL,
    [AddressID]        INT           NOT NULL,
    [AddressTypeID]    INT           NOT NULL,
    [FromDate]         DATETIME      NOT NULL,
    [EditedBy]         VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompanyAddresses] PRIMARY KEY CLUSTERED ([CompanyAddressID] ASC),
    CONSTRAINT [FK_tblCompanyAddresses_tblAddresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[tblAddresses] ([AddressID]),
    CONSTRAINT [FK_tblCompanyAddresses_tblAddressTypes] FOREIGN KEY ([AddressTypeID]) REFERENCES [dbo].[tblAddressTypes] ([AddressTypeID]),
    CONSTRAINT [FK_tblCompanyAddresses_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);



