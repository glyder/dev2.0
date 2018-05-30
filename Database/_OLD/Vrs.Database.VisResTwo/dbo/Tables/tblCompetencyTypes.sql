CREATE TABLE [dbo].[tblCompetencyTypes] (
    [CompetencyTypeID]      INT           NOT NULL,
    [Type]                  VARCHAR (120) NOT NULL,
    [ComplianceContributed] BIT           NOT NULL,
    [FromDate]              DATETIME      NULL,
    [EditedBy]              VARCHAR (150) NULL,
    CONSTRAINT [PK_tblCompetencyTypes] PRIMARY KEY CLUSTERED ([CompetencyTypeID] ASC)
);







