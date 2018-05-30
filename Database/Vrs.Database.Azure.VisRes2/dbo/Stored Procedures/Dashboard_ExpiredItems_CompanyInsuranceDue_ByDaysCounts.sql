-- exec [dbo].[Dashboard_ExpiredItems_CompanyInsuranceDue_ByDaysCounts] 30, null, null, null
CREATE PROCEDURE [dbo].[Dashboard_ExpiredItems_CompanyInsuranceDue_ByDaysCounts] 
	@days int,

	@lobID int = NULL,
	@projectID int = NULL,
	@companyID int = NULL

AS
BEGIN 
	/**
	* This procedure will return a table of Insurance Types and the number of records due to expire between now and the number of days supplied.
	* Allows reuse in situations for 30, 60, or 90 days (or arbitrary) into the future.
	* 
	* Note that the counts may include the same Insureance record more than once. This is because the company may be contracted to more than 1 project etc. This
	* is OK since the higher count reflects a higher risk to the business.
	*/

	declare @expiryDate date = dateadd(dd, @days, getdate());

	select itt.InsuranceTypeID, 
		   itt.Type as InsuranceType, 
		   isnull(InsuranceCounts.NumberExpired, 0) as NumberExpired

	from ( 
		select it.InsuranceTypeID as InsuranceType, count(*) as NumberExpired
		from tblInsuranceTypes it
		join tblInsurances i on it.InsuranceTypeID = i.InsuranceTypeID
		join tblCompanies c on i.CompanyId = c.CompanyID
		join tblContracts ct on ct.CompanyID = c.CompanyID and ct.ContractEndDate > cast(getdate() as date) --and ct.ContractStatusID=
		join tblContractProjects cp on cp.ContractID = ct.ContractID and cp.IsActive=1
		join tblProjects p on p.ProjectID = cp.ProjectID -- and p.ProjectStatus
		join tblLOBs l on l.LOBID=p.LOBID
		where i.ExpiryDate between cast(getDate() as date) and @expiryDate
		and c.CompanyStatusID  != 1   -- Not Inactive
		and COALESCE(@lobID,p.LOBID)=p.LOBID
		and COALESCE(@projectID,p.ProjectID)=p.ProjectID
		and COALESCE(@companyID,c.CompanyID)=c.CompanyID
		 group by it.InsuranceTypeID
	 ) InsuranceCounts 
	 right outer join tblInsuranceTypes itt on itt.insurancetypeid=InsuranceCounts.InsuranceType

END