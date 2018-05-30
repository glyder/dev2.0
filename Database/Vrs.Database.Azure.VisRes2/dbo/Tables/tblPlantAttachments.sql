CREATE TABLE [dbo].[tblPlantAttachments] (
    [PlantAttachmentID] INT IDENTITY (1, 1) NOT NULL,
    [PlantID]           INT NOT NULL,
    [AttachmentID]      INT NOT NULL,
    [AttachmentTypeID]  INT NULL,
    PRIMARY KEY CLUSTERED ([PlantAttachmentID] ASC),
    CONSTRAINT [FK_tblPlantAttachments_tblAttachments] FOREIGN KEY ([AttachmentID]) REFERENCES [dbo].[tblAttachments] ([AttachmentID]),
    CONSTRAINT [FK_tblPlantAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblPlantAttachments_tblPlants] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[tblPlants] ([PlantID])
);



