CREATE TABLE [dbo].[tblProjectIntegrations] (
    [ProjectIntegrationID] INT           NOT NULL,
    [ProjectID]            INT           NOT NULL,
    [IntegratedSystem]     VARCHAR (255) NOT NULL,
    [Key]                  VARCHAR (255) NOT NULL,
    [Value]                VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_tblProjectIntegrations] PRIMARY KEY CLUSTERED ([ProjectIntegrationID] ASC),
    CONSTRAINT [FK_tblProjectIntegrations_tblProjects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tblProjects] ([ProjectID])
);

