CREATE TABLE [dbo].[tblIndividuals] (
    [IndividualID]          INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]             VARCHAR (50)  NULL,
    [OtherName]             VARCHAR (50)  NULL,
    [PreferredName]         VARCHAR (50)  NULL,
    [LastName]              VARCHAR (50)  NULL,
    [DateofBirth]           DATETIME      NULL,
    [PhoneNumber]           VARCHAR (50)  NULL,
    [MobileNumber]          VARCHAR (50)  NULL,
    [EMailAddress]          VARCHAR (120) NULL,
    [EditedBy]              VARCHAR (150) NULL,
    [FromDate]              DATETIME      NULL,
    [IssuedDate]            DATETIME      NULL,
    [ExpiryDate]            DATETIME      NULL,
    [VentiaEmployeeID]      VARCHAR (20)  NULL,
    [AdvanceUserID]         INT           NULL,
    [IndividualTypeID]      INT           NULL,
    [IndividualStatusID]    INT           NULL,
    [IndividualSubStatusID] INT           NULL,
    CONSTRAINT [PK_tblIndividuals] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_tblIndividuals_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblIndividuals_tblIndividualStatuses] FOREIGN KEY ([IndividualStatusID]) REFERENCES [dbo].[tblIndividualStatuses] ([IndividualStatusID]),
    CONSTRAINT [FK_tblIndividuals_tblIndividualSubStatuses] FOREIGN KEY ([IndividualSubStatusID]) REFERENCES [dbo].[tblIndividualSubStatuses] ([IndividualSubStatusID]),
    CONSTRAINT [FK_tblIndividuals_tblIndividualTypes] FOREIGN KEY ([IndividualTypeID]) REFERENCES [dbo].[tblIndividualTypes] ([IndividualTypeID])
);









