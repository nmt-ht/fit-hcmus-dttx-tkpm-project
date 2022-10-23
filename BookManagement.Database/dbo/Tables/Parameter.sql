CREATE TABLE [dbo].[Parameter]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NULL, 
    [Value] INT NULL, 
    [IsActive] BIT NULL, 
    [ParameterType] TINYINT NULL
)
