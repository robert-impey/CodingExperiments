USE SchoolOrganisation;
GO

IF OBJECT_ID('dbo.Countries') IS NOT NULL
BEGIN
  DROP TABLE dbo.Countries;
END
GO

CREATE TABLE Countries (
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(max) NOT NULL
) ON "PRIMARY";
