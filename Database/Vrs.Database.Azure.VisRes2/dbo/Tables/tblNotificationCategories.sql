CREATE TABLE [dbo].[tblNotificationCategories] (
    [NotificationCategoryID] INT           NOT NULL,
    [Category]               VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_tblNotificationCategory] PRIMARY KEY CLUSTERED ([NotificationCategoryID] ASC)
);

