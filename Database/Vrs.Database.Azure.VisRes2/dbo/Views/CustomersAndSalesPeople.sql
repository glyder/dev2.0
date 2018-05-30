CREATE VIEW dbo.CustomersAndSalesPeople
WITH SCHEMABINDING
AS
	select i.InsuranceID,
			it.Type as InsuranceType, 
	  	   i.ExpiryDate
	from dbo.tblCompanies c
	join dbo.tblInsurances i on i.CompanyId = c.CompanyID
	join dbo.tblInsuranceTypes it on it.InsuranceTypeID = i.InsuranceTypeID
	where c.CompanyStatusID  != 1   -- NOt inactive
GO
CREATE UNIQUE CLUSTERED INDEX [cuq]
    ON [dbo].[CustomersAndSalesPeople]([InsuranceID] ASC, [InsuranceType] ASC, [ExpiryDate] ASC);

