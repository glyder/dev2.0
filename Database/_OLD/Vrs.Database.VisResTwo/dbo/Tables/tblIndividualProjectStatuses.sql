CREATE TABLE [dbo].[tblIndividualProjectStatuses] (
    [IndividualProjectStatusID] INT          NOT NULL,
    [Status]                    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblIndividualProjectStatuses] PRIMARY KEY CLUSTERED ([IndividualProjectStatusID] ASC)
);

