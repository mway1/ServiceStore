CREATE PROCEDURE [dbo].[Lead_GetById]
	@Id int,
    @LeadId varchar(50),
    @SubStartDate date,
    @SubEndDate date,
    @ServiceId int,
    @isDeleted bit
AS
BEGIN
	SELECT Id,LeadId,SubStartDate,SubEndDate,ServiceId,isDeleted
	FROM dbo.Lead
	WHERE Id=@Id
END