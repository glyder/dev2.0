CREATE TABLE [dbo].[tblCompanies] (
    [CompanyID]                   INT           IDENTITY (1, 1) NOT NULL,
    [CompanyName]                 VARCHAR (255) NOT NULL,
    [TradingName]                 VARCHAR (255) NULL,
    [CompanyTypeID]               INT           NULL,
    [MainContactID]               INT           NULL,
    [PhoneNumber]                 VARCHAR (50)  NULL,
    [MobileNumber]                VARCHAR (50)  NULL,
    [FacsimileNumber]             VARCHAR (50)  NULL,
    [EMailAddress]                VARCHAR (255) NULL,
    [ABN]                         VARCHAR (50)  NULL,
    [ACN]                         VARCHAR (50)  NULL,
    [AccountsReceivableContactID] INT           NULL,
    [AccountsPayableContactID]    INT           NULL,
    [EditedBy]                    VARCHAR (150) NULL,
    [FromDate]                    DATETIME      NULL,
    [VENDOR_ID]                   INT           NULL,
    [SEGMENT1]                    VARCHAR (20)  NULL,
    [LAST_UPDATE_DATE]            DATETIME      NULL,
    [VENDOR_SITE_ID]              INT           NULL,
    [VENDOR_SITE_CODE]            VARCHAR (255) NULL,
    [ADDRESS_LINE3]               VARCHAR (MAX) NULL,
    [OPERATING_UNIT]              VARCHAR (25)  NULL,
    [CustomerNumber]              VARCHAR (50)  NULL,
    [CustomerSite]                INT           NULL,
    [AdvanceCompanyID]            INT           NULL,
    [CompanyStatusID]             INT           NULL,
    [DivisionID]                  INT           NULL,
    [CountryID]                   INT           NULL,
    [RTONumber]                   VARCHAR (50)  NULL,
    [CompanySubStatusID]          INT           NOT NULL,
    CONSTRAINT [PK_tblCompanies] PRIMARY KEY CLUSTERED ([CompanyID] ASC),
    CONSTRAINT [FK_tblCompanies_AccountPayableContact] FOREIGN KEY ([AccountsPayableContactID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblCompanies_AccountReceivableContact] FOREIGN KEY ([AccountsReceivableContactID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblCompanies_MainContact] FOREIGN KEY ([MainContactID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblCompanies_tblCompanySubStatuses] FOREIGN KEY ([CompanySubStatusID]) REFERENCES [dbo].[tblCompanySubStatuses] ([CompanySubStatusID]),
    CONSTRAINT [FK_tblCompanies_tblCompanyType] FOREIGN KEY ([CompanyTypeID]) REFERENCES [dbo].[tblCompanyTypes] ([CompanyTypeID]),
    CONSTRAINT [FK_tblCompanies_tblCountries] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[tblCountries] ([CountryID]),
    CONSTRAINT [FK_tblCompanies_tblDivisions] FOREIGN KEY ([DivisionID]) REFERENCES [dbo].[tblDivisions] ([DivisionID])
);







