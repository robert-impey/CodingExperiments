USE SchoolOrganisation;
GO

IF OBJECT_ID('dbo.Teachers') IS NOT NULL
BEGIN
  DROP TABLE dbo.Teachers;
END
GO

CREATE TABLE Teachers (
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(50) NOT NULL,
	CountryId int NULL
) ON "PRIMARY";
