CREATE PROCEDURE [dbo].[TypeOfService_Update]
	@Id int,
	@Name varchar(100),
	@isDeleted bit
AS
BEGIN

UPDATE dbo.TypeOfService
SET Name=@Name,
	isDeleted=@isDeleted
WHERE Id = @Id

END