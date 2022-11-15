CREATE TABLE [dbo].[Parameter]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NULL, 
    [Value] NVARCHAR(255) NULL, 
    [Code] NVARCHAR(255) NULL, 
    [IsActive] BIT NULL, 
    [ParameterType] TINYINT NULL
)
