CREATE PROCEDURE [dbo].[Service_GetById]
  @Id int,
  @Name varchar(100),
  @Description text,
  @TypeId int,
  @Price decimal(18),
  @isDeleted bit
AS
BEGIN
	SELECT Id,Name,Description,TypeId,Price,isDeleted
	FROM dbo.Service
	WHERE Id=@Id
END