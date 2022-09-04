CREATE PROCEDURE [dbo].[Service_GetAll]
AS
BEGIN

	SELECT S.Id,S.Name,S.Description,T.Name,S.Price,S.isDeleted
	FROM dbo.Service as S
	LEFT JOIN dbo.TypeOfService as T on (T.Id=S.TypeId)
END