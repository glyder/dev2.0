
CREATE PROCEDURE [dbo].[sp_Lobs_GetAllListbox] 
AS
BEGIN 
	SELECT [LOBID] as [Value],
		  [LOB] as [Text] --,
		  -- 0 as [Selected]
	  FROM [dbo].[tblLOBs]
END