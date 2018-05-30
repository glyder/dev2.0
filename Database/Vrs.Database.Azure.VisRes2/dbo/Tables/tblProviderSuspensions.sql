CREATE TABLE [dbo].[tblProviderSuspensions] (
    [ProviderSuspensionID] INT           NOT NULL,
    [SuspensionID]         INT           NOT NULL,
    [CompanyID]            INT           NOT NULL,
    [FromDate]             DATETIME      NOT NULL,
    [EditedBy]             VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProviderSuspensions] PRIMARY KEY CLUSTERED ([ProviderSuspensionID] ASC),
    CONSTRAINT [FK_tblProviderSuspensions_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblProviderSuspensions_tblSuspensions] FOREIGN KEY ([SuspensionID]) REFERENCES [dbo].[tblSuspensions] ([SuspensionID])
);

