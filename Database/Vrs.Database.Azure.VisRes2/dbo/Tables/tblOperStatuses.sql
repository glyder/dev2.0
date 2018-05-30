CREATE TABLE [dbo].[tblOperStatuses] (
    [OperStatusID] INT           NOT NULL,
    [Status]       VARCHAR (120) NOT NULL,
    [Code]         VARCHAR (120) NULL,
    [DisplayName]  VARCHAR (120) NULL,
    CONSTRAINT [PK_tblOperStatuses] PRIMARY KEY CLUSTERED ([OperStatusID] ASC)
);

