CREATE TABLE [dbo].[tblAddresses] (
    [AddressID]    INT           NOT NULL,
    [AddressLine1] VARCHAR (120) NULL,
    [AddressLine2] VARCHAR (120) NULL,
    [AddressLine3] VARCHAR (120) NULL,
    [Suburb]       VARCHAR (50)  NULL,
    [StateID]      INT           NULL,
    [PostCode]     VARCHAR (50)  NULL,
    [CountryID]    INT           NOT NULL,
    [FromDate]     DATETIME      NULL,
    [EditedBy]     VARCHAR (150) NULL,
    CONSTRAINT [PK_tblAddresses] PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [FK_tblAddresses_tblCountry] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[tblCountries] ([CountryID]),
    CONSTRAINT [FK_tblAddresses_tblStates] FOREIGN KEY ([StateID]) REFERENCES [dbo].[tblStates] ([StateID])
);









