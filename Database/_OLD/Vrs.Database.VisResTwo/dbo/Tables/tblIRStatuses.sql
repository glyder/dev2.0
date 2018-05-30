CREATE TABLE [dbo].[tblIRStatuses] (
    [IRStatusID]  INT           NOT NULL,
    [Status]      VARCHAR (120) NOT NULL,
    [Code]        VARCHAR (120) NULL,
    [DisplayName] VARCHAR (120) NULL,
    CONSTRAINT [PK_tblIRStatuses] PRIMARY KEY CLUSTERED ([IRStatusID] ASC)
);



