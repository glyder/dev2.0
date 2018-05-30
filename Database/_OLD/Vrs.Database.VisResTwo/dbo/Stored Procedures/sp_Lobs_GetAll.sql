
CREATE PROCEDURE[dbo].[sp_Lobs_GetAll] 
AS
BEGIN 
	SELECT [LOBID]
		  ,[LOB]
		  ,[FromDate]
		  ,[EditedBy]
		  ,[DivisionID]
	  FROM [dbo].[tblLOBs]
END