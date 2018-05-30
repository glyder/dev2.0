CREATE TABLE [dbo].[tblContractAttachments] (
    [ContractAttachmentID] INT           NOT NULL,
    [ContractID]           INT           NOT NULL,
    [AttachmentID]         INT           NOT NULL,
    [AttachmentTypeID]     INT           NULL,
    [FromDate]             DATETIME      NULL,
    [EditedBy]             VARCHAR (150) NULL,
    CONSTRAINT [PK_tblContractAttachments] PRIMARY KEY CLUSTERED ([ContractAttachmentID] ASC),
    CONSTRAINT [FK_tblContractAttachments_tblAttachmentTypes] FOREIGN KEY ([AttachmentTypeID]) REFERENCES [dbo].[tblAttachmentTypes] ([AttachmentTypeID]),
    CONSTRAINT [FK_tblContractAttachments_tblContracts] FOREIGN KEY ([ContractID]) REFERENCES [dbo].[tblContracts] ([ContractID])
);









