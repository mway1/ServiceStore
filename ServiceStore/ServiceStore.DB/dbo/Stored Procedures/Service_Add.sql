CREATE PROCEDURE [dbo].[Service_Add]
  @Id int,
  @Name varchar(100),
  @Description text,
  @TypeId int,
  @Price decimal(18),
  @isDeleted bit
AS
BEGIN
INSERT INTO dbo.Service(
        Id,
        Name,
        Description,
        TypeId,
        Price,
		isDeleted)
VALUES(
    @Id,
    @Name,
    @Description,
    @TypeId,
    @Price,
	@isDeleted)
SET @Id=SCOPE_IDENTITY()

SELECT
    Id=@Id,
    Name=@Name,
    Description=@Description,
    TypeId=@TypeId,
    Price=@Price,
	isDeleted=@isDeleted
FROM dbo.Service
END