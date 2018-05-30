-- exec [Dashboard_ExpiredItems_CompanyInsuranceDue_List] 30, 1, null, null, null
CREATE PROCEDURE [dbo].[Dashboard_ExpiredItems_CompanyInsuranceDue_List] 
	@days int,
	@insuranceTypeID int, 

	@lobID int = NULL,
	@projectID int = NULL,
	@companyID int = NULL,

	@pageNumber INT = 1,
	@pageSize   INT = 100

AS
BEGIN 
	SET NOCOUNT ON;
	/**
	* This procedure will return a table of expried insurance records with associated data. The number of records are defined as due to expire between now and 
	* the number of days supplied.
	* Allows reuse in situations for 30, 60, or 90 days (or arbitrary) into the future.
	* 
	* Note that the counts may include the same Insurance record more than once. This is because the company may be contracted to more than 1 project etc. This
	* is OK since the higher count reflects a higher risk to the business.
	*/

	declare @expiryDate date = dateadd(dd, @days, getdate());

	select l.LOB, p.ProjectNumber, p.ProjectName, ct.ContractNo, c.CompanyName, c.ABN, i.InsuranceID, it.Type, i.ExpiryDate
	from tblInsuranceTypes it
	join tblInsurances i on it.InsuranceTypeID = i.InsuranceTypeID
	join tblCompanies c on i.CompanyID = c.CompanyID
	join tblContracts ct on ct.CompanyID = c.CompanyID and ct.ContractEndDate > cast(getdate() as date) --and ct.ContractStatusID=
	join tblContractProjects cp on cp.ContractID = ct.ContractID and cp.IsActive=1
	join tblProjects p on p.ProjectID = cp.ProjectID -- and p.ProjectStatus
	join tblLOBs l on l.LOBID=p.LOBID
	where i.ExpiryDate between cast(getDate() as date) and @expiryDate
	and it.InsuranceTypeID = @insuranceTypeID
	and c.CompanyStatusID  != 1   -- Not inactive
	and COALESCE(@lobID,p.LOBID)=p.LOBID
	and COALESCE(@projectID,p.ProjectID)=p.ProjectID
	and COALESCE(@companyID,c.CompanyID)=c.CompanyID
	group by l.LOB, p.ProjectNumber, p.ProjectName, ct.ContractNo, c.CompanyName, c.ABN, i.InsuranceID, it.Type, i.ExpiryDate
	order by l.LOB, p.ProjectNumber, c.CompanyName
	OFFSET @pageSize * (@pageNumber - 1) ROWS
    FETCH NEXT @pageSize ROWS ONLY OPTION (RECOMPILE);
END