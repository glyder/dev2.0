CREATE TABLE [dbo].[tblPlantTypes] (
    [PlantTypeID]     INT           IDENTITY (1, 1) NOT NULL,
    [Type]            VARCHAR (50)  NOT NULL,
    [TypeDescription] VARCHAR (255) NULL,
    [EditedBy]        VARCHAR (150) NULL,
    [FromDate]        DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([PlantTypeID] ASC)
);







