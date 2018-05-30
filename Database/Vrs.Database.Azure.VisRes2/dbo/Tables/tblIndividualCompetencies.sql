CREATE TABLE [dbo].[tblIndividualCompetencies] (
    [IndividualCompetencyID]          INT           NOT NULL,
    [IndividualID]                    INT           NOT NULL,
    [CompetencyID]                    INT           NOT NULL,
    [AssessedBy]                      INT           NULL,
    [AssessmentDate]                  DATETIME      NULL,
    [ExpiryDate]                      DATETIME      NULL,
    [ProviderID]                      INT           NULL,
    [EvidenceNumber]                  VARCHAR (50)  NULL,
    [EvidenceLevelID]                 INT           NULL,
    [FromDate]                        DATETIME      NULL,
    [EditedBy]                        VARCHAR (150) NULL,
    [IndividualCompetencySubStatusID] INT           NULL,
    CONSTRAINT [PK_tblIndividualCompetencies] PRIMARY KEY CLUSTERED ([IndividualCompetencyID] ASC),
    CONSTRAINT [FK_tblIndividualCompetencies_tblCompanies] FOREIGN KEY ([ProviderID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblIndividualCompetencies_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblIndividualCompetencies_tblEvidenceLevel] FOREIGN KEY ([EvidenceLevelID]) REFERENCES [dbo].[tblEvidenceLevel] ([EvidenceLevelID]),
    CONSTRAINT [FK_tblIndividualCompetencies_tblIndividualCompetencies] FOREIGN KEY ([IndividualCompetencyID]) REFERENCES [dbo].[tblIndividualCompetencies] ([IndividualCompetencyID]),
    CONSTRAINT [FK_tblIndividualCompetencies_tblIndividualCompetencySubStatuses] FOREIGN KEY ([IndividualCompetencySubStatusID]) REFERENCES [dbo].[tblIndividualCompetencySubStatuses] ([IndividualCompetencySubStatusID]),
    CONSTRAINT [FK_tblIndividualCompetencies_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);







