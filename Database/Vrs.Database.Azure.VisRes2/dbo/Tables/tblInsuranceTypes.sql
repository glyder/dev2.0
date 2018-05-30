CREATE TABLE [dbo].[tblInsuranceTypes] (
    [InsuranceTypeID] INT           NOT NULL,
    [Type]            VARCHAR (255) NOT NULL,
    [IsMandatory]     BIT           NOT NULL,
    [EditedBy]        VARCHAR (150) NULL,
    [FromDate]        DATETIME      NULL,
    CONSTRAINT [PK_tblInsuranceTypes] PRIMARY KEY CLUSTERED ([InsuranceTypeID] ASC)
);

