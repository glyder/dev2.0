CREATE TABLE [dbo].[tblSuspensionReasons] (
    [SuspensionReasonID] INT           NOT NULL,
    [Reason]             VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_tblSuspensionReasons] PRIMARY KEY CLUSTERED ([SuspensionReasonID] ASC)
);



