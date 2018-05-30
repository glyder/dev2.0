
CREATE VIEW vDashboard_CompanyExpiredInsurances
WITH SCHEMABINDING
AS
	select i.ExpiryDate, it.Type as InsuranceType, i.InsuranceID
	from dbo.tblCompanies c
	join dbo.tblInsurances i on i.CompanyId = c.CompanyID
	join dbo.tblInsuranceTypes it on it.InsuranceTypeID = i.InsuranceTypeID
	where c.CompanyStatusID  != 1
GO
CREATE UNIQUE CLUSTERED INDEX [PK_Dashboard_CompanyExpiredInsurances_View]
    ON [dbo].[vDashboard_CompanyExpiredInsurances]([ExpiryDate] ASC, [InsuranceType] ASC, [InsuranceID] ASC);

