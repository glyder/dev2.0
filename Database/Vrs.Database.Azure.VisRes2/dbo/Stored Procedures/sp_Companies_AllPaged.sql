

CREATE PROCEDURE [dbo].[sp_Companies_AllPaged] -- ORDER BY [CompanyID]
  @PageNumber INT = 1,
  @PageSize   INT = 100
AS
BEGIN
  SET NOCOUNT ON;
 
  SELECT [CompanyID],[CompanyName],[TradingName],[CompanyTypeID],[MainContactID],[PhoneNumber],[MobileNumber]
      ,[FacsimileNumber],[EMailAddress],[ABN],[ACN],[AccountsReceivableContactID],[AccountsPayableContactID]
      ,[EditedBy],[FromDate],[VENDOR_ID],[SEGMENT1],[LAST_UPDATE_DATE],[VENDOR_SITE_ID],[VENDOR_SITE_CODE]
      ,[ADDRESS_LINE3],[OPERATING_UNIT],[CustomerNumber],[CustomerSite],[AdvanceCompanyID],[CompanyStatusID]
      ,[DivisionID],[CountryID],[RTONumber]
	FROM [dbo].[tblCompanies]
    ORDER BY [CompanyID]
    OFFSET @PageSize * (@PageNumber - 1) ROWS
    FETCH NEXT @PageSize ROWS ONLY OPTION (RECOMPILE);
END