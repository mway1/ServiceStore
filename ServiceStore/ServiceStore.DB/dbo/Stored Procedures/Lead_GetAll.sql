CREATE PROCEDURE [dbo].[Lead_GetAll]
AS
BEGIN

	SELECT L.Id,L.LeadId,L.SubStartDate,L.SubEndDate,S.Name,L.isDeleted
	FROM dbo.Lead as L
	LEFT JOIN dbo.Service as S on (S.Id=L.ServiceId)
END