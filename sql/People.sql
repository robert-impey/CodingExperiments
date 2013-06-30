-- Everything after the -- is ignored by the computer.

DECLARE @People TABLE 
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(50),
	SecondName VARCHAR(50)
);

INSERT INTO @People (FirstName, SecondName) VALUES ('Robert', 'Impey');
INSERT INTO @People (FirstName, SecondName) VALUES ('Assunta', 'Cucca');
insert into @People (FirstName, SecondName) values ('Gina', 'Kim');
---- Now add a command to add another person.

 --SELECT * FROM @People;
--SELECT * FROM @People WHERE FirstName = ('gina');
SELECT * FROM @People ORDER BY FirstName ASC;

---- Now write the command that will return the people sorted by their
---- second name in reverse alphabetical order.


--DECLARE @Fruit TABLE
--(
--	Id INT IDENTITY(1,1) PRIMARY KEY,
--	Name VARCHAR(50) UNIQUE
--);

--INSERT INTO @Fruit(Name) VALUES ('Apples');
--INSERT INTO @Fruit(Name) VALUES ('Bananas');
--INSERT INTO @Fruit(Name) VALUES ('Coconuts');
--INSERT INTO @Fruit(Name) VALUES ('Durians');

--SELECT * FROM @Fruit;

---- What happens if you try to add 'Apples' again?
----INSERT INTO @Fruit(Name) VALUES ('Apples');

--DECLARE @TasteInFruit TABLE
--(
--	PersonId INT,
--	FruitId INT
--);

--INSERT INTO @TasteInFruit (PersonId, FruitId) VALUES (1, 1);
--INSERT INTO @TasteInFruit (PersonId, FruitId) VALUES (1, 2);
--INSERT INTO @TasteInFruit (PersonId, FruitId) VALUES (2, 3);

--SELECT * FROM @People AS p INNER JOIN @TasteInFruit AS t ON p.Id = t.PersonId INNER JOIN @Fruit AS f ON t.FruitId = f.Id;

---- What fruits do Robert and Assunta like?
---- What command do you write to store the fact that Assunta likes apples?
