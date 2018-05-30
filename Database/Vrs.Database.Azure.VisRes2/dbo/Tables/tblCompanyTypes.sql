CREATE TABLE [dbo].[tblCompanyTypes] (
    [CompanyTypeID] INT          NOT NULL,
    [Type]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblCompanyTypes] PRIMARY KEY CLUSTERED ([CompanyTypeID] ASC)
);

