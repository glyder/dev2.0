CREATE TABLE [dbo].[Staging_tblIndividualCompetencies] (
    [IndividualCompetencyID]          INT           IDENTITY (1, 1) NOT NULL,
    [IndividualID]                    INT           NOT NULL,
    [LegacyCompetencyID]              INT           NOT NULL,
    [AssessedBy]                      INT           NULL,
    [AssessmentDate]                  DATETIME      NULL,
    [ExpiryDate]                      DATETIME      NULL,
    [ProviderID]                      INT           NULL,
    [EvidenceNumber]                  VARCHAR (50)  NULL,
    [EvidenceLevelID]                 INT           NULL,
    [FromDate]                        DATETIME      NULL,
    [EditedBy]                        VARCHAR (150) NULL,
    [IndividualCompetencySubStatusID] INT           NULL,
    [CompetencyTypeID]                INT           NULL
);

