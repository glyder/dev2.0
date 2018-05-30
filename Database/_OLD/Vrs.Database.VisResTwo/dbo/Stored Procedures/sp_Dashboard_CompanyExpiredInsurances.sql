
CREATE PROCEDURE [dbo].[sp_Dashboard_CompanyExpiredInsurances] 
	@LobsID int = NULL
AS
BEGIN 
	select it.Type as InsuranceType, count(*) as NumberExpired
	
	from tblCompanies c
	inner join tblInsurances i on i.CompanyId = c.CompanyID
	inner join tblInsuranceTypes it on it.InsuranceTypeID = i.InsuranceTypeID
	inner join tblContracts ct on ct.CompanyID = c.CompanyID
	inner join tblContractProjects cp on cp.ContractID = ct.ContractID
	inner join tblProjects p on p.ProjectID = cp.ProjectID
	where i.ExpiryDate < getDate()
	  and c.CompanyStatusID  != 1   -- NOt inactive
	  and COALESCE(@LobsID,p.LOBID)=p.LOBID
	 group by it.Type
	 order by it.Type
END