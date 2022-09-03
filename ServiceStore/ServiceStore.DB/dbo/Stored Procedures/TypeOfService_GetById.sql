CREATE PROCEDURE [dbo].[TypeOfService_GetById]
	@Id int,
	@Name varchar(100),
	@isDeleted bit
AS
BEGIN
	SELECT Id,Name,isDeleted
	FROM dbo.TypeOfService
	WHERE Id=@Id
END