CREATE TABLE [dbo].[tblLOBs] (
    [LOBID]      INT           NOT NULL,
    [LOB]        VARCHAR (120) NOT NULL,
    [FromDate]   DATETIME      NULL,
    [EditedBy]   VARCHAR (150) NULL,
    [DivisionID] INT           NOT NULL,
    CONSTRAINT [PK_tblLobs] PRIMARY KEY CLUSTERED ([LOBID] ASC),
    CONSTRAINT [FK_tblLOBs_tblDivisions] FOREIGN KEY ([DivisionID]) REFERENCES [dbo].[tblDivisions] ([DivisionID])
);







