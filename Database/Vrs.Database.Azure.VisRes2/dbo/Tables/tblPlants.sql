CREATE TABLE [dbo].[tblPlants] (
    [PlantID]            INT           IDENTITY (1, 1) NOT NULL,
    [PlantName]          VARCHAR (50)  NULL,
    [PlantDescription]   VARCHAR (255) NULL,
    [PlantMake]          VARCHAR (50)  NULL,
    [PlantModel]         VARCHAR (50)  NULL,
    [VIN]                VARCHAR (50)  NULL,
    [YearOfManufacture]  VARCHAR (10)  NULL,
    [RegistrationNumber] VARCHAR (50)  NULL,
    [RegistrationExpiry] DATETIME      NULL,
    [BaseLocation]       VARCHAR (50)  NULL,
    [CurrentLocation]    VARCHAR (50)  NULL,
    [IsAvailable]        BIT           NULL,
    [CanMobilise]        BIT           NULL,
    [EditedBy]           VARCHAR (150) NULL,
    [FromDate]           DATETIME      NULL,
    [PlantTypeID]        INT           NOT NULL,
    [CompanyID]          INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([PlantID] ASC),
    CONSTRAINT [FK_tblPlants_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblPlants_tblPlantTypes] FOREIGN KEY ([PlantTypeID]) REFERENCES [dbo].[tblPlantTypes] ([PlantTypeID])
);

