CREATE TABLE [dbo].[tblIndividualIndividual] (
    [IndividualIndividualID] INT           NOT NULL,
    [MainIndividualID]       INT           NOT NULL,
    [RelatedIndividualID]    INT           NOT NULL,
    [RelationshipID]         INT           NOT NULL,
    [RelationshipTypeID]     INT           NOT NULL,
    [FromDate]               DATETIME      NOT NULL,
    [EditedBy]               VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblIndividualIndividual] PRIMARY KEY CLUSTERED ([IndividualIndividualID] ASC),
    CONSTRAINT [FK_tblIndividualIndividual_tblIndividualIndividualRelations] FOREIGN KEY ([RelationshipID]) REFERENCES [dbo].[tblIndividualIndividualRelations] ([IndividualIndividualRelationID]),
    CONSTRAINT [FK_tblIndividualIndividual_tblIndividualRelationshipTypes] FOREIGN KEY ([RelationshipTypeID]) REFERENCES [dbo].[tblIndividualRelationshipTypes] ([IndividualRelationshipTypeID]),
    CONSTRAINT [FK_tblIndividualIndividual_tblIndividuals] FOREIGN KEY ([MainIndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblIndividualIndividual_tblIndividuals1] FOREIGN KEY ([RelatedIndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);

