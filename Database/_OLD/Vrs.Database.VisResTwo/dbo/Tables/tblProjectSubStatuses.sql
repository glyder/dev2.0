CREATE TABLE [dbo].[tblProjectSubStatuses] (
    [ProjectSubStatusID] INT          NOT NULL,
    [SubStatus]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblProjectSubStatuses] PRIMARY KEY CLUSTERED ([ProjectSubStatusID] ASC)
);

