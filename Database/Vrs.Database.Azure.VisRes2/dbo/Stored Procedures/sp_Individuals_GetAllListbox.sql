
CREATE PROCEDURE [dbo].[sp_Individuals_GetAllListbox] 
	@lobsID int = NULL,
	@projectsID int = NULL,
	@companiesID int = NULL
AS
BEGIN 
	SELECT i.IndividualID as [Value],
		   i.FirstName + ' ' + i.LastName as [Text] 
		  -- , 0 as [Selected]
	  FROM [dbo].[tblIndividuals] i
	  left join tblCompanyIndividuals ci on ci.IndividualID = i.IndividualID 
	  left join tblCompanies c on c.CompanyID = ci.CompanyID
	  left join tblContracts ct on ct.CompanyID = c.CompanyID 
						   -- and ct.ContractEndDate>getdate() 
						    --and ct.ContractStatusID=
	  left join tblContractProjects cp on cp.ContractID = ct.ContractID and cp.IsActive=1
	  left join tblProjects p on p.ProjectID = cp.ProjectID
						   -- and p.ProjectStatus
	 where COALESCE(@lobsID,p.LOBID)=p.LOBID
	   and COALESCE(@projectsID,p.ProjectID)=p.ProjectID
	   and COALESCE(@companiesID, c.companyID)= c.CompanyID
	   and c.CompanyStatusID  != 1   -- Not inactive
END