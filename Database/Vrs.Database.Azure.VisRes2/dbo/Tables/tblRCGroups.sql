CREATE TABLE [dbo].[tblRCGroups] (
    [RCGroupID]   INT           NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [FromDate]    DATETIME      NOT NULL,
    [EditedBy]    VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblRCGroups] PRIMARY KEY CLUSTERED ([RCGroupID] ASC)
);

