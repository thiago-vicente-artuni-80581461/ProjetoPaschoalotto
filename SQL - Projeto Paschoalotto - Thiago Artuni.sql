CREATE DATABASE ProjetoPaschoalotto
GO

CREATE Table Usuario 
(
   Id INT PRIMARY KEY IDENTITY(1,1),
   Email VARCHAR(100),
   City VARCHAR(40),
   Country VARCHAR(100),
   [First] VARCHAR(100),
   [Last] VARCHAR(100),
   Phone VARCHAR(20),
   Large VARCHAR(200)
)