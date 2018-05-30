CREATE TABLE [dbo].[tblCompanyAccreditationNotifications] (
    [CompanyAccreditationNotificationID] INT           NOT NULL,
    [CompanyAccreditationID]             INT           NOT NULL,
    [NotificationID]                     INT           NOT NULL,
    [FromDate]                           DATETIME      NOT NULL,
    [EditedBy]                           VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompanyAccreditationNotifications] PRIMARY KEY CLUSTERED ([CompanyAccreditationNotificationID] ASC),
    CONSTRAINT [FK_tblCompanyAccreditationNotifications_tblCompanyAccreditations] FOREIGN KEY ([CompanyAccreditationID]) REFERENCES [dbo].[tblCompanyAccreditations] ([CompanyAccreditationID]),
    CONSTRAINT [FK_tblCompanyAccreditationNotifications_tblNotifications] FOREIGN KEY ([CompanyAccreditationNotificationID]) REFERENCES [dbo].[tblNotifications] ([NotificationID])
);

