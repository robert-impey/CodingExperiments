DELETE FROM [SentenceListing].[dbo].[Sentences];
DBCC CHECKIDENT (Sentences, RESEED, 0);
