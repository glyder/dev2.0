CREATE TABLE [dbo].[tblIndividualRelationshipTypes] (
    [IndividualRelationshipTypeID] INT          NOT NULL,
    [Type]                         VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblIndividualRelationshipTypes] PRIMARY KEY CLUSTERED ([IndividualRelationshipTypeID] ASC)
);



