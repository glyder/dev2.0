CREATE TABLE [dbo].[tblNotifications] (
    [NotificationID]     INT           NOT NULL,
    [Message]            VARCHAR (MAX) NULL,
    [IndividualID]       INT           NULL,
    [NotificationListID] INT           NULL,
    [NotificationTypeID] INT           NOT NULL,
    [FromDate]           DATETIME      NOT NULL,
    [EditedBy]           VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblNotifications] PRIMARY KEY CLUSTERED ([NotificationID] ASC),
    CONSTRAINT [FK_tblNotifications_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblNotifications_tblNotificationLists] FOREIGN KEY ([NotificationListID]) REFERENCES [dbo].[tblNotificationLists] ([NotificationListID]),
    CONSTRAINT [FK_tblNotifications_tblNotificationTypes] FOREIGN KEY ([NotificationTypeID]) REFERENCES [dbo].[tblNotificationTypes] ([NotificationTypeID])
);

