CREATE TABLE [dbo].[tblIndividualStatuses] (
    [IndividualStatusID] INT          NOT NULL,
    [Status]             VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblIndividualStatuses] PRIMARY KEY CLUSTERED ([IndividualStatusID] ASC)
);

