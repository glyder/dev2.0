CREATE TABLE [dbo].[tblInsuranceSubStatuses] (
    [InsuranceSubStatusID] INT          NOT NULL,
    [SubStatus]            VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblInsuranceSubStatuses] PRIMARY KEY CLUSTERED ([InsuranceSubStatusID] ASC)
);

