CREATE TABLE [dbo].[tblIndividualSubStatuses] (
    [IndividualSubStatusID] INT          NOT NULL,
    [SubStatus]             VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblIndividualSubStatuses] PRIMARY KEY CLUSTERED ([IndividualSubStatusID] ASC)
);

