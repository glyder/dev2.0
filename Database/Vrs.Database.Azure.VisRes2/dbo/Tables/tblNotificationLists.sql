CREATE TABLE [dbo].[tblNotificationLists] (
    [NotificationListID] INT           NOT NULL,
    [Name]               VARCHAR (120) NOT NULL,
    [NotificationTypeID] INT           NOT NULL,
    [FromDate]           DATETIME      NULL,
    [EditedBy]           VARCHAR (150) NULL,
    CONSTRAINT [PK_tblNotificationLists] PRIMARY KEY CLUSTERED ([NotificationListID] ASC)
);

