CREATE TABLE [dbo].[tblProjectStatuses] (
    [ProjectStatusID] INT          NOT NULL,
    [Status]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblProjectStatuses] PRIMARY KEY CLUSTERED ([ProjectStatusID] ASC)
);

