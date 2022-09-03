CREATE PROCEDURE [dbo].[TypeOfService_Delete]
	@Id int,
	@Name varchar(100),
	@isDeleted bit
AS
BEGIN

UPDATE dbo.TypeOfService
SET	Name=@Name,
	IsDeleted=1
WHERE Id = @Id

END