CREATE TABLE [dbo].[tblPlantComments] (
    [PlantCommentID] INT           IDENTITY (1, 1) NOT NULL,
    [Comment]        VARCHAR (MAX) NOT NULL,
    [EditedBy]       VARCHAR (150) NOT NULL,
    [FromDate]       DATETIME      NOT NULL,
    [PlantID]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([PlantCommentID] ASC),
    CONSTRAINT [FK_tblPlantComments_tblPlants] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[tblPlants] ([PlantID])
);

