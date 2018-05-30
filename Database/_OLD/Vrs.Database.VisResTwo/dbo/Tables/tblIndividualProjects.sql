CREATE TABLE [dbo].[tblIndividualProjects] (
    [IndividualProjectID]       INT           IDENTITY (1, 1) NOT NULL,
    [ProjectID]                 INT           NOT NULL,
    [CompanyID]                 INT           NOT NULL,
    [IndividualID]              INT           NOT NULL,
    [IndividualProjectStatusID] INT           NULL,
    [Comments]                  VARCHAR (MAX) NULL,
    [FromDate]                  DATETIME      NULL,
    [EditedBy]                  VARCHAR (150) NULL,
    [IsActive]                  BIT           NOT NULL,
    CONSTRAINT [PK_tblIndividualProjects] PRIMARY KEY CLUSTERED ([IndividualProjectID] ASC),
    CONSTRAINT [FK_tblIndividualProjects_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblIndividualProjects_tblIndividualProjectStatuses] FOREIGN KEY ([IndividualProjectStatusID]) REFERENCES [dbo].[tblIndividualProjectStatuses] ([IndividualProjectStatusID]),
    CONSTRAINT [FK_tblIndividualProjects_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblIndividualProjects_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);









