-- exec [dbo].[Individuals_Listbox]   7, 5, 1
CREATE PROCEDURE [dbo].[Individuals_Listbox] 
	@lobID int = NULL,
	@projectID int = NULL,
	@companyID int = NULL
AS
BEGIN 
	SELECT distinct top 1000 i.IndividualID as [Value],					-- 1000 MAX INDIVIDUALS for listbox!
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
	 where COALESCE(@lobID,p.LOBID)=p.LOBID
	   and COALESCE(@projectID,p.ProjectID)=p.ProjectID
	   and COALESCE(@companyID, c.companyID)= c.CompanyID
	   and c.CompanyStatusID  != 1   -- Not inactive
END