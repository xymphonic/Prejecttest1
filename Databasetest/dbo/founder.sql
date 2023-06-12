CREATE TABLE [dbo].[founder]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [founder photo] NCHAR(10) NULL, 
    [founder name] NVARCHAR(MAX) NULL, 
    [founder context] NVARCHAR(MAX) NULL
)
