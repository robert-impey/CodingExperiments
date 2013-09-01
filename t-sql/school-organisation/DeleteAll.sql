USE SchoolOrganisation;

DELETE FROM Teachers;
DBCC CHECKIDENT (Teachers, RESEED, 0);

DELETE FROM Countries;
DBCC CHECKIDENT (Countries, RESEED, 0);
