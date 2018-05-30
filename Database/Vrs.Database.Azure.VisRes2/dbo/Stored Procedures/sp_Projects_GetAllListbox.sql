
CREATE PROCEDURE [dbo].[sp_Projects_GetAllListbox] 
	@lobsID int = NULL
AS
BEGIN 
	SELECT 
		   ProjectID as [Value],
		   ProjectNumber + ' - ' + ProjectName as [Text] 
		   -- , 0 as [Selected]
	  FROM [dbo].[tblProjects]
	  where COALESCE(@lobsID, LOBID)= LOBID
	    and ProjectStatus = 'ACTIVE'
	  order by ProjectNumber
END