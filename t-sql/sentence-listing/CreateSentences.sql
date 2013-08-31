USE SentenceListing;
GO

IF OBJECT_ID('dbo.Sentences') IS NOT NULL
BEGIN
  DROP TABLE dbo.Sentences;
END

CREATE TABLE [dbo].[Sentences] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sentence] [nvarchar](max) NOT NULL
) ON [PRIMARY];

