CREATE TABLE [dbo].[tblCompanyPlants] (
    [CompanyPlantID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]      INT           NOT NULL,
    [PlantID]        INT           NOT NULL,
    [Comments]       VARCHAR (MAX) NULL,
    [EditedBy]       VARCHAR (150) NULL,
    [FromDate]       DATETIME      NULL,
    CONSTRAINT [PK_tblCompanyPlants] PRIMARY KEY CLUSTERED ([CompanyPlantID] ASC),
    CONSTRAINT [FK_tblCompanyPlants_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblCompanyPlants_tblPlants] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[tblPlants] ([PlantID])
);

