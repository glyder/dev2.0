CREATE TABLE [dbo].[tblCompanyAreasOfOperation] (
    [CompanyAreaOfOperationID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]                INT           NOT NULL,
    [AreaOfOperationID]        INT           NOT NULL,
    [Comments]                 VARCHAR (MAX) NULL,
    [FromDate]                 DATETIME      NULL,
    [EditedBy]                 VARCHAR (150) NULL,
    CONSTRAINT [PK_tblCompanyAreasOfOperation] PRIMARY KEY CLUSTERED ([CompanyAreaOfOperationID] ASC),
    CONSTRAINT [FK_tblCompanyAreasOfOperation_tblAreasOfOperation] FOREIGN KEY ([AreaOfOperationID]) REFERENCES [dbo].[tblAreasOfOperation] ([AreaOfOperationID]),
    CONSTRAINT [FK_tblCompanyAreasOfOperation_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);







