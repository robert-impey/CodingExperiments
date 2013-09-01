USE SchoolOrganisation;

DELETE FROM Teachers;
DBCC CHECKIDENT (Teachers, RESEED, 0);

INSERT INTO Teachers
	(Name, CountryId)
SELECT
	'Robert', Id
FROM
	Countries
WHERE
	Name = 'UK';

INSERT INTO Teachers
	(Name, CountryId)
SELECT
	'Adam', Id
FROM
	Countries
WHERE
	Name = 'Canada';

INSERT INTO Teachers
	(Name, CountryId)
SELECT
	'Alex', Id
FROM
	Countries
WHERE
	Name = 'USA';

INSERT INTO Teachers
	(Name, CountryId)
SELECT
	'Arron', Id
FROM
	Countries
WHERE
	Name = 'Canada';
