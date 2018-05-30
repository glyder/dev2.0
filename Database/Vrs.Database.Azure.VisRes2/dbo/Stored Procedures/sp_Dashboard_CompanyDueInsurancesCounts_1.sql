
CREATE PROCEDURE [dbo].[sp_Dashboard_CompanyDueInsurancesCounts] 
	@fromDate date,
	@lobsID int = NULL,
	@projectID int = NULL,
	@companyID int = NULL

AS
BEGIN 
	select itt.InsuranceTypeID, itt.Type, isnull(mytbl.NumberExpired, 0)
	from (select it.InsuranceTypeID as InsuranceType, count(*) as NumberExpired
	
	from tblInsuranceTypes it
	join tblInsurances i on it.InsuranceTypeID = i.InsuranceTypeID
	join tblCompanies c on i.CompanyId = c.CompanyID
	join tblContracts ct on ct.CompanyID = c.CompanyID and ct.ContractEndDate>getdate() --and ct.ContractStatusID=
	join tblContractProjects cp on cp.ContractID = ct.ContractID and cp.IsActive=1
	join tblProjects p on p.ProjectID = cp.ProjectID -- and p.ProjectStatus
	join tblLOBs l on l.LOBID=p.LOBID

	where i.ExpiryDate > getDate()
	  and i.ExpiryDate <= @fromDate
	  and c.CompanyStatusID  != 1   -- Not inactive
	  and COALESCE(@lobsID,p.LOBID)=p.LOBID
	  and COALESCE(@projectID,p.ProjectID)=p.ProjectID
	  and COALESCE(@companyID,c.CompanyID)=c.CompanyID
	  
	 group by it.InsuranceTypeID
	 ) mytbl
	 right outer join tblInsuranceTypes itt on itt.insurancetypeid=mytbl.InsuranceType

END