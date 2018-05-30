CREATE TABLE [dbo].[tblNotificationTypes] (
    [NotificationTypeID]     INT           NOT NULL,
    [Type]                   VARCHAR (255) NOT NULL,
    [NotificationCategoryID] INT           NOT NULL,
    CONSTRAINT [PK_tblNotificationTypes] PRIMARY KEY CLUSTERED ([NotificationTypeID] ASC),
    CONSTRAINT [FK_tblNotificationTypes_tblNotificationCategories] FOREIGN KEY ([NotificationCategoryID]) REFERENCES [dbo].[tblNotificationCategories] ([NotificationCategoryID])
);

