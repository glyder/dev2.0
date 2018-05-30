--exec [dbo].[Individuals_ListboxPagedCount]  1, 1000
CREATE PROCEDURE [dbo].[Individuals_ListboxPagedCount] 
	@PageNumber INT = 1,
	@PageSize	INT = 1000,
	@lobID int = NULL,
	@projectID int = NULL,
	@companyID int = NULL
AS
BEGIN
-- https://raresql.com/2015/03/30/sql-server-how-to-get-total-row-count-from-offset-fetch-next-paging/
 
	;WITH Main_CTE AS(

		SELECT distinct i.IndividualID as [Value],					-- 1000 MAX INDIVIDUALS for listbox!
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
	)
	, Count_CTE AS (
		SELECT COUNT(*) AS [TotalCount]
		FROM Main_CTE
	)
	SELECT *
	FROM Count_CTE, Main_CTE 
	ORDER BY Main_CTE.[value]	-- ORDER BY [IndividualID]
									-- ORDER BY LastName, FirstName
									-- ORDER BY FirstName DESC, EMail
    OFFSET @PageSize * (@PageNumber - 1) ROWS
    FETCH NEXT @PageSize ROWS ONLY OPTION (RECOMPILE);
END