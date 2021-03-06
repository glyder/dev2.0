﻿CREATE TABLE [dbo].[tblProjects] (
    [ProjectID]               INT           IDENTITY (1, 1) NOT NULL,
    [ProjectName]             VARCHAR (255) NULL,
    [ManagerID]               INT           NULL,
    [ProjectLogoAttachmentID] INT           NULL,
    [ProjectNumber]           VARCHAR (50)  NULL,
    [MobileNumber]            VARCHAR (50)  NULL,
    [LOBID]                   INT           NULL,
    [PhoneNumber]             VARCHAR (50)  NULL,
    [FacsimileNumber]         VARCHAR (50)  NULL,
    [EmailAddress]            VARCHAR (255) NULL,
    [EditedBy]                VARCHAR (150) NULL,
    [ProjectCodeID]           INT           NULL,
    [ProjectManager]          VARCHAR (100) NULL,
    [ProjectManagerNumber]    VARCHAR (50)  NULL,
    [Region]                  VARCHAR (50)  NULL,
    [OrganisationId]          INT           NULL,
    [OrganisationCode]        VARCHAR (50)  NULL,
    [ProjectStatus]           VARCHAR (50)  NULL,
    [ProjectStartDate]        DATETIME      NULL,
    [ProjectCompletionDate]   DATETIME      NULL,
    [FromDate]                DATETIME      NULL,
    [ProjectSubStatusID]      INT           NULL,
    CONSTRAINT [PK_tblProjectDetails] PRIMARY KEY CLUSTERED ([ProjectID] ASC),
    CONSTRAINT [FK_tblProjects_tblCompanies] FOREIGN KEY ([OrganisationId]) REFERENCES [dbo].[tblCompanies] ([CompanyID]),
    CONSTRAINT [FK_tblProjects_tblIndividuals] FOREIGN KEY ([ManagerID]) REFERENCES [dbo].[tblIndividuals] ([IndividualID]),
    CONSTRAINT [FK_tblProjects_tblLOBs] FOREIGN KEY ([LOBID]) REFERENCES [dbo].[tblLOBs] ([LOBID]),
    CONSTRAINT [FK_tblProjects_tblProjectCodes] FOREIGN KEY ([ProjectCodeID]) REFERENCES [dbo].[tblProjectCodes] ([ProjectCodeID]),
    CONSTRAINT [FK_tblProjects_tblProjectSubStatuses] FOREIGN KEY ([ProjectSubStatusID]) REFERENCES [dbo].[tblProjectSubStatuses] ([ProjectSubStatusID])
);









