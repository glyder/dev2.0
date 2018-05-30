CREATE TABLE [dbo].[tblCompanyIndividuals] (
    [CompanyIndividualID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]           INT           NOT NULL,
    [IndividualID]        INT           NOT NULL,
    [Comments]            VARCHAR (MAX) NULL,
    [FromDate]            DATETIME      NULL,
    [EditedBy]            VARCHAR (150) NULL,
    [IsActive]            BIT           NOT NULL,
    CONSTRAINT [PK_tblCompanyIndividuals] PRIMARY KEY CLUSTERED ([CompanyIndividualID] ASC),
    CONSTRAINT [FK_tblCompanyIndividuals_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanyIndividuals_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);









