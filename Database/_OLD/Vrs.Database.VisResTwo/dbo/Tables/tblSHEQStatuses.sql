CREATE TABLE [dbo].[tblSHEQStatuses] (
    [SHEQStatusID] INT           NOT NULL,
    [Status]       VARCHAR (120) NOT NULL,
    [Code]         VARCHAR (120) NULL,
    [DisplayName]  VARCHAR (120) NULL,
    CONSTRAINT [PK_tblSHEQStatuses] PRIMARY KEY CLUSTERED ([SHEQStatusID] ASC)
);



