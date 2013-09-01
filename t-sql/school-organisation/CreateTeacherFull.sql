USE SchoolOrganisation;
GO

IF OBJECT_ID('dbo.TeachersFull') IS NOT NULL
BEGIN
  DROP VIEW dbo.TeachersFull;
END
GO

CREATE VIEW TeachersFull
AS
SELECT     
	t.Id, 
	t.Name AS Teacher, 
	c.Name AS Country
FROM
	Teachers AS t 
		INNER JOIN Countries AS c ON t.CountryId = c.Id
