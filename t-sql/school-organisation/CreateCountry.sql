USE [SchoolOrganisation]
GO

/****** Object:  Table [dbo].[Country]    Script Date: 09/05/2010 16:17:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL
) ON [PRIMARY]

GO


