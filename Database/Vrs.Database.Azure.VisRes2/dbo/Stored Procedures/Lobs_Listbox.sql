
CREATE PROCEDURE [dbo].[Lobs_Listbox] 
AS
BEGIN 
	SELECT [LOBID] as [Value],
		  [LOB] as [Text] --,
		  -- 0 as [Selected]
	  FROM [dbo].[tblLOBs]
END