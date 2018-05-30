CREATE TABLE [dbo].[tblSuspensionStatuses] (
    [SuspensionStatusID] INT          NOT NULL,
    [Status]             VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblSuspensionStatuses] PRIMARY KEY CLUSTERED ([SuspensionStatusID] ASC)
);

