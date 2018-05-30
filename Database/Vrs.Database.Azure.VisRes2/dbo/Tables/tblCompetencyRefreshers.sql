CREATE TABLE [dbo].[tblCompetencyRefreshers] (
    [CompetencyRefresherID] INT NOT NULL,
    [CompetencyID]          INT NOT NULL,
    [RefresherCompetencyID] INT NOT NULL,
    [ProjectID]             INT NULL,
    [ProjectRoleID]         INT NULL,
    [TimePeriodTypeID]      INT NOT NULL,
    [RefresherTimePeriod]   INT NOT NULL,
    CONSTRAINT [PK_tblCompetencyRefreshers] PRIMARY KEY CLUSTERED ([CompetencyRefresherID] ASC),
    CONSTRAINT [FK_tblCompetencyRefreshers_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblCompetencyRefreshers_tblProjectRoles] FOREIGN KEY ([ProjectRoleID]) REFERENCES [dbo].[tblProjectRoles] ([ProjectRoleID]),
    CONSTRAINT [FK_tblCompetencyRefreshers_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID]),
    CONSTRAINT [FK_tblCompetencyRefreshers_tblTimePeriodTypes] FOREIGN KEY ([TimePeriodTypeID]) REFERENCES [dbo].[tblTimePeriodTypes] ([TimePeriodTypeID])
);

