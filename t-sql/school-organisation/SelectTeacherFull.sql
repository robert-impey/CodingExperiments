/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
	*
FROM 
	[SchoolOrganisation].[dbo].[TeacherFull]
ORDER BY
	FirstName, LastName;
	