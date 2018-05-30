CREATE TABLE [dbo].[tblIndividualAddresses] (
    [IndividualAddressID] INT           NOT NULL,
    [IndividualID]        INT           NOT NULL,
    [AddressID]           INT           NOT NULL,
    [AddressTypeID]       INT           NOT NULL,
    [FromDate]            DATETIME      NOT NULL,
    [EditedBy]            VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblIndividualAddresses] PRIMARY KEY CLUSTERED ([IndividualAddressID] ASC),
    CONSTRAINT [FK_tblIndividualAddresses_tblAddresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[tblAddresses] ([AddressID]),
    CONSTRAINT [FK_tblIndividualAddresses_tblAddressTypes] FOREIGN KEY ([AddressTypeID]) REFERENCES [dbo].[tblAddressTypes] ([AddressTypeID]),
    CONSTRAINT [FK_tblIndividualAddresses_tblIndividuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID])
);

