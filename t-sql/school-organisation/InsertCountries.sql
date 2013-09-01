USE SchoolOrganisation;

DELETE FROM Countries;
DBCC CHECKIDENT (Countries, RESEED, 0);

INSERT INTO Countries
	(Name)
VALUES
	('USA'),
	('UK'),
	('Canada');
