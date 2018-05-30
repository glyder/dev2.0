CREATE TABLE [dbo].[tblUsers] (
    [UserID]               INT           IDENTITY (1, 1) NOT NULL,
    [UserName]             VARCHAR (120) NOT NULL,
    [IndividualID]         INT           NULL,
    [UserLevelID]          INT           NOT NULL,
    [FullName]             VARCHAR (100) NULL,
    [LastName]             VARCHAR (100) NULL,
    [Password]             VARCHAR (50)  NULL,
    [Phone]                VARCHAR (50)  NULL,
    [Email]                VARCHAR (120) NULL,
    [Location]             VARCHAR (120) NULL,
    [EditedBy]             VARCHAR (120) NOT NULL,
    [FromDate]             DATETIME      NOT NULL,
    [PasswordExpiryDaysID] INT           NULL,
    [ForcePasswordChange]  BIT           NULL,
    [PasswordChangedOn]    DATETIME      NULL,
    [IsMultiCompanyUser]   BIT           NULL,
    CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [FK_tblUsers_tblUserLevels] FOREIGN KEY ([UserLevelID]) REFERENCES [dbo].[tblUserLevels] ([UserLevelID])
);





