

CREATE PROCEDURE [dbo].[sp_Companies_AllPagedCount] 
  @PageNumber INT = 1,
  @PageSize	  INT = 100
AS
BEGIN
-- https://raresql.com/2015/03/30/sql-server-how-to-get-total-row-count-from-offset-fetch-next-paging/
 
	;WITH Main_CTE AS(
		SELECT [CompanyID],[CompanyName],[TradingName],[CompanyTypeID],[MainContactID],[PhoneNumber],[MobileNumber]
		  ,[FacsimileNumber],[EMailAddress],[ABN],[ACN],[AccountsReceivableContactID],[AccountsPayableContactID]
		  ,[EditedBy],[FromDate],[VENDOR_ID],[SEGMENT1],[LAST_UPDATE_DATE],[VENDOR_SITE_ID],[VENDOR_SITE_CODE]
		  ,[ADDRESS_LINE3],[OPERATING_UNIT],[CustomerNumber],[CustomerSite],[AdvanceCompanyID],[CompanyStatusID]
		  ,[DivisionID],[CountryID],[RTONumber]
		FROM [dbo].[tblCompanies]
	)
	, Count_CTE AS (
		SELECT COUNT(*) AS [TotalCount]
		FROM Main_CTE
	)
	SELECT *
	FROM Count_CTE, Main_CTE 
	ORDER BY Main_CTE.[CompanyID]	-- ORDER BY [CompanyID]
									-- ORDER BY LastName, FirstName
									-- ORDER BY FirstName DESC, EMail
    OFFSET @PageSize * (@PageNumber - 1) ROWS
    FETCH NEXT @PageSize ROWS ONLY OPTION (RECOMPILE);
END