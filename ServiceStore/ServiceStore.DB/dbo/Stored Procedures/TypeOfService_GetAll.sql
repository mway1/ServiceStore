CREATE PROCEDURE [dbo].[TypeOfService_GetAll]
AS
BEGIN

	SELECT Id,Name,isDeleted
	FROM dbo.TypeOfService
END