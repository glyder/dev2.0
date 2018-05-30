CREATE TABLE [dbo].[tblCompanySubStatuses] (
    [CompanySubStatusID] INT          NOT NULL,
    [SubStatus]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblCompanySubStatuses] PRIMARY KEY CLUSTERED ([CompanySubStatusID] ASC)
);

