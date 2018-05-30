
CREATE PROCEDURE[dbo].[Lobs_All] 
AS
BEGIN 
	SELECT [LOBID]
		  ,[LOB]
		  ,[FromDate]
		  ,[EditedBy]
		  ,[DivisionID]
	  FROM [dbo].[tblLOBs]
END