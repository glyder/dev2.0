CREATE TABLE [dbo].[tblProjectNotifications] (
    [ProjectNotificationID] INT           NOT NULL,
    [ProjectID]             INT           NOT NULL,
    [NotificationID]        INT           NOT NULL,
    [FromDate]              DATETIME      NOT NULL,
    [EditedBy]              VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblProjectNotifications] PRIMARY KEY CLUSTERED ([ProjectNotificationID] ASC),
    CONSTRAINT [FK_tblProjectNotifications_tblNotifications] FOREIGN KEY ([NotificationID]) REFERENCES [dbo].[tblNotifications] ([NotificationID]),
    CONSTRAINT [FK_tblProjectNotifications_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);



