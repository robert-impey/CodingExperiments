/****** Script for SelectTopNRows command from SSMS  ******/
SELECT
	*
FROM 
	[SchoolOrganisation].[dbo].[Teacher]
ORDER BY
	FirstName, LastName;
	