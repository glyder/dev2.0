-- exec [dbo].[Companies_AllPagedCountSorting] null, 1, 100, 'CompanyName', 'ASC'
CREATE PROCEDURE [dbo].[Companies_AllPagedCountSorting]
(
	@SearchValue NVARCHAR(50) = NULL,
	@PageNumber INT = 1,
	@PageSize INT = 100,
	@SortColumn NVARCHAR(20) = 'CompanyName',
	@SortOrder NVARCHAR(20) = 'ASC'
)
 AS BEGIN
 SET NOCOUNT ON;

 -- https://dotnetdaily.net/featured/fast-sql-server-stored-procedure-with-filtering-sorting-and-paging

 SET @SearchValue = LTRIM(RTRIM(@SearchValue))

 ; WITH CTE_Results AS 
   (
    SELECT [CompanyID],[CompanyName],[TradingName],[CompanyTypeID],[MainContactID],[PhoneNumber],[MobileNumber]
		  ,[FacsimileNumber],[EMailAddress],[ABN],[ACN],[AccountsReceivableContactID],[AccountsPayableContactID]
		  ,[EditedBy],[FromDate],[VENDOR_ID],[SEGMENT1],[LAST_UPDATE_DATE],[VENDOR_SITE_ID],[VENDOR_SITE_CODE]
		  ,[ADDRESS_LINE3],[OPERATING_UNIT],[CustomerNumber],[CustomerSite],[AdvanceCompanyID],[CompanyStatusID]
		  ,[DivisionID],[CountryID],[RTONumber]
		FROM [dbo].[tblCompanies]
	WHERE (@SearchValue IS NULL OR [CompanyName] LIKE '%' + @SearchValue + '%') 
	
	ORDER BY
		CASE WHEN (@SortColumn = 'CompanyName' AND @SortOrder='ASC')
				THEN [CompanyName]
		END ASC,
		
		CASE WHEN (@SortColumn = 'CompanyName' AND @SortOrder='DESC')
				THEN [CompanyName]
		END DESC,
		
		CASE WHEN (@SortColumn = 'TradingName' AND @SortOrder='ASC')
				THEN [TradingName]
		END ASC,
		
		CASE WHEN (@SortColumn = 'TradingName' AND @SortOrder='DESC')
				THEN [TradingName]
		END DESC 

      OFFSET @PageSize * (@PageNumber - 1) ROWS
      FETCH NEXT @PageSize ROWS ONLY
	),
	CTE_TotalRows AS 
	(
		 select count([CompanyID]) as MaxRows 
		 from [tblCompanies] 
		 WHERE (@SearchValue IS NULL OR [CompanyName] LIKE '%' + @SearchValue + '%')
	)

   Select MaxRows, 
		  t.[CompanyID], t.[CompanyName], t.[TradingName] 
     FROM [dbo].[tblCompanies] as t, 
		  CTE_TotalRows 
		  WHERE EXISTS (SELECT 1 FROM CTE_Results 
						 WHERE CTE_Results.[CompanyID] = t.[CompanyID])
   OPTION (RECOMPILE)

END