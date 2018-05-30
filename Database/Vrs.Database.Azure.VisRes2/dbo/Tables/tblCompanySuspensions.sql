CREATE TABLE [dbo].[tblCompanySuspensions] (
    [CompanySuspensionID] INT           NOT NULL,
    [SuspensionID]        INT           NOT NULL,
    [CompanyID]           INT           NOT NULL,
    [FromDate]            DATETIME      NOT NULL,
    [EditedBy]            VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompanySuspensions] PRIMARY KEY CLUSTERED ([CompanySuspensionID] ASC),
    CONSTRAINT [FK_tblCompanySuspensions_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanySuspensions_tblSuspensions] FOREIGN KEY ([SuspensionID]) REFERENCES [dbo].[tblSuspensions] ([SuspensionID])
);

