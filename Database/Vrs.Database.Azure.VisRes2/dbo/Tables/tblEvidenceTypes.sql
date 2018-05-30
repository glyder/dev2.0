CREATE TABLE [dbo].[tblEvidenceTypes] (
    [EvidenceTypeID] INT          NOT NULL,
    [Type]           VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblEvidenceTypes] PRIMARY KEY CLUSTERED ([EvidenceTypeID] ASC)
);

