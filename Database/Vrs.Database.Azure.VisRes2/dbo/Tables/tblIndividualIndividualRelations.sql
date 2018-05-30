CREATE TABLE [dbo].[tblIndividualIndividualRelations] (
    [IndividualIndividualRelationID] INT          NOT NULL,
    [Relation]                       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblIndividualIndividualRelations] PRIMARY KEY CLUSTERED ([IndividualIndividualRelationID] ASC)
);

