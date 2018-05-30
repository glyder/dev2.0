CREATE TABLE [dbo].[tblEventLogs] (
    [EventLogID] INT           IDENTITY (1, 1) NOT NULL,
    [ID]         INT           NOT NULL,
    [PageName]   VARCHAR (50)  NULL,
    [FieldGroup] VARCHAR (30)  NOT NULL,
    [FieldName]  VARCHAR (120) NULL,
    [OldValue]   VARCHAR (MAX) NULL,
    [NewValue]   VARCHAR (MAX) NULL,
    [Action]     VARCHAR (50)  NULL,
    [CreatedBy]  VARCHAR (50)  NULL,
    [CreatedOn]  DATETIME      NULL,
    CONSTRAINT [PK_tblEventLogs] PRIMARY KEY CLUSTERED ([EventLogID] ASC)
);

