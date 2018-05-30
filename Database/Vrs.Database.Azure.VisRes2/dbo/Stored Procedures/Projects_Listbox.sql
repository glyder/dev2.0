-- exec [dbo].[Projects_Listbox] 8
CREATE PROCEDURE [dbo].[Projects_Listbox] 
	@lobID int = NULL
AS
BEGIN 

	SELECT 
		   ProjectID as [Value],
		   ProjectNumber + ' - ' + ProjectName as [Text] 
		   -- , 0 as [Selected]
	  FROM [dbo].[tblProjects]
	  where COALESCE(@lobID, LOBID)= LOBID
	    and ProjectStatus = 'ACTIVE'
	  order by ProjectNumber
END