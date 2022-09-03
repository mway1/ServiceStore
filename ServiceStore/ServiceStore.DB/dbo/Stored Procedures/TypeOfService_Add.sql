CREATE PROCEDURE [dbo].[TypeOfService_Add]
  @Id int,
  @Name varchar(100),
  @isDeleted bit
AS
BEGIN
INSERT INTO dbo.TypeOfService(
        Id,
        Name,
		isDeleted)
VALUES(
    @Id,
    @Name,
	@isDeleted)
SET @Id=SCOPE_IDENTITY()

SELECT
    Id=@Id,
    Name=@Name,
	isDeleted=@isDeleted
FROM dbo.TypeOfService
END