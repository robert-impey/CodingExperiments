USE [SchoolOrganisation]
GO

/****** Object:  View [dbo].[TeacherFull]    Script Date: 09/05/2010 16:49:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[TeacherFull]
AS
SELECT     
	t.Id, 
	t.FirstName, 
	t.LastName, 
	c.Name
FROM
	dbo.Teacher AS t 
		INNER JOIN dbo.Country AS c ON t.CountryId = c.Id

GO
