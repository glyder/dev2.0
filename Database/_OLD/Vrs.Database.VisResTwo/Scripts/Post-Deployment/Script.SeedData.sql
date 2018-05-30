/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------

Pattern:
	INSERT INTO db1.dbo.TempTable  (List of columns here)
	SELECT (Same list of columns here) FROM db2.dbo.TempTable
*/

delete from [dbo].tblLOBs
go
delete from [dbo].[tblDivisions]
go
DBCC CHECKIDENT ('[dbo].[tblDivisions]', RESEED, 0);
GO
delete from [dbo].[tblOperationalStatuses]
go

insert into [dbo].[tblOperationalStatuses]
	Select [OperationalStatusID], 
		   [Status] 
      FROM [VisResTwo].[dbo].[tblOperationalStatuses]
go

insert into [dbo].[tblDivisions]
		   ([Name],
			[Description],
			[BrandingID],
			[OperationalStatusID],
			[FromDate],
			[EditedBy]
		   )
	select	[Name],
			[Description],
			[BrandingID],
			[OperationalStatusID],
			[FromDate],
			[EditedBy]
	 from [VisResTwo].[dbo].[tblDivisions]
go

insert into dbo.tblLOBs 
	select RegionID as LobID, 
		   Region as LOB, 
		   GETDATE() as fromDate, 
		   'system' as EditedBy, 
		   4 as OperationalStatusID, 
		   DivisionID
	  from [VisResTwo].dbo.tblLBOs





