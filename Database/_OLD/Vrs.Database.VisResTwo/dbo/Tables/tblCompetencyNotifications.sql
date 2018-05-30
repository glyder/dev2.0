CREATE TABLE [dbo].[tblCompetencyNotifications] (
    [CompetencyNotificationID] INT           NOT NULL,
    [CompetencyID]             INT           NOT NULL,
    [NotificationID]           INT           NOT NULL,
    [FromDate]                 DATETIME      NOT NULL,
    [EditedBy]                 VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompetencyNotifications] PRIMARY KEY CLUSTERED ([CompetencyNotificationID] ASC),
    CONSTRAINT [FK_tblCompetencyNotifications_tblCompetencies] FOREIGN KEY ([CompetencyID]) REFERENCES [dbo].[tblCompetencies] ([CompetencyID]),
    CONSTRAINT [FK_tblCompetencyNotifications_tblNotifications] FOREIGN KEY ([NotificationID]) REFERENCES [dbo].[tblNotifications] ([NotificationID])
);



