CREATE TABLE [dbo].[tblIndividualCompetencyAttachments] (
    [IndividualCompetencyAttachmentID] INT NOT NULL,
    [IndividualCompetencyID]           INT NOT NULL,
    [AttachmentID]                     INT NOT NULL,
    [AttachmentTypeID]                 INT NULL,
    CONSTRAINT [PK_tblIndividualCompetencyAttachments] PRIMARY KEY CLUSTERED ([IndividualCompetencyAttachmentID] ASC),
    CONSTRAINT [FK_tblIndividualCompetencyAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblIndividualCompetencyAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblIndividualCompetencyAttachments_tblIndividualCompetencies] FOREIGN KEY ([IndividualCompetencyID]) REFERENCES [dbo].[tblIndividualCompetencies] ([IndividualCompetencyID])
);

