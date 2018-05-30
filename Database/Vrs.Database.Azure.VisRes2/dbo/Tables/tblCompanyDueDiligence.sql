CREATE TABLE [dbo].[tblCompanyDueDiligence] (
    [CompanyDueDiligenceID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]             INT           NOT NULL,
    [Answers]               VARCHAR (MAX) NOT NULL,
    [EditedBy]              VARCHAR (150) NOT NULL,
    [FromDate]              DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([CompanyDueDiligenceID] ASC),
    CONSTRAINT [FK_tblCompanyDueDiligence_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);

