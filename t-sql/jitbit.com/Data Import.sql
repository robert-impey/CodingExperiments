-- Solutions to interview questions at jitbit.com
-- http://www.jitbit.com/news/181-jitbits-sql-interview-questions/
-- Robert Impey 2013-08-28

USE JitBit;

DELETE FROM Employees;
DELETE FROM Departments;

INSERT INTO Departments 
	(Name) 
VALUES
	('Sales'),
	('Research'),
	('Support'),
	('Maintenance');

-- The bosses
INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Adam', 50000
FROM
	Departments
WHERE
	Name = 'Sales';
	
INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Betty', 55000
FROM
	Departments
WHERE
	Name = 'Research';
	
INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Carl', 40000
FROM
	Departments
WHERE
	Name = 'Support';

-- The minions
INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Debbie', 30000
FROM
	Departments
WHERE
	Name = 'Sales';

UPDATE Employees
SET BossID = (
	SELECT EmployeeID FROM Employees WHERE Name = 'Adam'
)
WHERE
	Name = 'Debbie';

INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Eric', 50000
FROM
	Departments
WHERE
	Name = 'Sales';

UPDATE Employees
SET BossID = (
	SELECT EmployeeID FROM Employees WHERE Name = 'Betty'
)
WHERE
	Name = 'Eric';

INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Frances', 55000
FROM
	Departments
WHERE
	Name = 'Sales';

UPDATE Employees
SET BossID = (
	SELECT EmployeeID FROM Employees WHERE Name = 'Adam'
)
WHERE
	Name = 'Frances';

INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Graham', 45000
FROM
	Departments
WHERE
	Name = 'Research';

UPDATE Employees
SET BossID = (
	SELECT EmployeeID FROM Employees WHERE Name = 'Betty'
)
WHERE
	Name = 'Graham';

INSERT INTO Employees
	(DepartmentID, Name, Salary)
SELECT
	DepartmentID, 'Hettie', 25000
FROM
	Departments
WHERE
	Name = 'Support';

UPDATE Employees
SET BossID = (
	SELECT EmployeeID FROM Employees WHERE Name = 'Carl'
)
WHERE
	Name = 'Hettie';

SELECT * FROM Employees;
SELECT * FROM Departments;
