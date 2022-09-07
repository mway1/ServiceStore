CREATE PROCEDURE [dbo].[Service_Delete]
  @Id int,
  @Name varchar(100),
  @Description text,
  @TypeId int,
  @Price decimal(18),
  @isDeleted bit
AS
BEGIN

UPDATE dbo.Service
SET	Name=@Name,
    Description=@Description,
    TypeId=@TypeId,
    Price=@Price,
	IsDeleted=1
WHERE Id = @Id

END