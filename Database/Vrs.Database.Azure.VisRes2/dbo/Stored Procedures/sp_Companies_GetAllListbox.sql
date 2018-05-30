
CREATE PROCEDURE [dbo].[sp_Companies_GetAllListbox] 
	@lobsID int = NULL,
	@projectsID int = NULL
AS
BEGIN 
	SELECT c.[CompanyID] as [Value], c.[CompanyName] as [Text] 
	  FROM [dbo].[tblCompanies] c
	  left join tblContracts ct on ct.CompanyID = c.CompanyID 
						   -- and ct.ContractEndDate>getdate() 
						    --and ct.ContractStatusID=
	  left join tblContractProjects cp on cp.ContractID = ct.ContractID and cp.IsActive=1
	  left join tblProjects p on p.ProjectID = cp.ProjectID
						   -- and p.ProjectStatus
	 where COALESCE(@lobsID,p.LOBID)=p.LOBID
	   and COALESCE(@projectsID,p.ProjectID)=p.ProjectID
	   and c.CompanyStatusID  != 1   -- Not inactive
END