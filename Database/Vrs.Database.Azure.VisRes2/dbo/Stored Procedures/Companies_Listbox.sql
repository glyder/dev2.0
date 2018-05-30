-- exec [dbo].[Companies_Listbox] 7, 5
CREATE PROCEDURE [dbo].[Companies_Listbox] 
	@lobID int = NULL,
	@projectID int = NULL
AS
BEGIN 
	SELECT distinct c.[CompanyID] as [Value], c.[CompanyName] as [Text] --, ct.ContractID, p.ProjectID 
	  FROM [dbo].[tblCompanies] c
	  inner join tblContracts ct on ct.CompanyID = c.CompanyID 
						   -- and ct.ContractEndDate>getdate() 
						    --and ct.ContractStatusID=
	  left join tblContractProjects cp on cp.ContractID = ct.ContractID and cp.IsActive=1
	  left join tblProjects p on p.ProjectID = cp.ProjectID
						   -- and p.ProjectStatus
	 where COALESCE(@lobID,p.LOBID)=p.LOBID
	   and COALESCE(@projectID, p.ProjectID)=p.ProjectID
	   and c.CompanyStatusID  != 1   -- Not inactive
END