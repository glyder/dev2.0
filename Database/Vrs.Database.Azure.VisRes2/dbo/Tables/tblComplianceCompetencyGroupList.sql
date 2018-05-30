CREATE TABLE [dbo].[tblComplianceCompetencyGroupList] (
    [ComplianceCompetencyGroupListID] INT           NOT NULL,
    [ComplianceCompetencyGroupID]     INT           NOT NULL,
    [CompetencyID]                    INT           NOT NULL,
    [EditedBy]                        VARCHAR (150) NOT NULL,
    [FromDate]                        DATETIME      NOT NULL,
    CONSTRAINT [PK_tblComplianceCompetencyGroupList] PRIMARY KEY CLUSTERED ([ComplianceCompetencyGroupListID] ASC)
);

