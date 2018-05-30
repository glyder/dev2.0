CREATE TABLE [dbo].[tblIndividualIDCards] (
    [IndividalIDCardID] INT           IDENTITY (1, 1) NOT NULL,
    [IndividualID]      INT           NULL,
    [UserName]          VARCHAR (120) NULL,
    [CompanyID]         INT           NULL,
    [ProjectID]         INT           NULL,
    CONSTRAINT [PK_tblIndividalIDCards] PRIMARY KEY CLUSTERED ([IndividalIDCardID] ASC),
    CONSTRAINT [FK_tblIndividualIDCards_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblIndividualIDCards_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblIndividualIDCards_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);

