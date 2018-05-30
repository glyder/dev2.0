CREATE TABLE [dbo].[tblSuspensionTypes] (
    [SuspensionTypeID] INT           NOT NULL,
    [Type]             VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_tblSuspensionTypes] PRIMARY KEY CLUSTERED ([SuspensionTypeID] ASC)
);

