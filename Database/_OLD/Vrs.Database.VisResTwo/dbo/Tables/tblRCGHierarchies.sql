CREATE TABLE [dbo].[tblRCGHierarchies] (
    [RCGHierarchyID] INT           NOT NULL,
    [ParentRCG]      INT           NOT NULL,
    [ChildRCG]       INT           NOT NULL,
    [FromDate]       DATETIME      NOT NULL,
    [EditedBy]       VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblRCGHierarchies] PRIMARY KEY CLUSTERED ([RCGHierarchyID] ASC),
    CONSTRAINT [FK_tblRCGHierarchies_tblRCGroups] FOREIGN KEY ([ParentRCG]) REFERENCES [dbo].[tblRCGroups] ([RCGroupID]),
    CONSTRAINT [FK_tblRCGHierarchies_tblRCGroups1] FOREIGN KEY ([ChildRCG]) REFERENCES [dbo].[tblRCGroups] ([RCGroupID])
);



