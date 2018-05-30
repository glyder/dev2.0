CREATE TABLE [dbo].[tblProjectAddresses] (
    [ProjectAddressID] INT           NOT NULL,
    [ProjectID]        INT           NOT NULL,
    [AddressID]        INT           NOT NULL,
    [AddressTypeID]    INT           NOT NULL,
    [FromDate]         DATETIME      NULL,
    [EditedBy]         VARCHAR (150) NULL,
    CONSTRAINT [PK_tblProjectAddresses] PRIMARY KEY CLUSTERED ([ProjectAddressID] ASC),
    CONSTRAINT [FK_tblProjectAddresses_tblAddresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[tblAddresses] ([AddressID]),
    CONSTRAINT [FK_tblProjectAddresses_tblAddressTypes] FOREIGN KEY ([AddressTypeID]) REFERENCES [dbo].[tblAddressTypes] ([AddressTypeID]),
    CONSTRAINT [FK_tblProjectAddresses_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);







