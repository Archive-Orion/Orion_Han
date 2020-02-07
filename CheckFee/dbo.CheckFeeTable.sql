CREATE TABLE [dbo].[CheckFeeTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(MAX) NULL, 
    [studentID] INT NULL, 
    [depart] NVARCHAR(MAX) NULL, 
    [fee] BIT NULL
)
