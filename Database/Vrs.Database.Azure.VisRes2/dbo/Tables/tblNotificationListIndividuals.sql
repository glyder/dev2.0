CREATE TABLE [dbo].[tblNotificationListIndividuals] (
    [NotificationListIndividualID] INT           NOT NULL,
    [NotificationListID]           INT           NOT NULL,
    [IndividualID]                 INT           NOT NULL,
    [FromDate]                     DATETIME      NULL,
    [EditedBy]                     VARCHAR (150) NULL,
    CONSTRAINT [PK_tblNotificationListIndividuals] PRIMARY KEY CLUSTERED ([NotificationListIndividualID] ASC),
    CONSTRAINT [FK_tblNotificationListIndividuals_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);

