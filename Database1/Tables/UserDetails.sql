CREATE TABLE [dbo].[UserDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Fullname] NVARCHAR(MAX) NULL, 
    [Age] INT NULL, 
    [GenderId] INT NULL, 
    CONSTRAINT [FK_UserDetails_ToTable] FOREIGN KEY ([GenderId]) REFERENCES [Genders]([Id])
)
