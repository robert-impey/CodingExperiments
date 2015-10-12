-- Solutions to http://www.jitbit.com/news/181-jitbits-sql-interview-questions/

USE [JitBit];

-- List employees (names) who have a bigger salary than their boss

SELECT
	ee.Name
FROM
	Employees AS ee INNER JOIN Employees AS eb ON ee.BossID = eb.EmployeeID
WHERE
	ee.Salary > eb.Salary;

-- List employees who have the biggest salary in their departments

WITH Salaries
AS
(
	SELECT
		d.Name AS Dep, 
		e.Name AS Emp,	
		e.Salary,
		ROW_NUMBER() OVER (PARTITION BY d.DepartmentID ORDER BY e.Salary DESC) AS rn
	FROM
		Departments AS d INNER JOIN Employees AS e ON d.DepartmentID = e.DepartmentID
)
SELECT
		Dep, 
		Emp,	
		Salary
FROM
	Salaries
WHERE
	rn = 1;

-- List departments that have less than 3 people in it

SELECT
	d.Name,
	COUNT(*)
FROM
	Employees AS e INNER JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
GROUP BY
	d.Name
HAVING
	COUNT(*) < 3;

-- List all departments along with the number of people there (tricky - people often do an "inner join" leaving out empty departments)

SELECT
	d.Name,
	COUNT(e.EmployeeID)
FROM
	Departments AS d LEFT OUTER JOIN Employees AS e ON d.DepartmentID = e.DepartmentID
GROUP BY
	d.Name;

-- List employees that don't have a boss in the same department

SELECT
	ee.Name
FROM
	Employees AS ee INNER JOIN Employees AS eb ON ee.BossID = eb.EmployeeID
WHERE
	ee.DepartmentID <> eb.DepartmentID;

-- List all departments along with the total salary there

SELECT
	d.Name,
	COALESCE(SUM(e.Salary), 0)
FROM
	Departments AS d LEFT JOIN Employees AS e ON d.DepartmentID = e.DepartmentID
GROUP BY 
	d.Name;
