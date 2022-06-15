CREATE TABLE [dbo].[CourseInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [Instructor] VARCHAR(50) NOT NULL, 
    [StuId] INT NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Score] DECIMAL(6, 3) NOT NULL, 
    [Grade] VARCHAR(50) NOT NULL
)
