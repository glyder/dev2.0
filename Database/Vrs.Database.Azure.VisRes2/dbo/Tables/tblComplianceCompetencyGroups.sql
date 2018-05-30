CREATE TABLE [dbo].[tblComplianceCompetencyGroups] (
    [ComplianceCompetencyGroupID] INT           NOT NULL,
    [Name]                        VARCHAR (120) NOT NULL,
    [EditedBy]                    VARCHAR (150) NOT NULL,
    [FromDate]                    DATETIME      NOT NULL,
    CONSTRAINT [PK_tblComplianceCompetencyGroups] PRIMARY KEY CLUSTERED ([ComplianceCompetencyGroupID] ASC)
);

