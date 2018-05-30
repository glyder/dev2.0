CREATE TABLE [dbo].[tblPlantInsurances] (
    [PlantInsuranceID] INT NOT NULL,
    [PlantID]          INT NOT NULL,
    [InsuranceID]      INT NOT NULL,
    CONSTRAINT [PK_tblPlantInsurances] PRIMARY KEY CLUSTERED ([PlantInsuranceID] ASC),
    CONSTRAINT [FK_tblPlantInsurances_tblInsurances] FOREIGN KEY ([InsuranceID]) REFERENCES [dbo].[tblInsurances] ([InsuranceID]),
    CONSTRAINT [FK_tblPlantInsurances_tblPlants] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[tblPlants] ([PlantID])
);

