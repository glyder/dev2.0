CREATE TABLE [dbo].[tblTrainingFields] (
    [TrainingFieldID] INT           IDENTITY (1, 1) NOT NULL,
    [TrainingField]   VARCHAR (120) NOT NULL,
    [EditedBy]        VARCHAR (150) NULL,
    [FromDate]        DATETIME      NULL,
    CONSTRAINT [PK_tblTrainingFields] PRIMARY KEY CLUSTERED ([TrainingFieldID] ASC)
);

