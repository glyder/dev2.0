CREATE TABLE [dbo].[tblCompanyAccreditations] (
    [CompanyAccreditationID]   INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]                INT           NOT NULL,
    [AccreditationLicencingID] INT           NOT NULL,
    [IssuedID]                 INT           NULL,
    [DateAchieved]             DATETIME      NULL,
    [IssueDate]                DATETIME      NULL,
    [ExpiryDate]               DATETIME      NULL,
    [LicenceNumber]            VARCHAR (50)  NULL,
    [Comments]                 VARCHAR (MAX) NULL,
    [EditedBy]                 VARCHAR (150) NULL,
    [FromDate]                 DATETIME      NULL,
    [StateID]                  INT           NULL,
    CONSTRAINT [PK_tblCompanyAccreditations] PRIMARY KEY CLUSTERED ([CompanyAccreditationID] ASC),
    CONSTRAINT [FK_tblCompanyAccreditations_tblAccreditationLicencing] FOREIGN KEY ([AccreditationLicencingID]) REFERENCES [dbo].[tblAccreditationLicencing] ([AccreditationLicencingID]),
    CONSTRAINT [FK_tblCompanyAccreditations_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);



