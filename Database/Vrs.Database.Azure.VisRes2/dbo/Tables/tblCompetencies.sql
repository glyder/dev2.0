CREATE TABLE [dbo].[tblCompetencies] (
    [CompetencyID]       INT           NOT NULL,
    [Code]               VARCHAR (50)  NULL,
    [Name]               VARCHAR (255) NOT NULL,
    [Description]        VARCHAR (MAX) NULL,
    [CompetencyTypeID]   INT           NOT NULL,
    [ParentCompetencyID] INT           NULL,
    [FromDate]           DATETIME      NULL,
    [EditedBy]           VARCHAR (150) NULL,
    [LegacyCompetencyID] INT           NULL,
    [TimePeriodTypeID]   INT           NULL,
    [ExpiryTimePeriod]   INT           NULL,
    CONSTRAINT [PK_tblCompetencies] PRIMARY KEY CLUSTERED ([CompetencyID] ASC),
    CONSTRAINT [FK_tblCompetencies_tblCompetencies] FOREIGN KEY ([ParentCompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblCompetencies_tblCompetencyTypes] FOREIGN KEY ([CompetencyTypeID]) REFERENCES [dbo].[tblCompetencyTypes] ([CompetencyTypeID]),
    CONSTRAINT [FK_tblCompetencies_tblTimePeriodTypes] FOREIGN KEY ([TimePeriodTypeID]) REFERENCES [dbo].[tblTimePeriodTypes] ([TimePeriodTypeID])
);





