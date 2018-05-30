
-- exec [dbo].[Dashboard_ExpiredItems_CompanyExpiredInsurance]  null, null, null
CREATE PROCEDURE [dbo].[Dashboard_ExpiredItems_CompanyExpiredInsurance] 
	@lobID int = NULL,
	@projectID int = NULL,
	@companyID int = NULL
AS
BEGIN 
	select itt.Type as InsuranceType, 
		   isnull(mytbl.NumberExpired, 0) as NumberExpired
	from (
	
		select it.InsuranceTypeID as InsuranceType, count(*) as NumberExpired
		  from tblInsuranceTypes it
		  join tblInsurances i on it.InsuranceTypeID = i.InsuranceTypeID
		  join tblCompanies c on i.CompanyId = c.CompanyID
		  join tblContracts ct on ct.CompanyID = c.CompanyID and 
								  ct.ContractEndDate>getdate() --and ct.ContractStatusID =
		  join tblContractProjects cp on cp.ContractID = ct.ContractID 
									 and cp.IsActive=1
		  join tblProjects p on p.ProjectID = cp.ProjectID -- and p.ProjectStatus
		  join tblLOBs l on l.LOBID=p.LOBID

		where i.ExpiryDate < getDate()
		  and c.CompanyStatusID  != 1   -- Not inactive
		  and COALESCE(@lobID,p.LOBID)=p.LOBID
		  and COALESCE(@projectID,p.ProjectID)=p.ProjectID
		  and COALESCE(@companyID,c.CompanyID)=c.CompanyID
	  
	 group by it.InsuranceTypeID
	 ) mytbl
	 right outer join tblInsuranceTypes itt on itt.insurancetypeid=mytbl.InsuranceType
END