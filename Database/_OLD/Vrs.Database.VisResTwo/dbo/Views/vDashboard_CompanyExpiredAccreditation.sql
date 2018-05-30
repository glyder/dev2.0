CREATE VIEW [dbo].[vDashboard_CompanyExpiredAccreditation]
AS
	select ca.ExpiryDate, ca.CompanyID, ca.AccreditationLicencingID
	from dbo.tblCompanies c
	join dbo.tblCompanyAccreditations ca on ca.CompanyId = c.CompanyID
	where c.CompanyStatusID  != 1