CREATE PROCEDURE [dbo].[Lead_GetAll]
AS
BEGIN

	SELECT Id,LeadId,SubStartDate,SubEndDate,ServiceId,isDeleted
	FROM dbo.Lead
END