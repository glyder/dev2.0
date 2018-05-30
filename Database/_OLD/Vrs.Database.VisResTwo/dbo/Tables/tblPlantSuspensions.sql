CREATE TABLE [dbo].[tblPlantSuspensions] (
    [PlantSuspensionID] INT           NOT NULL,
    [SuspensionID]      INT           NOT NULL,
    [PlantID]           INT           NOT NULL,
    [FromDate]          DATETIME      NOT NULL,
    [EditedBy]          VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblPlantSuspensions] PRIMARY KEY CLUSTERED ([PlantSuspensionID] ASC),
    CONSTRAINT [FK_tblPlantSuspensions_tblPlants] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[tblPlants] ([PlantID]),
    CONSTRAINT [FK_tblPlantSuspensions_tblSuspensions] FOREIGN KEY ([SuspensionID]) REFERENCES [dbo].[tblSuspensions] ([SuspensionID])
);



