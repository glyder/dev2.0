CREATE TABLE [dbo].[tblUserMatrix] (
    [UserMatrixID]           TINYINT       IDENTITY (1, 1) NOT NULL,
    [Function]               VARCHAR (255) NOT NULL,
    [System Administrator]   BIT           NULL,
    [Regional Administrator] BIT           NULL,
    [Project Manager]        BIT           NULL,
    [Project Administrator]  BIT           NULL,
    [Project User]           BIT           NULL,
    [Company Manager]        BIT           NULL,
    [Company Administrator]  BIT           NULL,
    [EditedBy]               VARCHAR (120) NULL,
    [FromDate]               DATETIME      NULL,
    [EOS]                    BIT           NULL,
    [National Administrator] BIT           NULL,
    CONSTRAINT [PK_tblUserMatrixs] PRIMARY KEY CLUSTERED ([UserMatrixID] ASC)
);



