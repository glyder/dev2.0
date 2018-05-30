CREATE TABLE [dbo].[tblProjectCodes] (
    [ProjectCodeID] INT           IDENTITY (1, 1) NOT NULL,
    [ProjectCode]   VARCHAR (120) NOT NULL,
    [FromDate]      DATETIME      NULL,
    [EditedBy]      VARCHAR (150) NULL,
    CONSTRAINT [PK_tblProjectCodes] PRIMARY KEY CLUSTERED ([ProjectCodeID] ASC)
);

