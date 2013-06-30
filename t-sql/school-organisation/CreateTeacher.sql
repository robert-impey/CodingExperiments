USE [SchoolOrganisation]
GO

/****** Object:  Table [dbo].[Teacher]    Script Date: 09/04/2010 16:39:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO


