CREATE TABLE [dbo].[tblEOI] (
    [EOIID]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NOT NULL,
    [ProjectID]   INT           NULL,
    [Description] VARCHAR (250) NULL,
    [FromDate]    DATETIME      NULL,
    [EditedBy]    VARCHAR (150) NULL,
    CONSTRAINT [PK_tblEOI] PRIMARY KEY CLUSTERED ([EOIID] ASC),
    CONSTRAINT [FK_tblEOI_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);







