-- exec [dbo].[Individuals_AllPagedCount] 1, 100
CREATE PROCEDURE [dbo].[Individuals_AllPagedCount] 
  @PageNumber INT = 1,
  @PageSize	  INT = 100
AS
BEGIN
-- https://raresql.com/2015/03/30/sql-server-how-to-get-total-row-count-from-offset-fetch-next-paging/
 
	;WITH Main_CTE AS(

		SELECT [IndividualID],[FirstName],[OtherName],[PreferredName],[LastName]
			  ,[DateofBirth],[PhoneNumber],[MobileNumber],[EMailAddress]
			  ,[EditedBy],[FromDate] ,[IssuedDate] ,[ExpiryDate]  
			  ,[VentiaEmployeeID] ,[AdvanceUserID] ,[IndividualTypeID] ,[IndividualStatusID]
		  FROM [dbo].[tblIndividuals]
	)
	, Count_CTE AS (
		SELECT COUNT(*) AS [TotalCount]
		FROM Main_CTE
	)
	SELECT *
	FROM Count_CTE, Main_CTE 
	ORDER BY Main_CTE.[LastName]	-- ORDER BY [IndividualID]
									-- ORDER BY LastName, FirstName
									-- ORDER BY FirstName DESC, EMail
    OFFSET @PageSize * (@PageNumber - 1) ROWS
    FETCH NEXT @PageSize ROWS ONLY OPTION (RECOMPILE);
END