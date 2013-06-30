USE [SentenceListing]
GO

/****** Object:  Table [dbo].[Sentences]    Script Date: 09/06/2010 20:15:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sentences](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sentence] [nvarchar](max) NOT NULL
) ON [PRIMARY]

GO


