DROP TABLE IF EXISTS [dbo].[SMChoice]
GO

DROP TABLE IF EXISTS [dbo].[SMQuestion]  
GO

DROP TABLE IF EXISTS [dbo].[SMPage]
GO

DROP TABLE IF EXISTS [dbo].[SMRecipient]
GO

DROP TABLE IF EXISTS [dbo].[SMCollector]
GO

DROP TABLE IF EXISTS [dbo].[SMSurvey]
GO

DROP TABLE IF EXISTS [dbo].[SMResponse]
GO



CREATE TABLE [dbo].[SMSurvey](
	[Id] INT NOT NULL IDENTITY (1,1),
	[SurveyEntityId] [varchar](50) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Category] [varchar](200) NULL,
	[QuestionCount] [int] NOT NULL,
	[PageCount] [int] NOT NULL,
	[ResponseCount] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL
	CONSTRAINT PK_SMSurvey_Id PRIMARY KEY (Id)
)
GO

CREATE UNIQUE NONCLUSTERED INDEX UNCI_SurveyEntityId
ON [dbo].[SMSurvey] ([SurveyEntityId] ASC)
GO

CREATE TABLE [dbo].[SMCollector](
	[Id] INT NOT NULL IDENTITY (1,1),
	[CollectorEntityId] [varchar](50) NOT NULL,
	[SMSurveyId] INT NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	CONSTRAINT PK_SMCollector_Id PRIMARY KEY (Id)
)
GO

CREATE UNIQUE NONCLUSTERED INDEX UNCI_CollectorEntityId
ON [dbo].[SMCollector] ([CollectorEntityId] ASC)
GO

ALTER TABLE [dbo].[SMCollector]  WITH CHECK ADD FOREIGN KEY([SMSurveyId])
REFERENCES [dbo].[SMSurvey] ([Id]) ON DELETE CASCADE
GO

CREATE TABLE [dbo].[SMRecipient](
	[Id] INT NOT NULL IDENTITY (1,1),
	[RecipientEntityId] [varchar](50) NOT NULL,
	[SMCollectorId] INT NOT NULL,
	[Email] [varchar](50) NOT NULL,
    [PhoneNumber] [varchar](50) NULL,
	CONSTRAINT PK_SMRecipient_Id PRIMARY KEY (Id)
)
GO

ALTER TABLE [dbo].[SMRecipient]  WITH CHECK ADD FOREIGN KEY([SMCollectorId])
REFERENCES [dbo].[SMCollector] ([Id]) ON DELETE CASCADE
GO

CREATE TABLE [dbo].[SMPage](
	[Id] INT NOT NULL IDENTITY (1,1),
	[PageEntityId] [varchar](50) NOT NULL,
	[SMSurveyId] INT NOT NULL,
	[Title] [varchar](200) NOT NULL,
	[Description] [varchar](200) NULL,
	[QuestionCount] [int] NOT NULL,
	[Order] [int] NOT NULL,
	CONSTRAINT PK_SMPage_Id PRIMARY KEY (Id)
)
GO

ALTER TABLE [dbo].[SMPage]  WITH CHECK ADD FOREIGN KEY([SMSurveyId])
REFERENCES [dbo].[SMSurvey] ([Id]) ON DELETE CASCADE
GO

CREATE TABLE [dbo].[SMQuestion](
	[Id] INT NOT NULL IDENTITY (1,1),
	[QuestionEntityId] [varchar](50) NOT NULL,
	[SMPageId] INT NOT NULL,
	[QuestionType] [varchar](200) NULL,
	[Question] [varchar](200) NULL,
	[Order] [int] NOT NULL,
	CONSTRAINT PK_SMQuestion_Id PRIMARY KEY (Id)
)
GO

ALTER TABLE [dbo].[SMQuestion]  WITH CHECK ADD FOREIGN KEY([SMPageId])
REFERENCES [dbo].[SMPage] ([Id]) ON DELETE CASCADE
GO

CREATE TABLE [dbo].[SMChoice](
	[Id] INT NOT NULL IDENTITY (1,1),
	[ChoiceEntityId] [varchar](50) NOT NULL,
	[SMQuestionId] INT NOT NULL,
	[Name] [varchar](200) NULL,
	[Order] [int] NOT NULL,
	CONSTRAINT PK_SMChoice_Id PRIMARY KEY (Id)
)
GO

ALTER TABLE [dbo].[SMChoice]  WITH CHECK ADD FOREIGN KEY([SMQuestionId])
REFERENCES [dbo].[SMQuestion] ([Id])
GO


  CREATE TABLE [dbo].[SMResponse](
	[Id] BIGINT NOT NULL IDENTITY (1,1),

	[Status] [varchar](20) NOT NULL,
	[IpAddress] [varchar](20) NOT NULL,
	[SurveyEntityId] [varchar](50) NOT NULL,
	[CollectorEntityId] [varchar](50) NOT NULL,
	[RecipientEntityId] [varchar](50) NOT NULL,
	[PageEntityId] [varchar](50) NOT NULL,
	[QuestionEntityId] [varchar](50) NOT NULL,
	[ChoiceEntityId] [varchar](50) NULL,
	[Text] [varchar](1000) NULL,
	CONSTRAINT PK_SMResponse_Id PRIMARY KEY (Id)
)
GO

