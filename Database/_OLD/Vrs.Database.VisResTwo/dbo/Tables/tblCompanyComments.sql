CREATE TABLE [dbo].[tblCompanyComments] (
    [CompanyCommentID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]        INT           NOT NULL,
    [CommentNo]        INT           NULL,
    [Comment]          VARCHAR (MAX) NULL,
    [AttachmentID]     INT           NULL,
    [FromDate]         DATETIME      NOT NULL,
    [EditedBy]         VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tblCompanyComments] PRIMARY KEY CLUSTERED ([CompanyCommentID] ASC),
    CONSTRAINT [FK_tblCompanyComments_tblCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tblCompanies] ([CompanyID])
);



