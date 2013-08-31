USE SentenceListing;
GO

DELETE FROM Sentences;

DBCC CHECKIDENT (Sentences, RESEED, 0);
