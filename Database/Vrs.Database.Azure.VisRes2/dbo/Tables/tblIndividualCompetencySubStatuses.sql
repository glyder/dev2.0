CREATE TABLE [dbo].[tblIndividualCompetencySubStatuses] (
    [IndividualCompetencySubStatusID] INT          NOT NULL,
    [SubStatus]                       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblIndividualCompetencySubStatuses] PRIMARY KEY CLUSTERED ([IndividualCompetencySubStatusID] ASC)
);

