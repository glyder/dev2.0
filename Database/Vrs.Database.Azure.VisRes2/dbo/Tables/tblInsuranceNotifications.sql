CREATE TABLE [dbo].[tblInsuranceNotifications] (
    [InsuranceNotificationID] INT           NOT NULL,
    [InsuranceID]             INT           NOT NULL,
    [NotificationID]          INT           NOT NULL,
    [FromDate]                DATETIME      NOT NULL,
    [EditedBy]                VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblInsuranceNotifications] PRIMARY KEY CLUSTERED ([InsuranceNotificationID] ASC),
    CONSTRAINT [FK_tblInsuranceNotifications_tblInsurances] FOREIGN KEY ([InsuranceID]) REFERENCES [dbo].[tblInsurances] ([InsuranceID]),
    CONSTRAINT [FK_tblInsuranceNotifications_tblNotifications] FOREIGN KEY ([NotificationID]) REFERENCES [dbo].[tblNotifications] ([NotificationID])
);

