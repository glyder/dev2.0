CREATE PROCEDURE [dbo].[sp_Individuals_AllPagedCountSorting]
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
		SELECT [IndividualID],[FirstName],[OtherName],[PreferredName],[LastName]
			  ,[DateofBirth],[PhoneNumber],[MobileNumber],[EMailAddress]
			  ,[EditedBy],[FromDate] ,[IssuedDate] ,[ExpiryDate]  
			  ,[VentiaEmployeeID] ,[AdvanceUserID] ,[IndividualTypeID] ,[IndividualStatusID]
		  FROM [dbo].[tblIndividuals]
	WHERE (@SearchValue IS NULL OR [LastName] LIKE '%' + @SearchValue + '%') 
	
	ORDER BY
		CASE WHEN (@SortColumn = 'LastName' AND @SortOrder='ASC')
				THEN [LastName]
		END ASC,
		
		CASE WHEN (@SortColumn = 'LastName' AND @SortOrder='DESC')
				THEN [LastName]
		END DESC,
		
		CASE WHEN (@SortColumn = 'FirstName' AND @SortOrder='ASC')
				THEN [FirstName]
		END ASC,
		
		CASE WHEN (@SortColumn = 'FirstName' AND @SortOrder='DESC')
				THEN [FirstName]
		END DESC 

      OFFSET @PageSize * (@PageNumber - 1) ROWS
      FETCH NEXT @PageSize ROWS ONLY
	),
	CTE_TotalRows AS 
	(
		 select count([IndividualID]) as MaxRows 
		 from [tblIndividuals] 
		 WHERE (@SearchValue IS NULL OR [LastName] LIKE '%' + @SearchValue + '%')
	)

   Select MaxRows, t.[IndividualID], t.[FirstName], t.[LastName] 
     FROM [dbo].[tblIndividuals] as t, 
		  CTE_TotalRows 
	WHERE EXISTS (SELECT 1 FROM CTE_Results 
				   WHERE CTE_Results.[IndividualID] = t.[IndividualID])
   OPTION (RECOMPILE)

END